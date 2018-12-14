namespace SMS
{
    partial class QuanLyTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiKhoan));
            this.btnDanhSachNguoiDung = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDoiMatKhau = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btnDanhSachNguoiDung
            // 
            this.btnDanhSachNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnDanhSachNguoiDung.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnDanhSachNguoiDung.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btnDanhSachNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhSachNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnDanhSachNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachNguoiDung.Image")));
            this.btnDanhSachNguoiDung.ImagePosition = 19;
            this.btnDanhSachNguoiDung.ImageZoom = 40;
            this.btnDanhSachNguoiDung.LabelPosition = 39;
            this.btnDanhSachNguoiDung.LabelText = "Danh sách người dùng";
            this.btnDanhSachNguoiDung.Location = new System.Drawing.Point(597, 75);
            this.btnDanhSachNguoiDung.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDanhSachNguoiDung.Name = "btnDanhSachNguoiDung";
            this.btnDanhSachNguoiDung.Size = new System.Drawing.Size(305, 190);
            this.btnDanhSachNguoiDung.TabIndex = 8;
            this.btnDanhSachNguoiDung.Click += new System.EventHandler(this.btnDanhSachNguoiDung_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnDoiMatKhau.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnDoiMatKhau.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.ImagePosition = 19;
            this.btnDoiMatKhau.ImageZoom = 40;
            this.btnDoiMatKhau.LabelPosition = 39;
            this.btnDoiMatKhau.LabelText = "Đổi mật khẩu";
            this.btnDoiMatKhau.Location = new System.Drawing.Point(192, 75);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(305, 190);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnDanhSachNguoiDung);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Location = new System.Drawing.Point(319, 90);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(1102, 632);
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnDanhSachNguoiDung;
        private Bunifu.Framework.UI.BunifuTileButton btnDoiMatKhau;
    }
}
