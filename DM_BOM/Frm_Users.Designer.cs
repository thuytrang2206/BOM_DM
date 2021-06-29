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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_users)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_users
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_users.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.groupBox1.Location = new System.Drawing.Point(353, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgv_users;
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
    }
}