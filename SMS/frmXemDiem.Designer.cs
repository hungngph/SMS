﻿namespace SMS
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
            this.groupDS = new System.Windows.Forms.GroupBox();
            this.dgvDSXD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTTCT = new System.Windows.Forms.GroupBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXD)).BeginInit();
            this.groupBoxTTCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDS
            // 
            this.groupDS.Controls.Add(this.dgvDSXD);
            this.groupDS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDS.Location = new System.Drawing.Point(29, 188);
            this.groupDS.Name = "groupDS";
            this.groupDS.Size = new System.Drawing.Size(1025, 289);
            this.groupDS.TabIndex = 72;
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
            this.dgvDSXD.Location = new System.Drawing.Point(3, 26);
            this.dgvDSXD.Name = "dgvDSXD";
            this.dgvDSXD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSXD.Size = new System.Drawing.Size(1019, 260);
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
            this.button1.Location = new System.Drawing.Point(794, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 53);
            this.button1.TabIndex = 79;
            this.button1.Text = "Xuất Bảng Điểm";
            this.button1.UseVisualStyleBackColor = false;
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
            this.groupBoxTTCT.Location = new System.Drawing.Point(29, 28);
            this.groupBoxTTCT.Name = "groupBoxTTCT";
            this.groupBoxTTCT.Size = new System.Drawing.Size(701, 138);
            this.groupBoxTTCT.TabIndex = 81;
            this.groupBoxTTCT.TabStop = false;
            this.groupBoxTTCT.Text = "Thông tin chi tiết";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.ForeColor = System.Drawing.Color.Black;
            this.txtMaMon.Location = new System.Drawing.Point(135, 72);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(198, 30);
            this.txtMaMon.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 61;
            this.label3.Text = "Môn";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.ForeColor = System.Drawing.Color.Black;
            this.txtMaLop.Location = new System.Drawing.Point(135, 31);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(198, 30);
            this.txtMaLop.TabIndex = 60;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.ForeColor = System.Drawing.Color.Black;
            this.txtNamHoc.Location = new System.Drawing.Point(448, 72);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(198, 30);
            this.txtNamHoc.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(362, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Năm học";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.ForeColor = System.Drawing.Color.Black;
            this.txtHocKy.Location = new System.Drawing.Point(448, 31);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(198, 30);
            this.txtHocKy.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Học kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(43, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tên lớp";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(794, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(232, 53);
            this.btnTimKiem.TabIndex = 102;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 493);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBoxTTCT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmXemDiem";
            this.Text = "Xem điểm lớp quản lý";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            this.groupDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXD)).EndInit();
            this.groupBoxTTCT.ResumeLayout(false);
            this.groupBoxTTCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupDS;
        private System.Windows.Forms.DataGridView dgvDSXD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxTTCT;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}