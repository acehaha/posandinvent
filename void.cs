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
    public partial class Void : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CancelOrder cancelorder;
        public Void(CancelOrder cancel)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            txtUserlogin.Focus();
            cancelorder = cancel;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUserlogin.Text.ToLower() == cancelorder.txtCancelledBy.Text.ToLower())
                {
                    MessageBox.Show("Void by name and cancelledby by name are same!. Please void by another person", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string user;
                cn.Open();
                cm = new SqlCommand("Select * From tbUser Where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUserlogin);
                cm.Parameters.AddWithValue("@password", txtPass);
                cm.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    user = dr["username"].ToString();
                    dr.Close();
                    cn.Open();
                    SaveCancelOrder(user);
                    if(cancelorder.cboAddtoinvent.Text=="yes")
                    {
                        dbcon.ExcuteQuery("UPDATE tbProduct SET qty = qty + " + cancelorder.udCancelqty.Value + "Where pcode = '" + cancelorder.txtPcode.Text + "'");
                    }
                    dbcon.ExcuteQuery("UPDATE tbCart SET qty = qty + " + cancelorder.udCancelqty.Value + "where id LIKE = '" + cancelorder.txtId.Text + "'");
                    MessageBox.Show("Order transaction successfully cancelled!", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    cancelorder.ReloadSoldList();
                    cancelorder.Dispose();
                }
                dr.Close();
                cn.Close(); 
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }

        public void SaveCancelOrder(string user)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("insert into tbCancel (transno, pcode, price, qty, total, sdate, voidby, cancelledby, reason, action) values (@transno, @pcode, @price, @qty, @total, @sdate, @voidby, @cancelledby, @reason, @action)", cn);
                cm.Parameters.AddWithValue("@transno", cancelorder.txtTransno.Text);
                cm.Parameters.AddWithValue("@pcode", cancelorder.txtPcode.Text);
                cm.Parameters.AddWithValue("@price", double.Parse(cancelorder.txtPrice.Text));
                cm.Parameters.AddWithValue("@qty", int.Parse(cancelorder.txtQty.Text));
                cm.Parameters.AddWithValue("@total", double.Parse(cancelorder.txtTotal.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@voidby", user);
                cm.Parameters.AddWithValue("@cancelledby", cancelorder.txtTransno.Text);
                cm.Parameters.AddWithValue("@reason", cancelorder.txtReason.Text);
                cm.Parameters.AddWithValue("@action", cancelorder.cboAddtoinvent.Text);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void txtUserlogin_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
