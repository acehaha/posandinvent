using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacymanagementandpos
{
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point of Sales";
        public StockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
            GetRefNo();
        }

        public void GetRefNo()
        {
            Random rnd = new Random();
            txtRefno.Clear();
            txtRefno.Text += rnd.Next();
        }

        public void LoadSupplier()
        {
            cboSupplier.Items.Clear();
            cboSupplier.DataSource = dbcon.getTable("SELECT * FROM tbSupplier");
            cboSupplier.DisplayMember = "supplier";
        }

        public void LoadStockIn()
        {
            int i = 0;
            dgvStockin.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE refno LIKE '" + txtRefno.Text + "' AND status LIKE 'Pending'", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvStockin.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr["supplier"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier WHERE supplier LIKE '" + cboSupplier.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                lblId.Text = dr["id"].ToString();
                txtContactp.Text = dr["contactperson"].ToString();
                txtAddress.Text = dr["address"].ToString(); 
            }
            dr.Close();
            cn.Close();
        }

        private void cboSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void linGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefNo();
        }

        private void LinProduct_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStock = new ProductStockIn(this);
            productStock.ShowDialog();
        }

        private void dgvStockin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockin.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblStockin WHERE id= '" + dgvStockin.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully removed", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStockin.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this record?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
                    {
                        for(int i=0; i < dgvStockin.Rows.Count;i++)
                        {
                            //update product qty
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbProduct SET qty = qty" + int.Parse(dgvStockin.Rows[i].Cells[5].Value.ToString()) + "WHERE pcode LIKE '" + dgvStockin.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //update stockin qty
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblStockin SET qty = qty + " + int.Parse(dgvStockin.Rows[i].Cells[5].Value.ToString()) + ", status='Done' WHERE id LIKE '" + dgvStockin.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery() ;
                            cn.Close();
                        }
                        Clear();
                        LoadStockIn();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Clear()
        {
            txtRefno.Clear();
            txtStockinby.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            dgvStockin.AutoGenerateColumns = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                dgvStockinhistory.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM vwStockIn WHERE CAST (sdate as date) BETWEEN '" + dtFrom.Value.ToShortDateString() + "' AND '" + dtTo.Value.ToShortDateString() + "' AND status LIKE 'Done'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvStockinhistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString(), dr["supplier"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
