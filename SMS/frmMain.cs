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

        //Di chuyển form
        Boolean flag; int x, y;
        private void F1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;

        }

        private void F1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void F1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }
        //

        //Các chức năng chính:
        //1.Quản lý người dùng
        private void btnGroup1_Click(object sender, EventArgs e)
        {
            btn11.Visible = !btn11.Visible;
            btn12.Visible = !btn12.Visible;
        }

        //Đổi mật khẩu
        private void btn11_Click(object sender, EventArgs e)
        {
            frmDoiMK dmk = new frmDoiMK();
            dmk.Show();
        }

        //Chỉnh sửa danh sách người dùng
        private void btn12_Click(object sender, EventArgs e)
        {
            frmChinhSuaDSNguoiDung csdsng = new frmChinhSuaDSNguoiDung();
            csdsng.Show();
        }

        //2.Cập nhật thông tin
        private void btnGroup2_Click(object sender, EventArgs e)
        {
            btn21.Visible = !btn21.Visible;
            btn22.Visible = !btn22.Visible;
            btn23.Visible = !btn23.Visible;
            btn24.Visible = !btn24.Visible;
        }

        private void btn21_Click(object sender, EventArgs e) { }
        private void btn22_Click(object sender, EventArgs e) { }
        private void btn23_Click(object sender, EventArgs e) { }
        private void btn24_Click(object sender, EventArgs e) { }

        //3.Đăng ký môn học và nhập điểm
        private void btnGroup3_Click(object sender, EventArgs e)
        {
            btn31.Visible = !btn31.Visible;
            btn32.Visible = !btn32.Visible;
        }
        private void btn31_Click(object sender, EventArgs e) { }
        private void btn32_Click(object sender, EventArgs e) { }
        //

        //4.Thông tin học phí và điểm
        private void btnGroup4_Click(object sender, EventArgs e)
        {
            btn41.Visible = !btn41.Visible;
            btn42.Visible = !btn42.Visible;
        }
        private void btn41_Click(object sender, EventArgs e) { }
        private void btn42_Click(object sender, EventArgs e) { }
        //

        //5.Tìm kiếm
        private void btnGroup5_Click(object sender, EventArgs e)
        {
            btn51.Visible = !btn51.Visible;
            btn52.Visible = !btn52.Visible;
            btn53.Visible = !btn53.Visible;      
        }

        private void btn51_Click(object sender, EventArgs e) { }
        private void btn52_Click(object sender, EventArgs e) { }
        private void btn53_Click(object sender, EventArgs e) { }
        //

        //6.Báo cáo và xuất
        private void btnGroup6_Click(object sender, EventArgs e)
        {
            btn61.Visible = !btn61.Visible;
            btn62.Visible = !btn62.Visible;
            btn63.Visible = !btn63.Visible;
            btn64.Visible = !btn64.Visible;
            btn65.Visible = !btn65.Visible;
        }

        private void btn61_Click(object sender, EventArgs e) { }
        private void btn62_Click(object sender, EventArgs e) { }
        private void btn63_Click(object sender, EventArgs e) { }
        private void btn64_Click(object sender, EventArgs e) { }
        private void btn65_Click(object sender, EventArgs e) { }
        //

        //7.Giới thiệu
        private void btnGroup7_Click(object sender, EventArgs e)
        {

        }
        //
    }
}
