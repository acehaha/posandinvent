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
    public partial class CancelOrder : Form
    {
        DailySale dailySale;
        public CancelOrder(DailySale sale)
        {
            InitializeComponent();
            dailySale = sale;
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnCorder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboAddtoinvent.Text != string.Empty && udCancelqty.Value > 0 && txtReason.Text != string.Empty)
                {
                    if(int.Parse(txtQty.Text) >= udCancelqty.Value)
                    {
                        Void @void = new Void(this);
                        @void.txtUserlogin.Focus();
                        @void.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ReloadSoldList()
        {
            dailySale.LoadSold();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboAddtoinvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
