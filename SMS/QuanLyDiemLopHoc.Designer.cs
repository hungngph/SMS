namespace SMS
{
    partial class QuanLyDiemLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDiemLopHoc));
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
            this.btnDanhSachNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btnDanhSachNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachNguoiDung.Image")));
            this.btnDanhSachNguoiDung.ImagePosition = 19;
            this.btnDanhSachNguoiDung.ImageZoom = 40;
            this.btnDanhSachNguoiDung.LabelPosition = 39;
            this.btnDanhSachNguoiDung.LabelText = "Danh sách người dùng";
            this.btnDanhSachNguoiDung.Location = new System.Drawing.Point(671, 94);
            this.btnDanhSachNguoiDung.Margin = new System.Windows.Forms.Padding(8);
            this.btnDanhSachNguoiDung.Name = "btnDanhSachNguoiDung";
            this.btnDanhSachNguoiDung.Size = new System.Drawing.Size(343, 237);
            this.btnDanhSachNguoiDung.TabIndex = 10;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnDoiMatKhau.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnDoiMatKhau.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.ImagePosition = 19;
            this.btnDoiMatKhau.ImageZoom = 40;
            this.btnDoiMatKhau.LabelPosition = 39;
            this.btnDoiMatKhau.LabelText = "Nhập điểm";
            this.btnDoiMatKhau.Location = new System.Drawing.Point(216, 94);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(8);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(343, 237);
            this.btnDoiMatKhau.TabIndex = 9;
            // 
            // QuanLyDiemLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btnDanhSachNguoiDung);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Name = "QuanLyDiemLopHoc";
            this.Size = new System.Drawing.Size(1240, 790);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnDanhSachNguoiDung;
        private Bunifu.Framework.UI.BunifuTileButton btnDoiMatKhau;
    }
}
