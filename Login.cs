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
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public string _pass = "";
        public bool _isactive;

        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "", _name = "", _role = "";
            try
            {
                bool found;
                cn.Open();
                cm = new SqlCommand("Select * From tbUser Where username = @username and password =@password", cn);
                cm.Parameters.AddWithValue("@username", txtUserlogin.Text);
                cm.Parameters.AddWithValue("@password", txtLoginPass.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    _pass = dr["password"].ToString();
                    _isactive = bool.Parse(dr["isactive"].ToString());
                }

                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if(found)
                {
                    if(!_isactive)
                    {
                        MessageBox.Show("Account is inactive. Unable to login", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (_role == "Cashier")
                    {
                        MessageBox.Show("Welcome " + _name + " ", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserlogin.Clear();
                        txtLoginPass.Clear();
                        this.Hide();
                        Cashier cashier = new Cashier();
                        cashier.lblCashier.Text = _username;
                        cashier.lblName.Text = _name + "|" + _role;
                        cashier.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + " ", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserlogin.Clear();
                        txtLoginPass.Clear();
                        this.Hide();
                        MainForm main = new MainForm();
                        main.labelUsername.Text = _username;
                        main.labelName.Text = _name;
                        main.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "Access Denied", MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

              cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtLoginPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                btnLogin.PerformClick();
            }
        }

    }
}
