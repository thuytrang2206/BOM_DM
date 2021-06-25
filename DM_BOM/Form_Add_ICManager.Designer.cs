namespace DM_BOM
{
    partial class Form_Add_ICManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_ICManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPartBOM = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPartCUS = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.labelmain = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblerrormain = new System.Windows.Forms.Label();
            this.lblerrorpartlist = new System.Windows.Forms.Label();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPartBOM);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.txtPartCUS);
            this.groupBox1.Controls.Add(this.labelmain);
            this.groupBox1.Controls.Add(this.lblerrormain);
            this.groupBox1.Controls.Add(this.lblerrorpartlist);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtPartBOM
            // 
            this.txtPartBOM.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPartBOM.Location = new System.Drawing.Point(206, 80);
            this.txtPartBOM.Name = "txtPartBOM";
            this.txtPartBOM.Size = new System.Drawing.Size(133, 20);
            this.txtPartBOM.TabIndex = 14;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(94, 81);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 15);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Part on BOM SAP:";
            // 
            // txtPartCUS
            // 
            this.txtPartCUS.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPartCUS.Location = new System.Drawing.Point(206, 25);
            this.txtPartCUS.Name = "txtPartCUS";
            this.txtPartCUS.Size = new System.Drawing.Size(130, 20);
            this.txtPartCUS.TabIndex = 12;
            // 
            // labelmain
            // 
            this.labelmain.AutoSize = true;
            this.labelmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmain.Location = new System.Drawing.Point(48, 26);
            this.labelmain.Name = "labelmain";
            this.labelmain.Size = new System.Drawing.Size(152, 15);
            this.labelmain.TabIndex = 11;
            this.labelmain.Text = "Part on BOM CUSTOMER:";
            // 
            // lblerrormain
            // 
            this.lblerrormain.AutoSize = true;
            this.lblerrormain.ForeColor = System.Drawing.Color.Red;
            this.lblerrormain.Location = new System.Drawing.Point(203, 105);
            this.lblerrormain.Name = "lblerrormain";
            this.lblerrormain.Size = new System.Drawing.Size(0, 13);
            this.lblerrormain.TabIndex = 10;
            // 
            // lblerrorpartlist
            // 
            this.lblerrorpartlist.AutoSize = true;
            this.lblerrorpartlist.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpartlist.Location = new System.Drawing.Point(205, 52);
            this.lblerrorpartlist.Name = "lblerrorpartlist";
            this.lblerrorpartlist.Size = new System.Drawing.Size(0, 13);
            this.lblerrorpartlist.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(155, 123);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form_Add_ICManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 194);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Add_ICManager";
            this.Text = "IC Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblerrormain;
        private System.Windows.Forms.Label lblerrorpartlist;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPartBOM;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPartCUS;
        private Bunifu.Framework.UI.BunifuCustomLabel labelmain;
    }
}