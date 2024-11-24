namespace pharmacymanagementandpos
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangepass = new System.Windows.Forms.Button();
            this.btnDailysales = new System.Windows.Forms.Button();
            this.btnClearcart = new System.Windows.Forms.Button();
            this.btnSettle = new System.Windows.Forms.Button();
            this.btnAdddisc = new System.Windows.Forms.Button();
            this.btnSearchprd = new System.Windows.Forms.Button();
            this.btnNtran = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCashier = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblVatable = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSaleTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTranno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.dgvCash = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewImageColumn();
            this.colReduce = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnChangepass);
            this.panel1.Controls.Add(this.btnDailysales);
            this.panel1.Controls.Add(this.btnClearcart);
            this.panel1.Controls.Add(this.btnSettle);
            this.panel1.Controls.Add(this.btnAdddisc);
            this.panel1.Controls.Add(this.btnSearchprd);
            this.panel1.Controls.Add(this.btnNtran);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 657);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::pharmacymanagementandpos.Properties.Resources.exit__1_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 607);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangepass
            // 
            this.btnChangepass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangepass.FlatAppearance.BorderSize = 0;
            this.btnChangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangepass.ForeColor = System.Drawing.Color.Black;
            this.btnChangepass.Image = global::pharmacymanagementandpos.Properties.Resources.reset_password;
            this.btnChangepass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangepass.Location = new System.Drawing.Point(0, 465);
            this.btnChangepass.Name = "btnChangepass";
            this.btnChangepass.Size = new System.Drawing.Size(200, 50);
            this.btnChangepass.TabIndex = 7;
            this.btnChangepass.Text = "Change Password";
            this.btnChangepass.UseVisualStyleBackColor = true;
            this.btnChangepass.Click += new System.EventHandler(this.btnChangepass_Click);
            // 
            // btnDailysales
            // 
            this.btnDailysales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDailysales.FlatAppearance.BorderSize = 0;
            this.btnDailysales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailysales.ForeColor = System.Drawing.Color.Black;
            this.btnDailysales.Image = global::pharmacymanagementandpos.Properties.Resources.sales;
            this.btnDailysales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailysales.Location = new System.Drawing.Point(0, 415);
            this.btnDailysales.Name = "btnDailysales";
            this.btnDailysales.Size = new System.Drawing.Size(200, 50);
            this.btnDailysales.TabIndex = 6;
            this.btnDailysales.Text = "Daily Sales";
            this.btnDailysales.UseVisualStyleBackColor = true;
            this.btnDailysales.Click += new System.EventHandler(this.btnDailysales_Click);
            // 
            // btnClearcart
            // 
            this.btnClearcart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearcart.FlatAppearance.BorderSize = 0;
            this.btnClearcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearcart.ForeColor = System.Drawing.Color.Black;
            this.btnClearcart.Image = global::pharmacymanagementandpos.Properties.Resources.shop;
            this.btnClearcart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearcart.Location = new System.Drawing.Point(0, 365);
            this.btnClearcart.Name = "btnClearcart";
            this.btnClearcart.Size = new System.Drawing.Size(200, 50);
            this.btnClearcart.TabIndex = 5;
            this.btnClearcart.Text = "Clear Cart";
            this.btnClearcart.UseVisualStyleBackColor = true;
            this.btnClearcart.Click += new System.EventHandler(this.btnClearcart_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettle.FlatAppearance.BorderSize = 0;
            this.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettle.ForeColor = System.Drawing.Color.Black;
            this.btnSettle.Image = global::pharmacymanagementandpos.Properties.Resources.calculater;
            this.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettle.Location = new System.Drawing.Point(0, 315);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(200, 50);
            this.btnSettle.TabIndex = 4;
            this.btnSettle.Text = "Settle Payment";
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // btnAdddisc
            // 
            this.btnAdddisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdddisc.FlatAppearance.BorderSize = 0;
            this.btnAdddisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdddisc.ForeColor = System.Drawing.Color.Black;
            this.btnAdddisc.Image = global::pharmacymanagementandpos.Properties.Resources.offer;
            this.btnAdddisc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdddisc.Location = new System.Drawing.Point(0, 265);
            this.btnAdddisc.Name = "btnAdddisc";
            this.btnAdddisc.Size = new System.Drawing.Size(200, 50);
            this.btnAdddisc.TabIndex = 3;
            this.btnAdddisc.Text = "Add Discount";
            this.btnAdddisc.UseVisualStyleBackColor = true;
            this.btnAdddisc.Click += new System.EventHandler(this.btnAdddisc_Click);
            // 
            // btnSearchprd
            // 
            this.btnSearchprd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchprd.FlatAppearance.BorderSize = 0;
            this.btnSearchprd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchprd.ForeColor = System.Drawing.Color.Black;
            this.btnSearchprd.Image = global::pharmacymanagementandpos.Properties.Resources.search;
            this.btnSearchprd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchprd.Location = new System.Drawing.Point(0, 215);
            this.btnSearchprd.Name = "btnSearchprd";
            this.btnSearchprd.Size = new System.Drawing.Size(200, 50);
            this.btnSearchprd.TabIndex = 2;
            this.btnSearchprd.Text = "Search Product";
            this.btnSearchprd.UseVisualStyleBackColor = true;
            this.btnSearchprd.Click += new System.EventHandler(this.btnSearchprd_Click);
            // 
            // btnNtran
            // 
            this.btnNtran.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNtran.FlatAppearance.BorderSize = 0;
            this.btnNtran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNtran.ForeColor = System.Drawing.Color.Black;
            this.btnNtran.Image = global::pharmacymanagementandpos.Properties.Resources.money_transfer;
            this.btnNtran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNtran.Location = new System.Drawing.Point(0, 165);
            this.btnNtran.Name = "btnNtran";
            this.btnNtran.Size = new System.Drawing.Size(200, 50);
            this.btnNtran.TabIndex = 1;
            this.btnNtran.Text = "New Transaction";
            this.btnNtran.UseVisualStyleBackColor = true;
            this.btnNtran.Click += new System.EventHandler(this.btnNtran_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCashier);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 165);
            this.panel2.TabIndex = 0;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.ForeColor = System.Drawing.Color.Black;
            this.lblCashier.Location = new System.Drawing.Point(64, 129);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(79, 20);
            this.lblCashier.TabIndex = 1;
            this.lblCashier.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pharmacymanagementandpos.Properties.Resources.cashier_machine__1_;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panelSlide);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 657);
            this.panel3.TabIndex = 1;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSlide.Location = new System.Drawing.Point(0, 165);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(8, 50);
            this.panelSlide.TabIndex = 4;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.picClose);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(208, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 43);
            this.panel4.TabIndex = 2;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::pharmacymanagementandpos.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(996, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(46, 37);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pharmacymanagementandpos.Properties.Resources.user__2_;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(52, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name And Role";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtQty);
            this.panel5.Controls.Add(this.lblTimer);
            this.panel5.Controls.Add(this.lblVatable);
            this.panel5.Controls.Add(this.lblVat);
            this.panel5.Controls.Add(this.lblDiscount);
            this.panel5.Controls.Add(this.lblSaleTotal);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtBarcode);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lblTranno);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblDisplayTotal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1040, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 614);
            this.panel5.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(152, 257);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(49, 32);
            this.txtQty.TabIndex = 16;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(0, 564);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(213, 50);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVatable
            // 
            this.lblVatable.Location = new System.Drawing.Point(100, 467);
            this.lblVatable.Name = "lblVatable";
            this.lblVatable.Size = new System.Drawing.Size(101, 20);
            this.lblVatable.TabIndex = 14;
            this.lblVatable.Text = "0.00";
            this.lblVatable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVat
            // 
            this.lblVat.Location = new System.Drawing.Point(100, 435);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(101, 20);
            this.lblVat.TabIndex = 13;
            this.lblVat.Text = "0.00";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(100, 402);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(101, 20);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaleTotal
            // 
            this.lblSaleTotal.Location = new System.Drawing.Point(111, 372);
            this.lblSaleTotal.Name = "lblSaleTotal";
            this.lblSaleTotal.Size = new System.Drawing.Size(90, 20);
            this.lblSaleTotal.TabIndex = 11;
            this.lblSaleTotal.Text = "0.00";
            this.lblSaleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "VATable :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "VAT : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Discount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sales Total :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(6, 257);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(140, 32);
            this.txtBarcode.TabIndex = 6;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "[F8] Barcode";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 197);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(121, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "00000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Date";
            // 
            // lblTranno
            // 
            this.lblTranno.AutoSize = true;
            this.lblTranno.Location = new System.Drawing.Point(15, 123);
            this.lblTranno.Name = "lblTranno";
            this.lblTranno.Size = new System.Drawing.Size(121, 20);
            this.lblTranno.TabIndex = 2;
            this.lblTranno.Text = "00000000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Transaction No";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDisplayTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTotal.Location = new System.Drawing.Point(0, 0);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(213, 30);
            this.lblDisplayTotal.TabIndex = 0;
            this.lblDisplayTotal.Text = "0.00";
            this.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvCash
            // 
            this.dgvCash.AllowUserToAddRows = false;
            this.dgvCash.BackgroundColor = System.Drawing.Color.White;
            this.dgvCash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCash.ColumnHeadersHeight = 30;
            this.dgvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7,
            this.colAdd,
            this.colReduce,
            this.Delete});
            this.dgvCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCash.EnableHeadersVisualStyles = false;
            this.dgvCash.Location = new System.Drawing.Point(208, 43);
            this.dgvCash.Name = "dgvCash";
            this.dgvCash.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCash.RowHeadersVisible = false;
            this.dgvCash.Size = new System.Drawing.Size(832, 614);
            this.dgvCash.TabIndex = 4;
            this.dgvCash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCash_CellContentClick);
            this.dgvCash.SelectionChanged += new System.EventHandler(this.dgvCash_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 51;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 47;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Pcode";
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.Width = 67;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "Qty";
            this.Column6.Name = "Column6";
            this.Column6.Width = 55;
            // 
            // Column8
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column8.HeaderText = "Discount";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            this.Column7.Width = 64;
            // 
            // colAdd
            // 
            this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAdd.HeaderText = "";
            this.colAdd.Image = global::pharmacymanagementandpos.Properties.Resources.plus;
            this.colAdd.Name = "colAdd";
            this.colAdd.Width = 5;
            // 
            // colReduce
            // 
            this.colReduce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReduce.HeaderText = "";
            this.colReduce.Image = global::pharmacymanagementandpos.Properties.Resources.minus;
            this.colReduce.Name = "colReduce";
            this.colReduce.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::pharmacymanagementandpos.Properties.Resources.delete__1_;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::pharmacymanagementandpos.Properties.Resources.plus;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::pharmacymanagementandpos.Properties.Resources.minus;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::pharmacymanagementandpos.Properties.Resources.delete__1_;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 657);
            this.Controls.Add(this.dgvCash);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cashier_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cashier_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNtran;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangepass;
        private System.Windows.Forms.Button btnClearcart;
        private System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.Button btnAdddisc;
        private System.Windows.Forms.Button btnSearchprd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblCashier;
        public System.Windows.Forms.Label lblTranno;
        private System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtBarcode;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.DataGridView dgvCash;
        public System.Windows.Forms.Label lblDisplayTotal;
        public System.Windows.Forms.Label lblDiscount;
        public System.Windows.Forms.Label lblSaleTotal;
        public System.Windows.Forms.Label lblVatable;
        public System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn colAdd;
        private System.Windows.Forms.DataGridViewImageColumn colReduce;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.Button btnDailysales;
    }
}