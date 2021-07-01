namespace DM_BOM
{
    partial class Form_ICManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ICManager));
            this.txtSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Searchs = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lblId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblerrorpartlist = new System.Windows.Forms.Label();
            this.lblpart = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbomcustomer = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.labelmain = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtbomsap = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.dtgv_Flashmemory = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partonbomcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partonbomsap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Searchs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Flashmemory)).BeginInit();
            this.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Searchs);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(513, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 53);
            this.groupBox2.TabIndex = 22;
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
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Enabled = false;
            this.lbl_Id.Location = new System.Drawing.Point(164, 98);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(41, 13);
            this.lbl_Id.TabIndex = 24;
            this.lbl_Id.Text = "label1";
            this.lbl_Id.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Enabled = false;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(136, 98);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 15);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "ID:";
            this.lblId.Visible = false;
            // 
            // lblerrorpartlist
            // 
            this.lblerrorpartlist.AutoSize = true;
            this.lblerrorpartlist.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpartlist.Location = new System.Drawing.Point(116, 49);
            this.lblerrorpartlist.Name = "lblerrorpartlist";
            this.lblerrorpartlist.Size = new System.Drawing.Size(0, 13);
            this.lblerrorpartlist.TabIndex = 21;
            // 
            // lblpart
            // 
            this.lblpart.AutoSize = true;
            this.lblpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpart.Location = new System.Drawing.Point(54, 71);
            this.lblpart.Name = "lblpart";
            this.lblpart.Size = new System.Drawing.Size(106, 15);
            this.lblpart.TabIndex = 17;
            this.lblpart.Text = "Part on BOM SAP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbomcustomer);
            this.groupBox1.Controls.Add(this.labelmain);
            this.groupBox1.Controls.Add(this.txtbomsap);
            this.groupBox1.Controls.Add(this.lbl_Id);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblerrorpartlist);
            this.groupBox1.Controls.Add(this.lblpart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(513, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 194);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // txtbomcustomer
            // 
            this.txtbomcustomer.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtbomcustomer.Location = new System.Drawing.Point(166, 34);
            this.txtbomcustomer.Name = "txtbomcustomer";
            this.txtbomcustomer.Size = new System.Drawing.Size(100, 20);
            this.txtbomcustomer.TabIndex = 28;
            // 
            // labelmain
            // 
            this.labelmain.AutoSize = true;
            this.labelmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmain.Location = new System.Drawing.Point(52, 34);
            this.labelmain.Name = "labelmain";
            this.labelmain.Size = new System.Drawing.Size(108, 15);
            this.labelmain.TabIndex = 27;
            this.labelmain.Text = "Part on PARTLIST:";
            // 
            // txtbomsap
            // 
            this.txtbomsap.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtbomsap.Location = new System.Drawing.Point(166, 66);
            this.txtbomsap.Name = "txtbomsap";
            this.txtbomsap.Size = new System.Drawing.Size(100, 20);
            this.txtbomsap.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 28);
            this.panel1.TabIndex = 20;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(736, 3);
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
            this.btnDel.Location = new System.Drawing.Point(767, 0);
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
            this.btnAdd.Location = new System.Drawing.Point(698, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 27);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgv_Flashmemory
            // 
            this.dtgv_Flashmemory.AllowUserToAddRows = false;
            this.dtgv_Flashmemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Flashmemory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.No,
            this.Partonbomcustomer,
            this.Partonbomsap,
            this.Id_users,
            this.Name_user});
            this.dtgv_Flashmemory.Location = new System.Drawing.Point(1, 37);
            this.dtgv_Flashmemory.Name = "dtgv_Flashmemory";
            this.dtgv_Flashmemory.RowHeadersVisible = false;
            this.dtgv_Flashmemory.Size = new System.Drawing.Size(494, 252);
            this.dtgv_Flashmemory.TabIndex = 19;
            this.dtgv_Flashmemory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Flashmemory_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 50;
            // 
            // Partonbomcustomer
            // 
            this.Partonbomcustomer.DataPropertyName = "PartNoCUS";
            this.Partonbomcustomer.HeaderText = "Part on PARTLIST";
            this.Partonbomcustomer.Name = "Partonbomcustomer";
            this.Partonbomcustomer.Width = 150;
            // 
            // Partonbomsap
            // 
            this.Partonbomsap.DataPropertyName = "PartNoBOM";
            this.Partonbomsap.HeaderText = "Part on BOM SAP";
            this.Partonbomsap.Name = "Partonbomsap";
            this.Partonbomsap.Width = 150;
            // 
            // Id_users
            // 
            this.Id_users.DataPropertyName = "Id_user";
            this.Id_users.HeaderText = "Id_user";
            this.Id_users.Name = "Id_users";
            // 
            // Name_user
            // 
            this.Name_user.HeaderText = "Name_user";
            this.Name_user.Name = "Name_user";
            this.Name_user.Width = 124;
            // 
            // Form_ICManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_Flashmemory);
            this.Name = "Form_ICManager";
            this.Text = "IC Manager";
            this.Load += new System.EventHandler(this.Form_ICManager_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Searchs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Flashmemory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_Searchs;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Id;
        private Bunifu.Framework.UI.BunifuCustomLabel lblId;
        private System.Windows.Forms.Label lblerrorpartlist;
        private Bunifu.Framework.UI.BunifuCustomLabel lblpart;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnDel;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dtgv_Flashmemory;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtbomcustomer;
        private Bunifu.Framework.UI.BunifuCustomLabel labelmain;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtbomsap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partonbomcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partonbomsap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_user;
    }
}