namespace SMS
{
    partial class frmPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvTTGD = new System.Windows.Forms.DataGridView();
            this.btnDong = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLamMoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenGV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenMon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenLop = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.groupBox4.Controls.Add(this.dgvTTGD);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(16, 326);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1128, 244);
            this.groupBox4.TabIndex = 165;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dgvTTGD
            // 
            this.dgvTTGD.AllowUserToAddRows = false;
            this.dgvTTGD.AllowUserToDeleteRows = false;
            this.dgvTTGD.AllowUserToResizeRows = false;
            this.dgvTTGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTGD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTTGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTGD.Location = new System.Drawing.Point(3, 21);
            this.dgvTTGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTTGD.Name = "dgvTTGD";
            this.dgvTTGD.RowHeadersVisible = false;
            this.dgvTTGD.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTTGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTGD.Size = new System.Drawing.Size(1122, 221);
            this.dgvTTGD.TabIndex = 132;
            this.dgvTTGD.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageActive = null;
            this.btnDong.Location = new System.Drawing.Point(1109, 16);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(42, 34);
            this.btnDong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDong.TabIndex = 157;
            this.btnDong.TabStop = false;
            this.btnDong.Zoom = 10;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Active = false;
            this.btnLamMoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLamMoi.BorderRadius = 7;
            this.btnLamMoi.ButtonText = "Làm mới";
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.DisabledColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Iconimage")));
            this.btnLamMoi.Iconimage_right = null;
            this.btnLamMoi.Iconimage_right_Selected = null;
            this.btnLamMoi.Iconimage_Selected = null;
            this.btnLamMoi.IconMarginLeft = 0;
            this.btnLamMoi.IconMarginRight = 0;
            this.btnLamMoi.IconRightVisible = true;
            this.btnLamMoi.IconRightZoom = 0D;
            this.btnLamMoi.IconVisible = true;
            this.btnLamMoi.IconZoom = 70D;
            this.btnLamMoi.IsTab = false;
            this.btnLamMoi.Location = new System.Drawing.Point(990, 190);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLamMoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnLamMoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLamMoi.selected = false;
            this.btnLamMoi.Size = new System.Drawing.Size(151, 45);
            this.btnLamMoi.TabIndex = 163;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Textcolor = System.Drawing.Color.White;
            this.btnLamMoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "Tên giáo viên giảng dạy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label12.Location = new System.Drawing.Point(11, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(296, 36);
            this.label12.TabIndex = 158;
            this.label12.Text = "Thông tin giảng dạy";
            // 
            // txtTenGV
            // 
            this.txtTenGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenGV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenGV.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.ForeColor = System.Drawing.Color.White;
            this.txtTenGV.HintForeColor = System.Drawing.Color.White;
            this.txtTenGV.HintText = "";
            this.txtTenGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenGV.isPassword = false;
            this.txtTenGV.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTenGV.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenGV.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtTenGV.LineThickness = 2;
            this.txtTenGV.Location = new System.Drawing.Point(375, 156);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenGV.MaxLength = 32767;
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(235, 30);
            this.txtTenGV.TabIndex = 110;
            this.txtTenGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.cboMaMon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.cboMaLop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMaGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 213);
            this.groupBox1.TabIndex = 159;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtTenMon
            // 
            this.txtTenMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenMon.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.ForeColor = System.Drawing.Color.White;
            this.txtTenMon.HintForeColor = System.Drawing.Color.White;
            this.txtTenMon.HintText = "";
            this.txtTenMon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenMon.isPassword = false;
            this.txtTenMon.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTenMon.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenMon.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtTenMon.LineThickness = 2;
            this.txtTenMon.Location = new System.Drawing.Point(366, 78);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenMon.MaxLength = 32767;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(244, 30);
            this.txtTenMon.TabIndex = 171;
            this.txtTenMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cboMaMon
            // 
            this.cboMaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.cboMaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaMon.ForeColor = System.Drawing.Color.White;
            this.cboMaMon.FormattingEnabled = true;
            this.cboMaMon.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaMon.Location = new System.Drawing.Point(266, 78);
            this.cboMaMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(97, 28);
            this.cboMaMon.TabIndex = 170;
            this.cboMaMon.TextChanged += new System.EventHandler(this.cboMaMon_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(164, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 169;
            this.label5.Text = "Mã môn";
            // 
            // txtTenLop
            // 
            this.txtTenLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenLop.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.ForeColor = System.Drawing.Color.White;
            this.txtTenLop.HintForeColor = System.Drawing.Color.White;
            this.txtTenLop.HintText = "";
            this.txtTenLop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenLop.isPassword = false;
            this.txtTenLop.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTenLop.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenLop.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtTenLop.LineThickness = 2;
            this.txtTenLop.Location = new System.Drawing.Point(366, 29);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenLop.MaxLength = 32767;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(244, 30);
            this.txtTenLop.TabIndex = 168;
            this.txtTenLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(164, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 167;
            this.label6.Text = "Mã lớp";
            // 
            // cboMaLop
            // 
            this.cboMaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.cboMaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLop.ForeColor = System.Drawing.Color.White;
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaLop.Location = new System.Drawing.Point(266, 29);
            this.cboMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(97, 28);
            this.cboMaLop.TabIndex = 166;
            this.cboMaLop.TextChanged += new System.EventHandler(this.cboMaLop_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(164, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Mã giáo viên giảng dạy";
            // 
            // cboMaGV
            // 
            this.cboMaGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.cboMaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaGV.ForeColor = System.Drawing.Color.White;
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaGV.Location = new System.Drawing.Point(375, 119);
            this.cboMaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(235, 28);
            this.cboMaGV.TabIndex = 105;
            this.cboMaGV.TextChanged += new System.EventHandler(this.cboMaGV_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Active = false;
            this.btnLuu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 7;
            this.btnLuu.ButtonText = "    Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLuu.Iconimage")));
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 70D;
            this.btnLuu.IsTab = false;
            this.btnLuu.Location = new System.Drawing.Point(809, 190);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(151, 45);
            this.btnLuu.TabIndex = 166;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Active = false;
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 7;
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Iconimage")));
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 70D;
            this.btnTimKiem.IsTab = false;
            this.btnTimKiem.Location = new System.Drawing.Point(896, 122);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(151, 45);
            this.btnTimKiem.TabIndex = 167;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = null;
            this.btnMinimized.Location = new System.Drawing.Point(1068, 16);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(42, 34);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 168;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1165, 585);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanCong";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPhanCong_MouseDown);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvTTGD;
        private Bunifu.Framework.UI.BunifuImageButton btnDong;
        private Bunifu.Framework.UI.BunifuFlatButton btnLamMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenMon;
        private System.Windows.Forms.ComboBox cboMaMon;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMaLop;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
    }
}