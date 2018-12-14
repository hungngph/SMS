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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }


        //Quản lý tài khoản
        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            btnDoiMatKhau.Visible = !btnDoiMatKhau.Visible;
            btnCSDSNguoiDung.Visible = !btnCSDSNguoiDung.Visible;
        }

        //Đổi mật khẩu
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.Show();
        }

        //Chỉnh sửa danh sách người dùng
        private void btnCSDSNguoiDung_Click(object sender, EventArgs e)
        {
            frmDanhSachNguoiDung csdsng = new frmDanhSachNguoiDung();
            csdsng.Show();
        }

        //Cập nhật thông tin
        private void btnCapNhapThongTin_Click(object sender, EventArgs e)
        {
            btnThongTinHS.Visible = !btnThongTinHS.Visible;
            btnThongTinGiaoVien.Visible = !btnThongTinGiaoVien.Visible;
            btnThongTinLopHoc.Visible = ! btnThongTinLopHoc.Visible;
        }

        //Thông tin học sinh
        private void btnThongTinHS_Click(object sender, EventArgs e)
        {
            frmHocSinh hs = new frmHocSinh();
            hs.Show();
        }

        //Thông tin giáo viên
        private void btnThongTinGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.Show();
        }

        //Thông tin lớp học
        private void btnThongTinLopHoc_Click(object sender, EventArgs e)
        {
            frmLopHoc lh = new frmLopHoc();
            lh.Show();
        }

        //Quản lý điểm lớp học
        private void btnQLDiem_Click(object sender, EventArgs e)
        {
            btnNhapDiem.Visible = !btnNhapDiem.Visible;
            btnXemDiem.Visible = !btnXemDiem.Visible;
        }
        //Nhập điểm
        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            frmNhapDiem ndiem = new frmNhapDiem();
            ndiem.Show();
        }
        //Xem điểm
        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            frmXemDiem xdiem = new frmXemDiem();
            xdiem.Show();
        }
        //

        //Giới thiệu
        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            grpGioiThieu.Visible = true;
        }

        
        //
    }
}
