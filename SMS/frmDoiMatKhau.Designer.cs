namespace SMS
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.btnDong = new Bunifu.Framework.UI.BunifuImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMK = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMKmoi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtXacNhanMk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLamMoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHoanTat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageActive = null;
            this.btnDong.Location = new System.Drawing.Point(583, 7);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(42, 34);
            this.btnDong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDong.TabIndex = 79;
            this.btnDong.TabStop = false;
            this.btnDong.Zoom = 10;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label12.Location = new System.Drawing.Point(10, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 36);
            this.label12.TabIndex = 80;
            this.label12.Text = "Thông tin tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên tài khoản ";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTaikhoan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTaikhoan.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaikhoan.Enabled = false;
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.ForeColor = System.Drawing.Color.White;
            this.txtTaikhoan.HintForeColor = System.Drawing.Color.White;
            this.txtTaikhoan.HintText = "";
            this.txtTaikhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTaikhoan.isPassword = false;
            this.txtTaikhoan.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTaikhoan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTaikhoan.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtTaikhoan.LineThickness = 2;
            this.txtTaikhoan.Location = new System.Drawing.Point(243, 82);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTaikhoan.MaxLength = 32767;
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(320, 30);
            this.txtTaikhoan.TabIndex = 86;
            this.txtTaikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtMK.isPassword = true;
            this.txtMK.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtMK.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMK.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtMK.LineThickness = 2;
            this.txtMK.Location = new System.Drawing.Point(243, 123);
            this.txtMK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMK.MaxLength = 32767;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(320, 30);
            this.txtMK.TabIndex = 87;
            this.txtMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMKmoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMKmoi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMKmoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKmoi.ForeColor = System.Drawing.Color.White;
            this.txtMKmoi.HintForeColor = System.Drawing.Color.White;
            this.txtMKmoi.HintText = "";
            this.txtMKmoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMKmoi.isPassword = true;
            this.txtMKmoi.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtMKmoi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMKmoi.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtMKmoi.LineThickness = 2;
            this.txtMKmoi.Location = new System.Drawing.Point(243, 163);
            this.txtMKmoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMKmoi.MaxLength = 32767;
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(320, 30);
            this.txtMKmoi.TabIndex = 88;
            this.txtMKmoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtXacNhanMk.isPassword = true;
            this.txtXacNhanMk.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtXacNhanMk.LineIdleColor = System.Drawing.Color.Gray;
            this.txtXacNhanMk.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtXacNhanMk.LineThickness = 2;
            this.txtXacNhanMk.Location = new System.Drawing.Point(243, 204);
            this.txtXacNhanMk.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtXacNhanMk.MaxLength = 32767;
            this.txtXacNhanMk.Name = "txtXacNhanMk";
            this.txtXacNhanMk.Size = new System.Drawing.Size(320, 30);
            this.txtXacNhanMk.TabIndex = 89;
            this.txtXacNhanMk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnLamMoi.Location = new System.Drawing.Point(329, 282);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLamMoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnLamMoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLamMoi.selected = false;
            this.btnLamMoi.Size = new System.Drawing.Size(157, 53);
            this.btnLamMoi.TabIndex = 142;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Textcolor = System.Drawing.Color.White;
            this.btnLamMoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Active = false;
            this.btnHoanTat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnHoanTat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnHoanTat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoanTat.BorderRadius = 7;
            this.btnHoanTat.ButtonText = "Hoàn Tất";
            this.btnHoanTat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanTat.DisabledColor = System.Drawing.Color.Gray;
            this.btnHoanTat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHoanTat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHoanTat.Iconimage")));
            this.btnHoanTat.Iconimage_right = null;
            this.btnHoanTat.Iconimage_right_Selected = null;
            this.btnHoanTat.Iconimage_Selected = null;
            this.btnHoanTat.IconMarginLeft = 0;
            this.btnHoanTat.IconMarginRight = 0;
            this.btnHoanTat.IconRightVisible = true;
            this.btnHoanTat.IconRightZoom = 0D;
            this.btnHoanTat.IconVisible = true;
            this.btnHoanTat.IconZoom = 70D;
            this.btnHoanTat.IsTab = false;
            this.btnHoanTat.Location = new System.Drawing.Point(144, 282);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnHoanTat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnHoanTat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHoanTat.selected = false;
            this.btnHoanTat.Size = new System.Drawing.Size(157, 53);
            this.btnHoanTat.TabIndex = 143;
            this.btnHoanTat.Text = "Hoàn Tất";
            this.btnHoanTat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoanTat.Textcolor = System.Drawing.Color.White;
            this.btnHoanTat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
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
            this.btnMinimized.Location = new System.Drawing.Point(542, 7);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(42, 34);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 144;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(636, 361);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtXacNhanMk);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDoiMatKhau_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnDong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTaikhoan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMK;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMKmoi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtXacNhanMk;
        private Bunifu.Framework.UI.BunifuFlatButton btnLamMoi;
        private Bunifu.Framework.UI.BunifuFlatButton btnHoanTat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
    }
}