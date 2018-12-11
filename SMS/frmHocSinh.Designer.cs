namespace SMS
{
    partial class frmHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinh));
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.groupDS = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxSDT = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSHS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.groupBoxTTCT = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHoTenCha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHoTenMe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxSDTMe = new System.Windows.Forms.MaskedTextBox();
            this.mtxSDTCha = new System.Windows.Forms.MaskedTextBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            this.groupDS.SuspendLayout();
            this.groupBoxTTCT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHS
            // 
            this.dgvHS.AllowUserToAddRows = false;
            this.dgvHS.AllowUserToDeleteRows = false;
            this.dgvHS.AllowUserToResizeRows = false;
            this.dgvHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHS.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHS.Location = new System.Drawing.Point(3, 21);
            this.dgvHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHS.Size = new System.Drawing.Size(1115, 198);
            this.dgvHS.TabIndex = 0;
            this.dgvHS.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHS_CellMouseClick);
            // 
            // groupDS
            // 
            this.groupDS.Controls.Add(this.dgvHS);
            this.groupDS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDS.Location = new System.Drawing.Point(21, 406);
            this.groupDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupDS.Name = "groupDS";
            this.groupDS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupDS.Size = new System.Drawing.Size(1121, 221);
            this.groupDS.TabIndex = 97;
            this.groupDS.TabStop = false;
            this.groupDS.Text = "Danh sách học sinh";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(740, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(177, 180);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hình";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(493, 355);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(177, 42);
            this.btnXoa.TabIndex = 93;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(710, 355);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(177, 42);
            this.btnLamMoi.TabIndex = 92;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(34, 355);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(177, 42);
            this.btnThemMoi.TabIndex = 88;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(263, 355);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(177, 42);
            this.btnSua.TabIndex = 89;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(156, 28);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(184, 26);
            this.txtHoTen.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(361, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Khóa";
            // 
            // mtxSDT
            // 
            this.mtxSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxSDT.ForeColor = System.Drawing.Color.Black;
            this.mtxSDT.Location = new System.Drawing.Point(487, 126);
            this.mtxSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxSDT.Mask = "9999 000 000";
            this.mtxSDT.Name = "mtxSDT";
            this.mtxSDT.Size = new System.Drawing.Size(184, 26);
            this.mtxSDT.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Giới tính";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(156, 58);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(184, 27);
            this.cboGioiTinh.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(361, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(487, 92);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(184, 26);
            this.txtDiaChi.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(361, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Mã số học sinh";
            // 
            // txtMSHS
            // 
            this.txtMSHS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSHS.ForeColor = System.Drawing.Color.Black;
            this.txtMSHS.Location = new System.Drawing.Point(487, 27);
            this.txtMSHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMSHS.Name = "txtMSHS";
            this.txtMSHS.Size = new System.Drawing.Size(184, 26);
            this.txtMSHS.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(361, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "Dân tộc";
            // 
            // txtDanToc
            // 
            this.txtDanToc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanToc.ForeColor = System.Drawing.Color.Black;
            this.txtDanToc.Location = new System.Drawing.Point(487, 62);
            this.txtDanToc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(184, 26);
            this.txtDanToc.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ngày sinh";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.txtNgaySinh.Location = new System.Drawing.Point(156, 92);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(165, 26);
            this.txtNgaySinh.TabIndex = 65;
            // 
            // groupBoxTTCT
            // 
            this.groupBoxTTCT.Controls.Add(this.cboMaLop);
            this.groupBoxTTCT.Controls.Add(this.dtpNgaySinh);
            this.groupBoxTTCT.Controls.Add(this.label12);
            this.groupBoxTTCT.Controls.Add(this.txtEmail);
            this.groupBoxTTCT.Controls.Add(this.label5);
            this.groupBoxTTCT.Controls.Add(this.txtNgaySinh);
            this.groupBoxTTCT.Controls.Add(this.label6);
            this.groupBoxTTCT.Controls.Add(this.txtDanToc);
            this.groupBoxTTCT.Controls.Add(this.label4);
            this.groupBoxTTCT.Controls.Add(this.txtMSHS);
            this.groupBoxTTCT.Controls.Add(this.label1);
            this.groupBoxTTCT.Controls.Add(this.txtDiaChi);
            this.groupBoxTTCT.Controls.Add(this.label10);
            this.groupBoxTTCT.Controls.Add(this.cboGioiTinh);
            this.groupBoxTTCT.Controls.Add(this.label7);
            this.groupBoxTTCT.Controls.Add(this.mtxSDT);
            this.groupBoxTTCT.Controls.Add(this.txtKhoa);
            this.groupBoxTTCT.Controls.Add(this.label3);
            this.groupBoxTTCT.Controls.Add(this.label8);
            this.groupBoxTTCT.Controls.Add(this.txtHoTen);
            this.groupBoxTTCT.Controls.Add(this.label9);
            this.groupBoxTTCT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTTCT.ForeColor = System.Drawing.Color.Black;
            this.groupBoxTTCT.Location = new System.Drawing.Point(20, 10);
            this.groupBoxTTCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTTCT.Name = "groupBoxTTCT";
            this.groupBoxTTCT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTTCT.Size = new System.Drawing.Size(703, 200);
            this.groupBoxTTCT.TabIndex = 31;
            this.groupBoxTTCT.TabStop = false;
            this.groupBoxTTCT.Text = "Thông tin học sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(318, 92);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(22, 26);
            this.dtpNgaySinh.TabIndex = 70;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(31, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 19);
            this.label12.TabIndex = 68;
            this.label12.Text = "Mã lớp";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(487, 163);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 26);
            this.txtEmail.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(362, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(84, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 19);
            this.label17.TabIndex = 48;
            this.label17.Text = "Họ và tên cha";
            // 
            // txtHoTenCha
            // 
            this.txtHoTenCha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenCha.ForeColor = System.Drawing.Color.Black;
            this.txtHoTenCha.Location = new System.Drawing.Point(220, 23);
            this.txtHoTenCha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenCha.Name = "txtHoTenCha";
            this.txtHoTenCha.Size = new System.Drawing.Size(184, 26);
            this.txtHoTenCha.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(85, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "Số điện thoại cha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(472, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 19);
            this.label13.TabIndex = 66;
            this.label13.Text = "Họ và tên mẹ";
            // 
            // txtHoTenMe
            // 
            this.txtHoTenMe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenMe.ForeColor = System.Drawing.Color.Black;
            this.txtHoTenMe.Location = new System.Drawing.Point(608, 23);
            this.txtHoTenMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenMe.Name = "txtHoTenMe";
            this.txtHoTenMe.Size = new System.Drawing.Size(184, 26);
            this.txtHoTenMe.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(473, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 19);
            this.label11.TabIndex = 70;
            this.label11.Text = "Số điện thoại mẹ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxSDTMe);
            this.groupBox1.Controls.Add(this.mtxSDTCha);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtHoTenMe);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTenCha);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(896, 100);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin gia đình";
            // 
            // mtxSDTMe
            // 
            this.mtxSDTMe.Location = new System.Drawing.Point(608, 58);
            this.mtxSDTMe.Mask = "9999 000 000";
            this.mtxSDTMe.Name = "mtxSDTMe";
            this.mtxSDTMe.Size = new System.Drawing.Size(184, 26);
            this.mtxSDTMe.TabIndex = 73;
            // 
            // mtxSDTCha
            // 
            this.mtxSDTCha.Location = new System.Drawing.Point(220, 58);
            this.mtxSDTCha.Mask = "9999 000 000";
            this.mtxSDTCha.Name = "mtxSDTCha";
            this.mtxSDTCha.Size = new System.Drawing.Size(184, 26);
            this.mtxSDTCha.TabIndex = 72;
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(156, 160);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(184, 27);
            this.cboMaLop.TabIndex = 99;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.ForeColor = System.Drawing.Color.Black;
            this.txtKhoa.Location = new System.Drawing.Point(156, 126);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(184, 26);
            this.txtKhoa.TabIndex = 52;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(928, 355);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(181, 42);
            this.btnTimKiem.TabIndex = 107;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 638);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupDS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupBoxTTCT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHocSinh";
            this.Text = "Thông Tin Học Sinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
            this.groupDS.ResumeLayout(false);
            this.groupBoxTTCT.ResumeLayout(false);
            this.groupBoxTTCT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHS;
        private System.Windows.Forms.GroupBox groupDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSHS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.GroupBox groupBoxTTCT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtHoTenCha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHoTenMe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.MaskedTextBox mtxSDTMe;
        private System.Windows.Forms.MaskedTextBox mtxSDTCha;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Button btnTimKiem;
    }
}