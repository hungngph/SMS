namespace SMS
{
    partial class frmXemDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemDiem));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenMon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNamHoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHocKy = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenLop = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.btnDong = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvDSXD = new System.Windows.Forms.DataGridView();
            this.btnXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXD)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label12.Location = new System.Drawing.Point(11, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 36);
            this.label12.TabIndex = 146;
            this.label12.Text = "Xem điểm";
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
            this.txtTenMon.Location = new System.Drawing.Point(222, 91);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenMon.MaxLength = 32767;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(244, 30);
            this.txtTenMon.TabIndex = 123;
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
            this.cboMaMon.Location = new System.Drawing.Point(121, 91);
            this.cboMaMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(97, 28);
            this.cboMaMon.TabIndex = 122;
            this.cboMaMon.SelectionChangeCommitted += new System.EventHandler(this.cboMaMon_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 120;
            this.label2.Text = "Mã môn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.cboMaMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNamHoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMaLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(498, 222);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNamHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNamHoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNamHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.ForeColor = System.Drawing.Color.White;
            this.txtNamHoc.HintForeColor = System.Drawing.Color.White;
            this.txtNamHoc.HintText = "";
            this.txtNamHoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNamHoc.isPassword = false;
            this.txtNamHoc.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtNamHoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNamHoc.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtNamHoc.LineThickness = 2;
            this.txtNamHoc.Location = new System.Drawing.Point(121, 162);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNamHoc.MaxLength = 32767;
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(344, 30);
            this.txtNamHoc.TabIndex = 118;
            this.txtNamHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 114;
            this.label8.Text = "Năm học";
            // 
            // txtHocKy
            // 
            this.txtHocKy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHocKy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHocKy.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHocKy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.ForeColor = System.Drawing.Color.White;
            this.txtHocKy.HintForeColor = System.Drawing.Color.White;
            this.txtHocKy.HintText = "";
            this.txtHocKy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHocKy.isPassword = false;
            this.txtHocKy.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtHocKy.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHocKy.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtHocKy.LineThickness = 2;
            this.txtHocKy.Location = new System.Drawing.Point(121, 120);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHocKy.MaxLength = 32767;
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(344, 30);
            this.txtHocKy.TabIndex = 112;
            this.txtHocKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 111;
            this.label7.Text = "Học kỳ";
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
            this.txtTenLop.Location = new System.Drawing.Point(222, 42);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenLop.MaxLength = 32767;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(244, 30);
            this.txtTenLop.TabIndex = 108;
            this.txtTenLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Mã lớp";
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
            this.cboMaLop.Location = new System.Drawing.Point(121, 42);
            this.cboMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(97, 28);
            this.cboMaLop.TabIndex = 105;
            this.cboMaLop.SelectionChangeCommitted += new System.EventHandler(this.cboMaLop_TextChanged);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageActive = null;
            this.btnDong.Location = new System.Drawing.Point(1110, 13);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(42, 34);
            this.btnDong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDong.TabIndex = 145;
            this.btnDong.TabStop = false;
            this.btnDong.Zoom = 10;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvDSXD
            // 
            this.dgvDSXD.AllowUserToAddRows = false;
            this.dgvDSXD.AllowUserToDeleteRows = false;
            this.dgvDSXD.AllowUserToResizeRows = false;
            this.dgvDSXD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSXD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSXD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSXD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSXD.Location = new System.Drawing.Point(3, 21);
            this.dgvDSXD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSXD.Name = "dgvDSXD";
            this.dgvDSXD.ReadOnly = true;
            this.dgvDSXD.RowHeadersVisible = false;
            this.dgvDSXD.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDSXD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSXD.Size = new System.Drawing.Size(1122, 271);
            this.dgvDSXD.TabIndex = 132;
            // 
            // btnXuat
            // 
            this.btnXuat.Active = false;
            this.btnXuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuat.BorderRadius = 7;
            this.btnXuat.ButtonText = "  Xuất Excel";
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXuat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnXuat.Iconimage")));
            this.btnXuat.Iconimage_right = null;
            this.btnXuat.Iconimage_right_Selected = null;
            this.btnXuat.Iconimage_Selected = null;
            this.btnXuat.IconMarginLeft = 0;
            this.btnXuat.IconMarginRight = 0;
            this.btnXuat.IconRightVisible = true;
            this.btnXuat.IconRightZoom = 0D;
            this.btnXuat.IconVisible = true;
            this.btnXuat.IconZoom = 70D;
            this.btnXuat.IsTab = false;
            this.btnXuat.Location = new System.Drawing.Point(211, 306);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnXuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXuat.selected = false;
            this.btnXuat.Size = new System.Drawing.Size(165, 45);
            this.btnXuat.TabIndex = 149;
            this.btnXuat.Text = "  Xuất Excel";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Textcolor = System.Drawing.Color.White;
            this.btnXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.groupBox4.Controls.Add(this.dgvDSXD);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 370);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1128, 294);
            this.groupBox4.TabIndex = 153;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
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
            this.btnTimKiem.Location = new System.Drawing.Point(17, 306);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(165, 45);
            this.btnTimKiem.TabIndex = 151;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = null;
            this.btnMinimized.Location = new System.Drawing.Point(1069, 13);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(42, 34);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 154;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // chart
            // 
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(537, 51);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Diem";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(497, 300);
            this.chart.TabIndex = 124;
            this.chart.Text = "chart1";
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1165, 675);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmXemDiem_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenMon;
        private System.Windows.Forms.ComboBox cboMaMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNamHoc;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHocKy;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaLop;
        private Bunifu.Framework.UI.BunifuImageButton btnDong;
        private System.Windows.Forms.DataGridView dgvDSXD;
        private Bunifu.Framework.UI.BunifuFlatButton btnXuat;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}