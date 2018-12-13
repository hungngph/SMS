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
            this.btnXemDiem = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNhapDiem = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnXemDiem.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnXemDiem.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btnXemDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btnXemDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.Image")));
            this.btnXemDiem.ImagePosition = 19;
            this.btnXemDiem.ImageZoom = 40;
            this.btnXemDiem.LabelPosition = 39;
            this.btnXemDiem.LabelText = "Xem điểm";
            this.btnXemDiem.Location = new System.Drawing.Point(671, 94);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(8);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(343, 237);
            this.btnXemDiem.TabIndex = 10;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnNhapDiem.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnNhapDiem.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btnNhapDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.Image")));
            this.btnNhapDiem.ImagePosition = 19;
            this.btnNhapDiem.ImageZoom = 40;
            this.btnNhapDiem.LabelPosition = 39;
            this.btnNhapDiem.LabelText = "Nhập điểm";
            this.btnNhapDiem.Location = new System.Drawing.Point(216, 94);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(8);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(343, 237);
            this.btnNhapDiem.TabIndex = 9;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // QuanLyDiemLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnNhapDiem);
            this.Name = "QuanLyDiemLopHoc";
            this.Size = new System.Drawing.Size(1240, 790);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnXemDiem;
        private Bunifu.Framework.UI.BunifuTileButton btnNhapDiem;
    }
}
