using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class frmChucNang : Form
    {
        public frmChucNang()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoan1.Visible = true;
            capNhatThongTin1.Visible = false;
            quanLyDiemLopHoc1.Visible = false;
            gioiThieu1.Visible = false;
        }

        private void btnCapNhapThongTin_Click(object sender, EventArgs e)
        {
            capNhatThongTin1.Visible = true;
            quanLyTaiKhoan1.Visible = false;
            quanLyDiemLopHoc1.Visible = false;
            gioiThieu1.Visible = false;
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            quanLyDiemLopHoc1.Visible = true;
            capNhatThongTin1.Visible = false;
            quanLyTaiKhoan1.Visible = false;
            gioiThieu1.Visible = false;
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            gioiThieu1.Visible = true;
            quanLyDiemLopHoc1.Visible = false;
            capNhatThongTin1.Visible = false;
            quanLyTaiKhoan1.Visible = false;
        }
    }
}
