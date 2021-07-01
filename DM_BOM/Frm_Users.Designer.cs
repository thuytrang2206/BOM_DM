namespace DM_BOM
{
    partial class Frm_Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Users));
            this.dtgv_users = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_roles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.roleuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOM_DMDataSet1 = new DM_BOM.BOM_DMDataSet1();
            this.txtpass = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtname = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtstaff = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblerrorpartlist = new System.Windows.Forms.Label();
            this.labelmain = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblpart = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.role_userTableAdapter = new DM_BOM.BOM_DMDataSet1TableAdapters.Role_userTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Searchs = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_users)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOM_DMDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Searchs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_users
            // 
            this.dtgv_users.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_users.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.id,
            this.Staff_code,
            this._Name,
            this.Password,
            this.Id_roles,
            this.Role_name});
            this.dtgv_users.DoubleBuffered = true;
            this.dtgv_users.EnableHeadersVisualStyles = false;
            this.dtgv_users.HeaderBgColor = System.Drawing.Color.White;
            this.dtgv_users.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dtgv_users.Location = new System.Drawing.Point(7, 34);
            this.dtgv_users.Name = "dtgv_users";
            this.dtgv_users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_users.RowHeadersVisible = false;
            this.dtgv_users.Size = new System.Drawing.Size(340, 255);
            this.dtgv_users.TabIndex = 0;
            this.dtgv_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_users_CellClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_user";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // Staff_code
            // 
            this.Staff_code.DataPropertyName = "Staff_code";
            this.Staff_code.HeaderText = "Staff_code";
            this.Staff_code.Name = "Staff_code";
            // 
            // _Name
            // 
            this._Name.DataPropertyName = "Name";
            this._Name.HeaderText = "Name";
            this._Name.Name = "_Name";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Id_roles
            // 
            this.Id_roles.DataPropertyName = "Id_role";
            this.Id_roles.HeaderText = "Id_role";
            this.Id_roles.Name = "Id_roles";
            this.Id_roles.Width = 88;
            // 
            // Role_name
            // 
            this.Role_name.HeaderText = "Role_name";
            this.Role_name.Name = "Role_name";
            this.Role_name.Width = 88;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 28);
            this.panel1.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(584, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 24);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageActive = null;
            this.btnDel.Location = new System.Drawing.Point(615, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(30, 27);
            this.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDel.TabIndex = 1;
            this.btnDel.TabStop = false;
            this.btnDel.Zoom = 10;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(546, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 27);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbrole);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtstaff);
            this.groupBox1.Controls.Add(this.lblerrorpartlist);
            this.groupBox1.Controls.Add(this.labelmain);
            this.groupBox1.Controls.Add(this.lblpart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(353, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // cmbrole
            // 
            this.cmbrole.DataSource = this.roleuserBindingSource;
            this.cmbrole.DisplayMember = "Name";
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(135, 141);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(121, 21);
            this.cmbrole.TabIndex = 39;
            this.cmbrole.ValueMember = "Id_Role";
            // 
            // roleuserBindingSource
            // 
            this.roleuserBindingSource.DataMember = "Role_user";
            this.roleuserBindingSource.DataSource = this.bOM_DMDataSet1;
            // 
            // bOM_DMDataSet1
            // 
            this.bOM_DMDataSet1.DataSetName = "BOM_DMDataSet1";
            this.bOM_DMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtpass
            // 
            this.txtpass.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtpass.Location = new System.Drawing.Point(136, 101);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 37;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(118, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 36;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 142);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 15);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "Role_user";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(34, 102);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(61, 15);
            this.bunifuCustomLabel2.TabIndex = 34;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // txtname
            // 
            this.txtname.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtname.Location = new System.Drawing.Point(136, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 33;
            // 
            // txtstaff
            // 
            this.txtstaff.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtstaff.Location = new System.Drawing.Point(136, 25);
            this.txtstaff.Name = "txtstaff";
            this.txtstaff.Size = new System.Drawing.Size(100, 20);
            this.txtstaff.TabIndex = 32;
            // 
            // lblerrorpartlist
            // 
            this.lblerrorpartlist.AutoSize = true;
            this.lblerrorpartlist.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpartlist.Location = new System.Drawing.Point(118, 44);
            this.lblerrorpartlist.Name = "lblerrorpartlist";
            this.lblerrorpartlist.Size = new System.Drawing.Size(0, 13);
            this.lblerrorpartlist.TabIndex = 31;
            // 
            // labelmain
            // 
            this.labelmain.AutoSize = true;
            this.labelmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmain.Location = new System.Drawing.Point(61, 62);
            this.labelmain.Name = "labelmain";
            this.labelmain.Size = new System.Drawing.Size(41, 15);
            this.labelmain.TabIndex = 30;
            this.labelmain.Text = "Name";
            // 
            // lblpart
            // 
            this.lblpart.AutoSize = true;
            this.lblpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpart.Location = new System.Drawing.Point(34, 26);
            this.lblpart.Name = "lblpart";
            this.lblpart.Size = new System.Drawing.Size(68, 15);
            this.lblpart.TabIndex = 29;
            this.lblpart.Text = "Staff_code:";
            // 
            // role_userTableAdapter
            // 
            this.role_userTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Searchs);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(353, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 53);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btn_Searchs
            // 
            this.btn_Searchs.BackColor = System.Drawing.Color.White;
            this.btn_Searchs.Image = ((System.Drawing.Image)(resources.GetObject("btn_Searchs.Image")));
            this.btn_Searchs.ImageActive = null;
            this.btn_Searchs.Location = new System.Drawing.Point(255, 15);
            this.btn_Searchs.Name = "btn_Searchs";
            this.btn_Searchs.Size = new System.Drawing.Size(25, 24);
            this.btn_Searchs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Searchs.TabIndex = 3;
            this.btn_Searchs.TabStop = false;
            this.btn_Searchs.Zoom = 10;
            this.btn_Searchs.Click += new System.EventHandler(this.btn_Searchs_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.Location = new System.Drawing.Point(11, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_users);
            this.Name = "Frm_Users";
            this.Text = "Users system";
            this.Load += new System.EventHandler(this.Frm_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_users)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOM_DMDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Searchs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnDel;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_roles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_name;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dtgv_users;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtpass;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtname;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtstaff;
        private System.Windows.Forms.Label lblerrorpartlist;
        private Bunifu.Framework.UI.BunifuCustomLabel labelmain;
        private Bunifu.Framework.UI.BunifuCustomLabel lblpart;
        private System.Windows.Forms.ComboBox cmbrole;
        private BOM_DMDataSet1 bOM_DMDataSet1;
        private System.Windows.Forms.BindingSource roleuserBindingSource;
        private BOM_DMDataSet1TableAdapters.Role_userTableAdapter role_userTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuImageButton btn_Searchs;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSearch;
    }
}