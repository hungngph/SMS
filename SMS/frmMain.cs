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
        private void btnGroup1_Click(object sender, EventArgs e)
        {
            btn11.Visible = !btn11.Visible;
            btn12.Visible = !btn12.Visible;
        }

        //Đổi mật khẩu
        private void btn11_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.Show();
        }

        //Chỉnh sửa danh sách người dùng
        private void btn12_Click(object sender, EventArgs e)
        {
            frmDanhSachNguoiDung csdsng = new frmDanhSachNguoiDung();
            csdsng.Show();
        }

        //Cập nhật thông tin
        private void btnGroup2_Click(object sender, EventArgs e)
        {
            btn21.Visible = !btn21.Visible;
            btn22.Visible = !btn22.Visible;
            btn23.Visible = !btn23.Visible;
        }

        //Thông tin sinh viên
        private void btn21_Click(object sender, EventArgs e)
        {
            frmHocSinh hs = new frmHocSinh();
            hs.Show();
        }

        //Thông tin giáo viên
        private void btn22_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.Show();
        }

        //Thông tin lớp học
        private void btn23_Click(object sender, EventArgs e)
        {
            frmLopHoc lh = new frmLopHoc();
            lh.Show();
        }

        //Quản lý điểm lớp học
        private void btnGroup3_Click(object sender, EventArgs e)
        {
            btn31.Visible = !btn31.Visible;
            btn32.Visible = !btn32.Visible;
        }
        //Nhập điểm
        private void btn31_Click(object sender, EventArgs e)
        {
            frmNhapDiem ndiem = new frmNhapDiem();
            ndiem.Show();
        }
        //Xem điểm
        private void btn32_Click(object sender, EventArgs e)
        {
            frmXemDiem xdiem = new frmXemDiem();
            xdiem.Show();
        }
        //

        //Giới thiệu
        private void btnGroup7_Click(object sender, EventArgs e)
        {
            groupBoxGioiThieu.Visible = !groupBoxGioiThieu.Visible;
        }
        //
    }
}
