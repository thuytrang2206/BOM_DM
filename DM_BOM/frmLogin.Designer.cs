namespace DM_BOM
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtpassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtstaffcode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DM_BOM.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtstaffcode);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Location = new System.Drawing.Point(220, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.BackColor = System.Drawing.SystemColors.Control;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.White;
            this.btn_login.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.Location = new System.Drawing.Point(132, 146);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(72, 41);
            this.btn_login.TabIndex = 10;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 119);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(61, 15);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Password";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(34, 68);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(68, 15);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Username:";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtpassword.Location = new System.Drawing.Point(108, 118);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(122, 20);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtstaffcode
            // 
            this.txtstaffcode.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtstaffcode.Location = new System.Drawing.Point(108, 67);
            this.txtstaffcode.Name = "txtstaffcode";
            this.txtstaffcode.Size = new System.Drawing.Size(122, 20);
            this.txtstaffcode.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(105, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "ĐĂNG NHẬP";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 217);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtpassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtstaffcode;
    }
}