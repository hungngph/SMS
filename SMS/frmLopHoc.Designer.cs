namespace SMS
{
    partial class frmLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopHoc));
            this.txtTenGVCN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cboMAGVCN = new System.Windows.Forms.ComboBox();
            this.dgvLH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiSo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLop = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLop = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThemMoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDong = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnChinhSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLamMoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenGVCN
            // 
            this.txtTenGVCN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenGVCN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenGVCN.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenGVCN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGVCN.ForeColor = System.Drawing.Color.White;
            this.txtTenGVCN.HintForeColor = System.Drawing.Color.White;
            this.txtTenGVCN.HintText = "";
            this.txtTenGVCN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenGVCN.isPassword = false;
            this.txtTenGVCN.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTenGVCN.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenGVCN.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtTenGVCN.LineThickness = 2;
            this.txtTenGVCN.Location = new System.Drawing.Point(366, 156);
            this.txtTenGVCN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenGVCN.MaxLength = 32767;
            this.txtTenGVCN.Name = "txtTenGVCN";
            this.txtTenGVCN.Size = new System.Drawing.Size(244, 30);
            this.txtTenGVCN.TabIndex = 110;
            this.txtTenGVCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cboMAGVCN
            // 
            this.cboMAGVCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.cboMAGVCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMAGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMAGVCN.ForeColor = System.Drawing.Color.White;
            this.cboMAGVCN.FormattingEnabled = true;
            this.cboMAGVCN.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMAGVCN.Location = new System.Drawing.Point(366, 119);
            this.cboMAGVCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMAGVCN.Name = "cboMAGVCN";
            this.cboMAGVCN.Size = new System.Drawing.Size(244, 28);
            this.cboMAGVCN.TabIndex = 105;
            this.cboMAGVCN.TextChanged += new System.EventHandler(this.cboMAGVCN_TextChanged);
            // 
            // dgvLH
            // 
            this.dgvLH.AllowUserToAddRows = false;
            this.dgvLH.AllowUserToDeleteRows = false;
            this.dgvLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLH.Location = new System.Drawing.Point(3, 21);
            this.dgvLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLH.Name = "dgvLH";
            this.dgvLH.ReadOnly = true;
            this.dgvLH.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLH.Size = new System.Drawing.Size(1122, 221);
            this.dgvLH.TabIndex = 155;
            this.dgvLH.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLH_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSiSo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTenGVCN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMAGVCN);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 250);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 123;
            this.label3.Text = "Sĩ số";
            // 
            // txtSiSo
            // 
            this.txtSiSo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSiSo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSiSo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSiSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiSo.ForeColor = System.Drawing.Color.White;
            this.txtSiSo.HintForeColor = System.Drawing.Color.White;
            this.txtSiSo.HintText = "";
            this.txtSiSo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSiSo.isPassword = false;
            this.txtSiSo.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtSiSo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSiSo.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtSiSo.LineThickness = 2;
            this.txtSiSo.Location = new System.Drawing.Point(366, 197);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSiSo.MaxLength = 32767;
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(244, 30);
            this.txtSiSo.TabIndex = 122;
            this.txtSiSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "Tên giáo viên chủ nhiệm";
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
            this.txtTenLop.Location = new System.Drawing.Point(366, 67);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenLop.MaxLength = 32767;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(244, 30);
            this.txtTenLop.TabIndex = 120;
            this.txtTenLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(144, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 119;
            this.label13.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(144, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Mã giáo viên chủ nhiệm";
            // 
            // txtMaLop
            // 
            this.txtMaLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMaLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMaLop.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.ForeColor = System.Drawing.Color.White;
            this.txtMaLop.HintForeColor = System.Drawing.Color.White;
            this.txtMaLop.HintText = "";
            this.txtMaLop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMaLop.isPassword = false;
            this.txtMaLop.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtMaLop.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaLop.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtMaLop.LineThickness = 2;
            this.txtMaLop.Location = new System.Drawing.Point(366, 26);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaLop.MaxLength = 32767;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(244, 30);
            this.txtMaLop.TabIndex = 96;
            this.txtMaLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Mã lớp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label12.Location = new System.Drawing.Point(12, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 36);
            this.label12.TabIndex = 146;
            this.label12.Text = "Thông tin lớp học";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Active = false;
            this.btnThemMoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnThemMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemMoi.BorderRadius = 7;
            this.btnThemMoi.ButtonText = "Thêm mới";
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemMoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Iconimage")));
            this.btnThemMoi.Iconimage_right = null;
            this.btnThemMoi.Iconimage_right_Selected = null;
            this.btnThemMoi.Iconimage_Selected = null;
            this.btnThemMoi.IconMarginLeft = 0;
            this.btnThemMoi.IconMarginRight = 0;
            this.btnThemMoi.IconRightVisible = true;
            this.btnThemMoi.IconRightZoom = 0D;
            this.btnThemMoi.IconVisible = true;
            this.btnThemMoi.IconZoom = 70D;
            this.btnThemMoi.IsTab = false;
            this.btnThemMoi.Location = new System.Drawing.Point(811, 136);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnThemMoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnThemMoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemMoi.selected = false;
            this.btnThemMoi.Size = new System.Drawing.Size(151, 45);
            this.btnThemMoi.TabIndex = 150;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Textcolor = System.Drawing.Color.White;
            this.btnThemMoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.groupBox4.Controls.Add(this.dgvLH);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(18, 348);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1128, 244);
            this.groupBox4.TabIndex = 156;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
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
            // btnChinhSua
            // 
            this.btnChinhSua.Active = false;
            this.btnChinhSua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnChinhSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChinhSua.BorderRadius = 7;
            this.btnChinhSua.ButtonText = "Chỉnh sửa";
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnChinhSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChinhSua.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.Iconimage")));
            this.btnChinhSua.Iconimage_right = null;
            this.btnChinhSua.Iconimage_right_Selected = null;
            this.btnChinhSua.Iconimage_Selected = null;
            this.btnChinhSua.IconMarginLeft = 0;
            this.btnChinhSua.IconMarginRight = 0;
            this.btnChinhSua.IconRightVisible = true;
            this.btnChinhSua.IconRightZoom = 0D;
            this.btnChinhSua.IconVisible = true;
            this.btnChinhSua.IconZoom = 70D;
            this.btnChinhSua.IsTab = false;
            this.btnChinhSua.Location = new System.Drawing.Point(811, 202);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnChinhSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnChinhSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChinhSua.selected = false;
            this.btnChinhSua.Size = new System.Drawing.Size(151, 45);
            this.btnChinhSua.TabIndex = 152;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Textcolor = System.Drawing.Color.White;
            this.btnChinhSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Active = false;
            this.btnXoa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.BorderRadius = 7;
            this.btnXoa.ButtonText = "   Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnXoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXoa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnXoa.Iconimage")));
            this.btnXoa.Iconimage_right = null;
            this.btnXoa.Iconimage_right_Selected = null;
            this.btnXoa.Iconimage_Selected = null;
            this.btnXoa.IconMarginLeft = 0;
            this.btnXoa.IconMarginRight = 0;
            this.btnXoa.IconRightVisible = true;
            this.btnXoa.IconRightZoom = 0D;
            this.btnXoa.IconVisible = true;
            this.btnXoa.IconZoom = 70D;
            this.btnXoa.IsTab = false;
            this.btnXoa.Location = new System.Drawing.Point(994, 136);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(151, 45);
            this.btnXoa.TabIndex = 151;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnLamMoi.Location = new System.Drawing.Point(994, 202);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLamMoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnLamMoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLamMoi.selected = false;
            this.btnLamMoi.Size = new System.Drawing.Size(151, 45);
            this.btnLamMoi.TabIndex = 153;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Textcolor = System.Drawing.Color.White;
            this.btnLamMoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(903, 255);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(163, 45);
            this.btnTimKiem.TabIndex = 157;
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
            this.btnMinimized.Location = new System.Drawing.Point(1069, 13);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(42, 34);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 158;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1164, 607);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLopHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLopHoc_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenGVCN;
        private System.Windows.Forms.ComboBox cboMAGVCN;
        private System.Windows.Forms.DataGridView dgvLH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSiSo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenLop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemMoi;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuImageButton btnDong;
        private Bunifu.Framework.UI.BunifuFlatButton btnChinhSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnLamMoi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
    }
}