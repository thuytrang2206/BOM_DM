namespace DM_BOM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblConfigs = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ECS = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_BOM = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CboSheet = new System.Windows.Forms.ComboBox();
            this.cbosheettwo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridview_BOM = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.datagridview_ECS = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.datagridview_Result = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnStart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_BOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_ECS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lblConfigs);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 57);
            this.panel1.TabIndex = 0;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.ForeColor = System.Drawing.Color.Gray;
            this.lbltime.Location = new System.Drawing.Point(88, 37);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(82, 13);
            this.lbltime.TabIndex = 105;
            this.lbltime.Text = "CLINT (ADMIN)";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Enabled = false;
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.Location = new System.Drawing.Point(1192, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(30, 30);
            this.linkLabel2.TabIndex = 104;
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.Location = new System.Drawing.Point(1156, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 30);
            this.linkLabel1.TabIndex = 103;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // lblConfigs
            // 
            this.lblConfigs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfigs.Image = ((System.Drawing.Image)(resources.GetObject("lblConfigs.Image")));
            this.lblConfigs.Location = new System.Drawing.Point(1228, 8);
            this.lblConfigs.Name = "lblConfigs";
            this.lblConfigs.Size = new System.Drawing.Size(30, 30);
            this.lblConfigs.TabIndex = 102;
            this.lblConfigs.Click += new System.EventHandler(this.lblConfigs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 54);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 28);
            this.panel2.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(270, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ECS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ECS);
            this.groupBox1.Controls.Add(this.btn_BOM);
            this.groupBox1.Controls.Add(this.CboSheet);
            this.groupBox1.Controls.Add(this.cbosheettwo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(639, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 118);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // btn_ECS
            // 
            this.btn_ECS.ActiveBorderThickness = 1;
            this.btn_ECS.ActiveCornerRadius = 20;
            this.btn_ECS.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_ECS.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ECS.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ECS.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ECS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ECS.BackgroundImage")));
            this.btn_ECS.ButtonText = "Choose File";
            this.btn_ECS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ECS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ECS.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_ECS.IdleBorderThickness = 1;
            this.btn_ECS.IdleCornerRadius = 20;
            this.btn_ECS.IdleFillColor = System.Drawing.Color.White;
            this.btn_ECS.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_ECS.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ECS.Location = new System.Drawing.Point(465, 60);
            this.btn_ECS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ECS.Name = "btn_ECS";
            this.btn_ECS.Size = new System.Drawing.Size(80, 40);
            this.btn_ECS.TabIndex = 96;
            this.btn_ECS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ECS.Click += new System.EventHandler(this.btn_ECS_Click);
            // 
            // btn_BOM
            // 
            this.btn_BOM.ActiveBorderThickness = 1;
            this.btn_BOM.ActiveCornerRadius = 20;
            this.btn_BOM.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_BOM.ActiveForecolor = System.Drawing.Color.White;
            this.btn_BOM.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_BOM.BackColor = System.Drawing.SystemColors.Control;
            this.btn_BOM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BOM.BackgroundImage")));
            this.btn_BOM.ButtonText = "Choose File";
            this.btn_BOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BOM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BOM.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_BOM.IdleBorderThickness = 1;
            this.btn_BOM.IdleCornerRadius = 20;
            this.btn_BOM.IdleFillColor = System.Drawing.Color.White;
            this.btn_BOM.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_BOM.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_BOM.Location = new System.Drawing.Point(465, 12);
            this.btn_BOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BOM.Name = "btn_BOM";
            this.btn_BOM.Size = new System.Drawing.Size(80, 40);
            this.btn_BOM.TabIndex = 95;
            this.btn_BOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BOM.Click += new System.EventHandler(this.btn_BOM_Click);
            // 
            // CboSheet
            // 
            this.CboSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSheet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboSheet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CboSheet.FormattingEnabled = true;
            this.CboSheet.Location = new System.Drawing.Point(89, 19);
            this.CboSheet.Name = "CboSheet";
            this.CboSheet.Size = new System.Drawing.Size(356, 28);
            this.CboSheet.TabIndex = 91;
            this.CboSheet.SelectedIndexChanged += new System.EventHandler(this.CboSheet_SelectedIndexChanged);
            // 
            // cbosheettwo
            // 
            this.cbosheettwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosheettwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosheettwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbosheettwo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbosheettwo.FormattingEnabled = true;
            this.cbosheettwo.Location = new System.Drawing.Point(89, 70);
            this.cbosheettwo.Name = "cbosheettwo";
            this.cbosheettwo.Size = new System.Drawing.Size(356, 28);
            this.cbosheettwo.TabIndex = 92;
            this.cbosheettwo.SelectedIndexChanged += new System.EventHandler(this.cbosheettwo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 96;
            this.label3.Text = "BOM";
            // 
            // datagridview_BOM
            // 
            this.datagridview_BOM.AllowUserToAddRows = false;
            this.datagridview_BOM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_BOM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_BOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_BOM.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridview_BOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_BOM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_BOM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_BOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_BOM.DoubleBuffered = true;
            this.datagridview_BOM.EnableHeadersVisualStyles = false;
            this.datagridview_BOM.HeaderBgColor = System.Drawing.Color.White;
            this.datagridview_BOM.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.datagridview_BOM.Location = new System.Drawing.Point(5, 386);
            this.datagridview_BOM.Name = "datagridview_BOM";
            this.datagridview_BOM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_BOM.RowHeadersVisible = false;
            this.datagridview_BOM.Size = new System.Drawing.Size(627, 470);
            this.datagridview_BOM.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "ECS";
            // 
            // datagridview_ECS
            // 
            this.datagridview_ECS.AllowUserToAddRows = false;
            this.datagridview_ECS.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_ECS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_ECS.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridview_ECS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_ECS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_ECS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_ECS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_ECS.DoubleBuffered = true;
            this.datagridview_ECS.EnableHeadersVisualStyles = false;
            this.datagridview_ECS.HeaderBgColor = System.Drawing.Color.White;
            this.datagridview_ECS.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.datagridview_ECS.Location = new System.Drawing.Point(639, 386);
            this.datagridview_ECS.Name = "datagridview_ECS";
            this.datagridview_ECS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_ECS.RowHeadersVisible = false;
            this.datagridview_ECS.Size = new System.Drawing.Size(620, 470);
            this.datagridview_ECS.TabIndex = 99;
            // 
            // datagridview_Result
            // 
            this.datagridview_Result.AllowUserToAddRows = false;
            this.datagridview_Result.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_Result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview_Result.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridview_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_Result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridview_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_Result.DoubleBuffered = true;
            this.datagridview_Result.EnableHeadersVisualStyles = false;
            this.datagridview_Result.HeaderBgColor = System.Drawing.Color.White;
            this.datagridview_Result.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.datagridview_Result.Location = new System.Drawing.Point(5, 92);
            this.datagridview_Result.Name = "datagridview_Result";
            this.datagridview_Result.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_Result.RowHeadersVisible = false;
            this.datagridview_Result.Size = new System.Drawing.Size(627, 272);
            this.datagridview_Result.TabIndex = 100;
            // 
            // btnStart
            // 
            this.btnStart.ActiveBorderThickness = 1;
            this.btnStart.ActiveCornerRadius = 20;
            this.btnStart.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnStart.ActiveForecolor = System.Drawing.Color.White;
            this.btnStart.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.ButtonText = "Start";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStart.IdleBorderThickness = 1;
            this.btnStart.IdleCornerRadius = 20;
            this.btnStart.IdleFillColor = System.Drawing.Color.Red;
            this.btnStart.IdleForecolor = System.Drawing.Color.White;
            this.btnStart.IdleLineColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(915, 218);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 47);
            this.btnStart.TabIndex = 101;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(721, 66);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch1.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch1.TabIndex = 103;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = true;
            this.bunifuSwitch1.Click += new System.EventHandler(this.bunifuSwitch1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "PartNoBom";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 824);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuSwitch1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.datagridview_Result);
            this.Controls.Add(this.datagridview_ECS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datagridview_BOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_BOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_ECS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblConfigs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboSheet;
        private System.Windows.Forms.ComboBox cbosheettwo;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_BOM;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ECS;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridview_BOM;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridview_ECS;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridview_Result;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private System.Windows.Forms.Label label7;
    }
}

