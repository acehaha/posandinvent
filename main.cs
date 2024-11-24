using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharmacymanagementandpos
{  
    public partial class MainForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
            MessageBox.Show("Database is Connected");
        }
        #region panelSlide
        private void CustomizeDesign()
        {
            panelSubproduct.Visible = false;
            panelSubinstock.Visible = false;
            panelSubrecord.Visible = false;
            panelSubsettings.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubproduct.Visible == true)
                panelSubproduct.Visible = false;
            if (panelSubrecord.Visible == true)
                panelSubrecord.Visible = false;
            if (panelSubsettings.Visible == true)
                panelSubsettings.Visible = false;
            if (panelSubinstock.Visible == true)
                panelSubinstock.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion panelSlide


        private Form activeForm = null;
        public void openChildForm(Form childForm)
        { 
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lbllTitle.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubproduct);
        }

        private void btnProductlist_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
            hideSubmenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
            hideSubmenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
            hideSubmenu();
        }

        private void btnInstock_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubinstock);
        }

        private void btnStockentry_Click(object sender, EventArgs e)
        {
            openChildForm(new StockIn());
            hideSubmenu();
        }

        private void btnStockadjustment_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            hideSubmenu();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubrecord);
        }

        private void btnSalehistory_Click(object sender, EventArgs e)
        {
            openChildForm(new DailySale(this));
            hideSubmenu();
        }

        private void btnPosrecord_Click(object sender, EventArgs e)
        {
            openChildForm(new Record());
            hideSubmenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubsettings);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserAccount());
            hideSubmenu();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Store store = new Store();
            store.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            openChildForm(new Barcode());
            hideSubmenu();
        }
    }
}
