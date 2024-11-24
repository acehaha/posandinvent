namespace pharmacymanagementandpos
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtConpass = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewpass = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 40);
            this.panel1.TabIndex = 15;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::pharmacymanagementandpos.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(498, 9);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(34, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Your Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pharmacymanagementandpos.Properties.Resources.user__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(42, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(432, 2);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.DisplayIcon = true;
            this.txtPass.Icon = global::pharmacymanagementandpos.Properties.Resources.key__2_;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(42, 136);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PromptText = "Current Password";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(458, 28);
            this.txtPass.TabIndex = 20;
            this.txtPass.UseSelectable = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WaterMark = "Current Password";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(122, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 19);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(389, 253);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 30);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtConpass
            // 
            // 
            // 
            // 
            this.txtConpass.CustomButton.Image = null;
            this.txtConpass.CustomButton.Location = new System.Drawing.Point(432, 2);
            this.txtConpass.CustomButton.Name = "";
            this.txtConpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConpass.CustomButton.TabIndex = 1;
            this.txtConpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConpass.CustomButton.UseSelectable = true;
            this.txtConpass.CustomButton.Visible = false;
            this.txtConpass.DisplayIcon = true;
            this.txtConpass.Icon = global::pharmacymanagementandpos.Properties.Resources.key__2_;
            this.txtConpass.Lines = new string[0];
            this.txtConpass.Location = new System.Drawing.Point(42, 188);
            this.txtConpass.MaxLength = 32767;
            this.txtConpass.Name = "txtConpass";
            this.txtConpass.PasswordChar = '●';
            this.txtConpass.PromptText = "Confirm Password";
            this.txtConpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConpass.SelectedText = "";
            this.txtConpass.SelectionLength = 0;
            this.txtConpass.SelectionStart = 0;
            this.txtConpass.ShortcutsEnabled = true;
            this.txtConpass.Size = new System.Drawing.Size(458, 28);
            this.txtConpass.TabIndex = 23;
            this.txtConpass.UseSelectable = true;
            this.txtConpass.UseSystemPasswordChar = true;
            this.txtConpass.Visible = false;
            this.txtConpass.WaterMark = "Confirm Password";
            this.txtConpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(389, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewpass
            // 
            // 
            // 
            // 
            this.txtNewpass.CustomButton.Image = null;
            this.txtNewpass.CustomButton.Location = new System.Drawing.Point(432, 2);
            this.txtNewpass.CustomButton.Name = "";
            this.txtNewpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNewpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewpass.CustomButton.TabIndex = 1;
            this.txtNewpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewpass.CustomButton.UseSelectable = true;
            this.txtNewpass.CustomButton.Visible = false;
            this.txtNewpass.DisplayIcon = true;
            this.txtNewpass.Icon = global::pharmacymanagementandpos.Properties.Resources.key__2_;
            this.txtNewpass.Lines = new string[0];
            this.txtNewpass.Location = new System.Drawing.Point(42, 136);
            this.txtNewpass.MaxLength = 32767;
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.PasswordChar = '●';
            this.txtNewpass.PromptText = "New Password";
            this.txtNewpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewpass.SelectedText = "";
            this.txtNewpass.SelectionLength = 0;
            this.txtNewpass.SelectionStart = 0;
            this.txtNewpass.ShortcutsEnabled = true;
            this.txtNewpass.Size = new System.Drawing.Size(458, 28);
            this.txtNewpass.TabIndex = 25;
            this.txtNewpass.UseSelectable = true;
            this.txtNewpass.UseSystemPasswordChar = true;
            this.txtNewpass.WaterMark = "New Password";
            this.txtNewpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 308);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConpass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Button btnNext;
        private MetroFramework.Controls.MetroTextBox txtConpass;
        public System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtNewpass;
    }
}