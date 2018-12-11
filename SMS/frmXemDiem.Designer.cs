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
            this.groupBoxTTCT = new System.Windows.Forms.GroupBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupDS = new System.Windows.Forms.GroupBox();
            this.dgvDSXD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTTCT.SuspendLayout();
            this.groupDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTTCT
            // 
            this.groupBoxTTCT.Controls.Add(this.txtMaMon);
            this.groupBoxTTCT.Controls.Add(this.label3);
            this.groupBoxTTCT.Controls.Add(this.txtMaLop);
            this.groupBoxTTCT.Controls.Add(this.txtNamHoc);
            this.groupBoxTTCT.Controls.Add(this.label2);
            this.groupBoxTTCT.Controls.Add(this.txtHocKy);
            this.groupBoxTTCT.Controls.Add(this.label1);
            this.groupBoxTTCT.Controls.Add(this.label7);
            this.groupBoxTTCT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTTCT.ForeColor = System.Drawing.Color.Black;
            this.groupBoxTTCT.Location = new System.Drawing.Point(12, 20);
            this.groupBoxTTCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTTCT.Name = "groupBoxTTCT";
            this.groupBoxTTCT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTTCT.Size = new System.Drawing.Size(623, 110);
            this.groupBoxTTCT.TabIndex = 105;
            this.groupBoxTTCT.TabStop = false;
            this.groupBoxTTCT.Text = "Thông tin chi tiết";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.ForeColor = System.Drawing.Color.Black;
            this.txtMaMon.Location = new System.Drawing.Point(120, 58);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(176, 26);
            this.txtMaMon.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Môn";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.ForeColor = System.Drawing.Color.Black;
            this.txtMaLop.Location = new System.Drawing.Point(120, 25);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(176, 26);
            this.txtMaLop.TabIndex = 60;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.ForeColor = System.Drawing.Color.Black;
            this.txtNamHoc.Location = new System.Drawing.Point(398, 58);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(176, 26);
            this.txtNamHoc.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(322, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Năm học";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.ForeColor = System.Drawing.Color.Black;
            this.txtHocKy.Location = new System.Drawing.Point(398, 25);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(176, 26);
            this.txtHocKy.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(322, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Học kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tên lớp";
            // 
            // groupDS
            // 
            this.groupDS.Controls.Add(this.dgvDSXD);
            this.groupDS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDS.Location = new System.Drawing.Point(12, 148);
            this.groupDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupDS.Name = "groupDS";
            this.groupDS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupDS.Size = new System.Drawing.Size(911, 231);
            this.groupDS.TabIndex = 103;
            this.groupDS.TabStop = false;
            this.groupDS.Text = "Danh sách";
            // 
            // dgvDSXD
            // 
            this.dgvDSXD.AllowUserToAddRows = false;
            this.dgvDSXD.AllowUserToDeleteRows = false;
            this.dgvDSXD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSXD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSXD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSXD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSXD.Location = new System.Drawing.Point(3, 21);
            this.dgvDSXD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSXD.Name = "dgvDSXD";
            this.dgvDSXD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSXD.Size = new System.Drawing.Size(905, 208);
            this.dgvDSXD.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(692, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 42);
            this.button1.TabIndex = 104;
            this.button1.Text = "Xuất Bảng Điểm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(692, 27);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(206, 42);
            this.btnTimKiem.TabIndex = 106;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 510);
            this.Controls.Add(this.groupBoxTTCT);
            this.Controls.Add(this.groupDS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmXemDiem";
            this.Text = "Xem điểm lớp quản lý";
            this.groupBoxTTCT.ResumeLayout(false);
            this.groupBoxTTCT.PerformLayout();
            this.groupDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTTCT;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupDS;
        private System.Windows.Forms.DataGridView dgvDSXD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}