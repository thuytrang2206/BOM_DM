namespace DM_BOM
{
    partial class Form_Add_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_User));
            this.lblerror4 = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.roleuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOM_DMDataSet = new DM_BOM.BOM_DMDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.lblerror3 = new System.Windows.Forms.Label();
            this.txtpass = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblpass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblerror2 = new System.Windows.Forms.Label();
            this.txtname = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtstaff = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblerror1 = new System.Windows.Forms.Label();
            this.lblname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblstaff = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.role_userTableAdapter = new DM_BOM.BOM_DMDataSetTableAdapters.Role_userTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roleuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOM_DMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblerror4
            // 
            this.lblerror4.AutoSize = true;
            this.lblerror4.ForeColor = System.Drawing.Color.Red;
            this.lblerror4.Location = new System.Drawing.Point(120, 172);
            this.lblerror4.Name = "lblerror4";
            this.lblerror4.Size = new System.Drawing.Size(0, 13);
            this.lblerror4.TabIndex = 47;
            // 
            // cmbrole
            // 
            this.cmbrole.DataSource = this.roleuserBindingSource;
            this.cmbrole.DisplayMember = "Name";
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(120, 148);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(121, 21);
            this.cmbrole.TabIndex = 46;
            this.cmbrole.ValueMember = "Id_Role";
            this.cmbrole.SelectedIndexChanged += new System.EventHandler(this.cmbrole_SelectedIndexChanged);
            // 
            // roleuserBindingSource
            // 
            this.roleuserBindingSource.DataMember = "Role_user";
            this.roleuserBindingSource.DataSource = this.bOM_DMDataSet;
            // 
            // bOM_DMDataSet
            // 
            this.bOM_DMDataSet.DataSetName = "BOM_DMDataSet";
            this.bOM_DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Role:";
            // 
            // lblerror3
            // 
            this.lblerror3.AutoSize = true;
            this.lblerror3.ForeColor = System.Drawing.Color.Red;
            this.lblerror3.Location = new System.Drawing.Point(120, 131);
            this.lblerror3.Name = "lblerror3";
            this.lblerror3.Size = new System.Drawing.Size(0, 13);
            this.lblerror3.TabIndex = 44;
            // 
            // txtpass
            // 
            this.txtpass.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtpass.Location = new System.Drawing.Point(120, 108);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 43;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(53, 109);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(67, 15);
            this.lblpass.TabIndex = 42;
            this.lblpass.Text = "Password: ";
            // 
            // lblerror2
            // 
            this.lblerror2.AutoSize = true;
            this.lblerror2.ForeColor = System.Drawing.Color.Red;
            this.lblerror2.Location = new System.Drawing.Point(120, 87);
            this.lblerror2.Name = "lblerror2";
            this.lblerror2.Size = new System.Drawing.Size(0, 13);
            this.lblerror2.TabIndex = 41;
            // 
            // txtname
            // 
            this.txtname.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtname.Location = new System.Drawing.Point(123, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 40;
            // 
            // txtstaff
            // 
            this.txtstaff.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtstaff.Location = new System.Drawing.Point(123, 21);
            this.txtstaff.Name = "txtstaff";
            this.txtstaff.Size = new System.Drawing.Size(100, 20);
            this.txtstaff.TabIndex = 39;
            // 
            // lblerror1
            // 
            this.lblerror1.AutoSize = true;
            this.lblerror1.ForeColor = System.Drawing.Color.Red;
            this.lblerror1.Location = new System.Drawing.Point(120, 44);
            this.lblerror1.Name = "lblerror1";
            this.lblerror1.Size = new System.Drawing.Size(0, 13);
            this.lblerror1.TabIndex = 38;
            this.lblerror1.Visible = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(73, 64);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 15);
            this.lblname.TabIndex = 37;
            this.lblname.Text = "Name:";
            // 
            // lblstaff
            // 
            this.lblstaff.AutoSize = true;
            this.lblstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaff.Location = new System.Drawing.Point(53, 26);
            this.lblstaff.Name = "lblstaff";
            this.lblstaff.Size = new System.Drawing.Size(64, 15);
            this.lblstaff.TabIndex = 36;
            this.lblstaff.Text = "Staff code:";
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
            this.btnSave.Location = new System.Drawing.Point(120, 190);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 33);
            this.btnSave.TabIndex = 48;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // role_userTableAdapter
            // 
            this.role_userTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(159, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 49;
            // 
            // Form_Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblerror4);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblerror3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblerror2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtstaff);
            this.Controls.Add(this.lblerror1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblstaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Add_User";
            this.Text = "Add User Systems";
            this.Load += new System.EventHandler(this.Form_Add_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOM_DMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblerror4;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblerror3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtpass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblpass;
        private System.Windows.Forms.Label lblerror2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtname;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtstaff;
        private System.Windows.Forms.Label lblerror1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblname;
        private Bunifu.Framework.UI.BunifuCustomLabel lblstaff;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private BOM_DMDataSet bOM_DMDataSet;
        private System.Windows.Forms.BindingSource roleuserBindingSource;
        private BOM_DMDataSetTableAdapters.Role_userTableAdapter role_userTableAdapter;
        private System.Windows.Forms.Label label5;
    }
}