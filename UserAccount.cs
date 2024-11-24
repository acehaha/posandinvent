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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        public void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtRetype.Clear();
            txtUsername.Clear();
            cboRole.Text = "";
            txtUsername.Focus();
        }
        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtRetype.Text)
                {
                    MessageBox.Show("Password did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("Insert into tbUser(username, password, role, name) Values (@username, @password, @role, @name)", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                cm.Parameters.AddWithValue("@role", cboRole.Text);
                cm.Parameters.AddWithValue("@name", txtFullname.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New Account has been successfully saved!", "Save Record",MessageBoxButtons.OK, MessageBoxIcon.Information );
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
