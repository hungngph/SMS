namespace SMS
{
    partial class frmDanhSachNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachNguoiDung));
            this.btnDong = new Bunifu.Framework.UI.BunifuImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtXacNhanMk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMK = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTaiKhoan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.btnThemMoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChinhSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLamMoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSND = new System.Windows.Forms.DataGridView();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageActive = null;
            this.btnDong.Location = new System.Drawing.Point(883, 11);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(42, 34);
            this.btnDong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDong.TabIndex = 3;
            this.btnDong.TabStop = false;
            this.btnDong.Zoom = 10;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label12.Location = new System.Drawing.Point(11, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(323, 36);
            this.label12.TabIndex = 79;
            this.label12.Text = "Danh sách người dùng";
            // 
            // txtXacNhanMk
            // 
            this.txtXacNhanMk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtXacNhanMk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtXacNhanMk.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtXacNhanMk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhanMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMk.ForeColor = System.Drawing.Color.White;
            this.txtXacNhanMk.HintForeColor = System.Drawing.Color.White;
            this.txtXacNhanMk.HintText = "";
            this.txtXacNhanMk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtXacNhanMk.isPassword = false;
            this.txtXacNhanMk.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtXacNhanMk.LineIdleColor = System.Drawing.Color.Gray;
            this.txtXacNhanMk.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtXacNhanMk.LineThickness = 2;
            this.txtXacNhanMk.Location = new System.Drawing.Point(213, 153);
            this.txtXacNhanMk.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtXacNhanMk.MaxLength = 32767;
            this.txtXacNhanMk.Name = "txtXacNhanMk";
            this.txtXacNhanMk.Size = new System.Drawing.Size(320, 30);
            this.txtXacNhanMk.TabIndex = 96;
            this.txtXacNhanMk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMK
            // 
            this.txtMK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMK.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.Color.White;
            this.txtMK.HintForeColor = System.Drawing.Color.White;
            this.txtMK.HintText = "";
            this.txtMK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMK.isPassword = false;
            this.txtMK.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtMK.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMK.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtMK.LineThickness = 2;
            this.txtMK.Location = new System.Drawing.Point(213, 113);
            this.txtMK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMK.MaxLength = 32767;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(320, 30);
            this.txtMK.TabIndex = 95;
            this.txtMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTaiKhoan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTaiKhoan.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.txtTaiKhoan.HintForeColor = System.Drawing.Color.White;
            this.txtTaiKhoan.HintText = "";
            this.txtTaiKhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTaiKhoan.isPassword = false;
            this.txtTaiKhoan.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTaiKhoan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTaiKhoan.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtTaiKhoan.LineThickness = 2;
            this.txtTaiKhoan.Location = new System.Drawing.Point(213, 72);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTaiKhoan.MaxLength = 32767;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(320, 30);
            this.txtTaiKhoan.TabIndex = 94;
            this.txtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Tên tài khoản ";
            // 
            // cboQuyen
            // 
            this.cboQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.cboQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuyen.ForeColor = System.Drawing.Color.White;
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Admin",
            "Giáo viên"});
            this.cboQuyen.Location = new System.Drawing.Point(213, 199);
            this.cboQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(320, 28);
            this.cboQuyen.TabIndex = 104;
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
            this.btnThemMoi.Location = new System.Drawing.Point(565, 59);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnThemMoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnThemMoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemMoi.selected = false;
            this.btnThemMoi.Size = new System.Drawing.Size(163, 45);
            this.btnThemMoi.TabIndex = 105;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Textcolor = System.Drawing.Color.White;
            this.btnThemMoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(762, 59);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(163, 45);
            this.btnXoa.TabIndex = 106;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnChinhSua.Location = new System.Drawing.Point(565, 125);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnChinhSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnChinhSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChinhSua.selected = false;
            this.btnChinhSua.Size = new System.Drawing.Size(163, 45);
            this.btnChinhSua.TabIndex = 107;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Textcolor = System.Drawing.Color.White;
            this.btnChinhSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
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
            this.btnLamMoi.Location = new System.Drawing.Point(762, 125);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLamMoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnLamMoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLamMoi.selected = false;
            this.btnLamMoi.Size = new System.Drawing.Size(163, 45);
            this.btnLamMoi.TabIndex = 108;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Textcolor = System.Drawing.Color.White;
            this.btnLamMoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(565, 189);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(163, 45);
            this.btnTimKiem.TabIndex = 109;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSND);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(38, 249);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(887, 231);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvDSND
            // 
            this.dgvDSND.AllowUserToAddRows = false;
            this.dgvDSND.AllowUserToDeleteRows = false;
            this.dgvDSND.AllowUserToResizeRows = false;
            this.dgvDSND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSND.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSND.Location = new System.Drawing.Point(3, 22);
            this.dgvDSND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSND.Name = "dgvDSND";
            this.dgvDSND.ReadOnly = true;
            this.dgvDSND.RowHeadersVisible = false;
            this.dgvDSND.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDSND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSND.Size = new System.Drawing.Size(881, 207);
            this.dgvDSND.TabIndex = 133;
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = null;
            this.btnMinimized.Location = new System.Drawing.Point(842, 11);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(42, 34);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 111;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // frmDanhSachNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.txtXacNhanMk);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDong);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDanhSachNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhSachNguoiDung";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmDanhSachNguoiDung_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDanhSachNguoiDung_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnDong;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtXacNhanMk;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMK;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTaiKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboQuyen;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemMoi;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnChinhSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnLamMoi;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSND;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
    }
}