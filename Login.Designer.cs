namespace pharmacymanagementandpos
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginPass = new MetroFramework.Controls.MetroTextBox();
            this.txtUserlogin = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 62);
            this.panel1.TabIndex = 15;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::pharmacymanagementandpos.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(898, 9);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(50, 46);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Please Login first";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(305, 619);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(339, 30);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnLoginCancel.FlatAppearance.BorderSize = 0;
            this.btnLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginCancel.ForeColor = System.Drawing.Color.White;
            this.btnLoginCancel.Location = new System.Drawing.Point(305, 655);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(339, 30);
            this.btnLoginCancel.TabIndex = 21;
            this.btnLoginCancel.Text = "Cancel";
            this.btnLoginCancel.UseVisualStyleBackColor = false;
            this.btnLoginCancel.Click += new System.EventHandler(this.btnLoginCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(828, 697);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "@Techno Revengers";
            // 
            // txtLoginPass
            // 
            // 
            // 
            // 
            this.txtLoginPass.CustomButton.Image = null;
            this.txtLoginPass.CustomButton.Location = new System.Drawing.Point(313, 2);
            this.txtLoginPass.CustomButton.Name = "";
            this.txtLoginPass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLoginPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginPass.CustomButton.TabIndex = 1;
            this.txtLoginPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginPass.CustomButton.UseSelectable = true;
            this.txtLoginPass.CustomButton.Visible = false;
            this.txtLoginPass.DisplayIcon = true;
            this.txtLoginPass.Icon = global::pharmacymanagementandpos.Properties.Resources.key__2_;
            this.txtLoginPass.Lines = new string[0];
            this.txtLoginPass.Location = new System.Drawing.Point(305, 563);
            this.txtLoginPass.MaxLength = 32767;
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.PasswordChar = '●';
            this.txtLoginPass.PromptText = "Password";
            this.txtLoginPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginPass.SelectedText = "";
            this.txtLoginPass.SelectionLength = 0;
            this.txtLoginPass.SelectionStart = 0;
            this.txtLoginPass.ShortcutsEnabled = true;
            this.txtLoginPass.Size = new System.Drawing.Size(339, 28);
            this.txtLoginPass.TabIndex = 19;
            this.txtLoginPass.UseSelectable = true;
            this.txtLoginPass.UseSystemPasswordChar = true;
            this.txtLoginPass.WaterMark = "Password";
            this.txtLoginPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoginPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginPass_KeyPress);
            // 
            // txtUserlogin
            // 
            // 
            // 
            // 
            this.txtUserlogin.CustomButton.Image = null;
            this.txtUserlogin.CustomButton.Location = new System.Drawing.Point(313, 2);
            this.txtUserlogin.CustomButton.Name = "";
            this.txtUserlogin.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUserlogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserlogin.CustomButton.TabIndex = 1;
            this.txtUserlogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserlogin.CustomButton.UseSelectable = true;
            this.txtUserlogin.CustomButton.Visible = false;
            this.txtUserlogin.DisplayIcon = true;
            this.txtUserlogin.Icon = global::pharmacymanagementandpos.Properties.Resources.user__3_;
            this.txtUserlogin.Lines = new string[0];
            this.txtUserlogin.Location = new System.Drawing.Point(305, 508);
            this.txtUserlogin.MaxLength = 32767;
            this.txtUserlogin.Multiline = true;
            this.txtUserlogin.Name = "txtUserlogin";
            this.txtUserlogin.PasswordChar = '\0';
            this.txtUserlogin.PromptText = "Username";
            this.txtUserlogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserlogin.SelectedText = "";
            this.txtUserlogin.SelectionLength = 0;
            this.txtUserlogin.SelectionStart = 0;
            this.txtUserlogin.ShortcutsEnabled = true;
            this.txtUserlogin.Size = new System.Drawing.Size(339, 28);
            this.txtUserlogin.TabIndex = 17;
            this.txtUserlogin.UseSelectable = true;
            this.txtUserlogin.WaterMark = "Username";
            this.txtUserlogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserlogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pharmacymanagementandpos.Properties.Resources.RoboPharm_20241107_105347_0000;
            this.pictureBox2.Location = new System.Drawing.Point(199, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(552, 397);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 722);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoginCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserlogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtUserlogin;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtLoginPass;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button btnLoginCancel;
        private System.Windows.Forms.Label label3;
    }
}