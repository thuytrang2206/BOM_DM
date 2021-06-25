namespace DM_BOM
{
    partial class Form_MainSubSpecial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainSubSpecial));
            this.dtgv_Mainsubspecial = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partonbomcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subspecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lblId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblerrorpartlist = new System.Windows.Forms.Label();
            this.labelmain = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblpart = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Searchs = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtpartbomcus = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtsubspecial = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Mainsubspecial)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Searchs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Mainsubspecial
            // 
            this.dtgv_Mainsubspecial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Mainsubspecial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.No,
            this.Partonbomcustomer,
            this.Subspecial});
            this.dtgv_Mainsubspecial.Location = new System.Drawing.Point(12, 34);
            this.dtgv_Mainsubspecial.Name = "dtgv_Mainsubspecial";
            this.dtgv_Mainsubspecial.RowHeadersVisible = false;
            this.dtgv_Mainsubspecial.Size = new System.Drawing.Size(370, 252);
            this.dtgv_Mainsubspecial.TabIndex = 0;
            this.dtgv_Mainsubspecial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Mainsubspecial_CellClick);
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
            this.Partonbomcustomer.DataPropertyName = "PartNoBom";
            this.Partonbomcustomer.HeaderText = "Part on bom customer";
            this.Partonbomcustomer.Name = "Partonbomcustomer";
            this.Partonbomcustomer.Width = 150;
            // 
            // Subspecial
            // 
            this.Subspecial.DataPropertyName = "SubBom";
            this.Subspecial.HeaderText = "Sub special";
            this.Subspecial.Name = "Subspecial";
            this.Subspecial.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 28);
            this.panel1.TabIndex = 2;
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
            this.groupBox1.Controls.Add(this.txtsubspecial);
            this.groupBox1.Controls.Add(this.txtpartbomcus);
            this.groupBox1.Controls.Add(this.lbl_Id);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblerrorpartlist);
            this.groupBox1.Controls.Add(this.labelmain);
            this.groupBox1.Controls.Add(this.lblpart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(388, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 194);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Enabled = false;
            this.lbl_Id.Location = new System.Drawing.Point(149, 106);
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
            this.lblId.Location = new System.Drawing.Point(121, 106);
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
            this.lblerrorpartlist.Location = new System.Drawing.Point(118, 50);
            this.lblerrorpartlist.Name = "lblerrorpartlist";
            this.lblerrorpartlist.Size = new System.Drawing.Size(0, 13);
            this.lblerrorpartlist.TabIndex = 21;
            // 
            // labelmain
            // 
            this.labelmain.AutoSize = true;
            this.labelmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmain.Location = new System.Drawing.Point(61, 68);
            this.labelmain.Name = "labelmain";
            this.labelmain.Size = new System.Drawing.Size(74, 15);
            this.labelmain.TabIndex = 18;
            this.labelmain.Text = "Sub special:";
            // 
            // lblpart
            // 
            this.lblpart.AutoSize = true;
            this.lblpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpart.Location = new System.Drawing.Point(6, 32);
            this.lblpart.Name = "lblpart";
            this.lblpart.Size = new System.Drawing.Size(131, 15);
            this.lblpart.TabIndex = 17;
            this.lblpart.Text = "Part on bom customer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Searchs);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(388, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btn_Searchs
            // 
            this.btn_Searchs.BackColor = System.Drawing.Color.White;
            this.btn_Searchs.Image = ((System.Drawing.Image)(resources.GetObject("btn_Searchs.Image")));
            this.btn_Searchs.ImageActive = null;
            this.btn_Searchs.Location = new System.Drawing.Point(211, 15);
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
            this.txtSearch.Size = new System.Drawing.Size(194, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtpartbomcus
            // 
            this.txtpartbomcus.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtpartbomcus.Location = new System.Drawing.Point(136, 31);
            this.txtpartbomcus.Name = "txtpartbomcus";
            this.txtpartbomcus.Size = new System.Drawing.Size(100, 20);
            this.txtpartbomcus.TabIndex = 27;
            // 
            // txtsubspecial
            // 
            this.txtsubspecial.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtsubspecial.Location = new System.Drawing.Point(136, 67);
            this.txtsubspecial.Name = "txtsubspecial";
            this.txtsubspecial.Size = new System.Drawing.Size(100, 20);
            this.txtsubspecial.TabIndex = 28;
            // 
            // Form_MainSubSpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_Mainsubspecial);
            this.Name = "Form_MainSubSpecial";
            this.Text = "Main_Sub_Special";
            this.Load += new System.EventHandler(this.Form_MainSubSpecial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Mainsubspecial)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Searchs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        public System.Windows.Forms.DataGridView dtgv_Mainsubspecial;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblId;
        private System.Windows.Forms.Label lblerrorpartlist;
        private Bunifu.Framework.UI.BunifuCustomLabel labelmain;
        private Bunifu.Framework.UI.BunifuCustomLabel lblpart;
        private System.Windows.Forms.GroupBox groupBox2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuImageButton btn_Searchs;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partonbomcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subspecial;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtsubspecial;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtpartbomcus;
    }
}