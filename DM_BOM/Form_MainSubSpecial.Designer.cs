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
            this.PartNoBom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubBom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblerrorpartlist = new System.Windows.Forms.Label();
            this.txtSubbom = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtPartlistName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.labelmain = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblpart = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_Searchs = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.PartNoBom,
            this.SubBom});
            this.dtgv_Mainsubspecial.Location = new System.Drawing.Point(40, 37);
            this.dtgv_Mainsubspecial.Name = "dtgv_Mainsubspecial";
            this.dtgv_Mainsubspecial.RowHeadersVisible = false;
            this.dtgv_Mainsubspecial.Size = new System.Drawing.Size(370, 420);
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
            // PartNoBom
            // 
            this.PartNoBom.DataPropertyName = "PartNoBom";
            this.PartNoBom.HeaderText = "PartNoBom";
            this.PartNoBom.Name = "PartNoBom";
            this.PartNoBom.Width = 150;
            // 
            // SubBom
            // 
            this.SubBom.DataPropertyName = "SubBom";
            this.SubBom.HeaderText = "SubBom";
            this.SubBom.Name = "SubBom";
            this.SubBom.Width = 150;
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
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblerrorpartlist);
            this.groupBox1.Controls.Add(this.txtSubbom);
            this.groupBox1.Controls.Add(this.txtPartlistName);
            this.groupBox1.Controls.Add(this.labelmain);
            this.groupBox1.Controls.Add(this.lblpart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 138);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtId.Location = new System.Drawing.Point(105, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(103, 20);
            this.txtId.TabIndex = 23;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(17, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 15);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "ID:";
            // 
            // lblerrorpartlist
            // 
            this.lblerrorpartlist.AutoSize = true;
            this.lblerrorpartlist.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpartlist.Location = new System.Drawing.Point(103, 80);
            this.lblerrorpartlist.Name = "lblerrorpartlist";
            this.lblerrorpartlist.Size = new System.Drawing.Size(0, 13);
            this.lblerrorpartlist.TabIndex = 21;
            // 
            // txtSubbom
            // 
            this.txtSubbom.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSubbom.Location = new System.Drawing.Point(105, 95);
            this.txtSubbom.Name = "txtSubbom";
            this.txtSubbom.Size = new System.Drawing.Size(106, 20);
            this.txtSubbom.TabIndex = 20;
            // 
            // txtPartlistName
            // 
            this.txtPartlistName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPartlistName.Location = new System.Drawing.Point(105, 57);
            this.txtPartlistName.Name = "txtPartlistName";
            this.txtPartlistName.Size = new System.Drawing.Size(103, 20);
            this.txtPartlistName.TabIndex = 19;
            // 
            // labelmain
            // 
            this.labelmain.AutoSize = true;
            this.labelmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmain.Location = new System.Drawing.Point(7, 100);
            this.labelmain.Name = "labelmain";
            this.labelmain.Size = new System.Drawing.Size(100, 15);
            this.labelmain.TabIndex = 18;
            this.labelmain.Text = "Main_sub name:";
            // 
            // lblpart
            // 
            this.lblpart.AutoSize = true;
            this.lblpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpart.Location = new System.Drawing.Point(17, 62);
            this.lblpart.Name = "lblpart";
            this.lblpart.Size = new System.Drawing.Size(82, 15);
            this.lblpart.TabIndex = 17;
            this.lblpart.Text = "Partlist name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Searchs);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(416, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.Location = new System.Drawing.Point(11, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btn_Searchs
            // 
            this.btn_Searchs.BackColor = System.Drawing.Color.White;
            this.btn_Searchs.Image = ((System.Drawing.Image)(resources.GetObject("btn_Searchs.Image")));
            this.btn_Searchs.ImageActive = null;
            this.btn_Searchs.Location = new System.Drawing.Point(181, 15);
            this.btn_Searchs.Name = "btn_Searchs";
            this.btn_Searchs.Size = new System.Drawing.Size(25, 24);
            this.btn_Searchs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Searchs.TabIndex = 3;
            this.btn_Searchs.TabStop = false;
            this.btn_Searchs.Zoom = 10;
            this.btn_Searchs.Click += new System.EventHandler(this.btn_Searchs_Click);
            // 
            // Form_MainSubSpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_Mainsubspecial);
            this.Name = "Form_MainSubSpecial";
            this.Text = "Form_MainSubSpecial";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNoBom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubBom;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        public System.Windows.Forms.DataGridView dtgv_Mainsubspecial;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtId;
        private Bunifu.Framework.UI.BunifuCustomLabel lblId;
        private System.Windows.Forms.Label lblerrorpartlist;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSubbom;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPartlistName;
        private Bunifu.Framework.UI.BunifuCustomLabel labelmain;
        private Bunifu.Framework.UI.BunifuCustomLabel lblpart;
        private System.Windows.Forms.GroupBox groupBox2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuImageButton btn_Searchs;
    }
}