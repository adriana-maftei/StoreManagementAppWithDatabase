namespace MusicShop
{
    partial class Instruments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CatTb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BrandTb = new System.Windows.Forms.ComboBox();
            this.btn_add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.InstrumentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BrandSearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.btn_update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstrumentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Crimson;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1082, 59);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MusicShop.Properties.Resources.violin;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventory Management";
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.Location = new System.Drawing.Point(16, 119);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(248, 27);
            this.NameTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Instrument name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.Location = new System.Drawing.Point(280, 119);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(95, 27);
            this.QtyTb.TabIndex = 7;
            // 
            // PriceTb
            // 
            this.PriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.Location = new System.Drawing.Point(280, 177);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(95, 27);
            this.PriceTb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price ($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category";
            // 
            // CatTb
            // 
            this.CatTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatTb.FormattingEnabled = true;
            this.CatTb.Items.AddRange(new object[] {
            "Keyboard",
            "Wind",
            "Strings",
            "Percussions"});
            this.CatTb.Location = new System.Drawing.Point(16, 176);
            this.CatTb.Name = "CatTb";
            this.CatTb.Size = new System.Drawing.Size(248, 28);
            this.CatTb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Brand";
            // 
            // BrandTb
            // 
            this.BrandTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandTb.FormattingEnabled = true;
            this.BrandTb.Items.AddRange(new object[] {
            "Yamaha",
            "Casio",
            "Celio",
            "Mehiwe",
            "Roland",
            "KeyOrg"});
            this.BrandTb.Location = new System.Drawing.Point(16, 234);
            this.BrandTb.Name = "BrandTb";
            this.BrandTb.Size = new System.Drawing.Size(248, 28);
            this.BrandTb.TabIndex = 13;
            // 
            // btn_add
            // 
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Crimson;
            this.btn_add.FillColor2 = System.Drawing.Color.Purple;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(16, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 39);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.Color.Crimson;
            this.btn_edit.FillColor2 = System.Drawing.Color.Purple;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(137, 280);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(115, 39);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.Crimson;
            this.btn_delete.FillColor2 = System.Drawing.Color.Purple;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(260, 280);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 39);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // InstrumentDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.InstrumentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InstrumentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.InstrumentDGV.ColumnHeadersHeight = 25;
            this.InstrumentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InstrumentDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.InstrumentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InstrumentDGV.Location = new System.Drawing.Point(408, 146);
            this.InstrumentDGV.Name = "InstrumentDGV";
            this.InstrumentDGV.RowHeadersVisible = false;
            this.InstrumentDGV.RowHeadersWidth = 51;
            this.InstrumentDGV.RowTemplate.Height = 24;
            this.InstrumentDGV.Size = new System.Drawing.Size(662, 320);
            this.InstrumentDGV.TabIndex = 17;
            this.InstrumentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.InstrumentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.InstrumentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.InstrumentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.InstrumentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.InstrumentDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.InstrumentDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InstrumentDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Purple;
            this.InstrumentDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.InstrumentDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstrumentDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.InstrumentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.InstrumentDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.InstrumentDGV.ThemeStyle.ReadOnly = false;
            this.InstrumentDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.InstrumentDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.InstrumentDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstrumentDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.InstrumentDGV.ThemeStyle.RowsStyle.Height = 24;
            this.InstrumentDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InstrumentDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.InstrumentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstrumentDGV_CellContentClick);
            // 
            // BrandSearch
            // 
            this.BrandSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandSearch.FormattingEnabled = true;
            this.BrandSearch.Items.AddRange(new object[] {
            "Yamaha",
            "Casio",
            "Celio",
            "Mehiwe",
            "Roland",
            "KeyOrg"});
            this.BrandSearch.Location = new System.Drawing.Point(408, 96);
            this.BrandSearch.Name = "BrandSearch";
            this.BrandSearch.Size = new System.Drawing.Size(541, 28);
            this.BrandSearch.TabIndex = 19;
            this.BrandSearch.SelectionChangeCommitted += new System.EventHandler(this.BrandSearch_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Search by brand...";
            // 
            // btn_refresh
            // 
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.FillColor = System.Drawing.Color.Crimson;
            this.btn_refresh.FillColor2 = System.Drawing.Color.Purple;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(955, 85);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(115, 39);
            this.btn_refresh.TabIndex = 20;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_back
            // 
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.Crimson;
            this.btn_back.FillColor2 = System.Drawing.Color.Purple;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(137, 334);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 39);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "New password";
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.Location = new System.Drawing.Point(16, 439);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(236, 27);
            this.newPass.TabIndex = 23;
            // 
            // btn_update
            // 
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.Crimson;
            this.btn_update.FillColor2 = System.Drawing.Color.Purple;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(260, 427);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 39);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Instruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 497);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.BrandSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InstrumentDGV);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.BrandTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CatTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Instruments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items management";
            this.Load += new System.EventHandler(this.Instruments_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstrumentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CatTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BrandTb;
        private Guna.UI2.WinForms.Guna2GradientButton btn_add;
        private Guna.UI2.WinForms.Guna2GradientButton btn_edit;
        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private Guna.UI2.WinForms.Guna2DataGridView InstrumentDGV;
        private System.Windows.Forms.ComboBox BrandSearch;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton btn_refresh;
        private Guna.UI2.WinForms.Guna2GradientButton btn_back;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newPass;
        private Guna.UI2.WinForms.Guna2GradientButton btn_update;
    }
}