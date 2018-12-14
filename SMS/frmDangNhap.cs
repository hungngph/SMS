using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SMS
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        //Sử dụng thư viện
        //using System.Runtime.InteropServices;
        //để di chuyển frm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (GeneralCheck())
            {
                string query = "SELECT * FROM TAIKHOAN WHERE" +
                    " TENDANGNHAP = '" + txtTaiKhoan.Text +
                    "' AND MATKHAU = '" + txtMatKhau.Text;
                string admin = "' AND QUYENTRUYCAP = 'Admin'";
                string teacher = "' AND QUYENTRUYCAP = N'Giáo viên'";
                if (DatabaseConnection.CheckExist(query + admin))
                {
                    DatabaseConnection.isAdmin = true;
                    this.Hide();
                    frmChucNang frm = new frmChucNang();
                    frm.Show();
                    return;
                }
                if (DatabaseConnection.CheckExist(query + teacher))
                {
                    DatabaseConnection.MaGV = txtTaiKhoan.Text;
                    DatabaseConnection.isAdmin = false;
                    this.Hide();
                    frmChucNang frm = new frmChucNang();
                    frm.Show();
                    return;
                }
                lblKiemTra.Text = "Sai tên đăng nhập hoặc mật khẩu";
                txtMatKhau.Text = "";
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblKiemTra.Text = "";
        }


        bool GeneralCheck()
        {
            bool flag = true;
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Focus();
                flag = false;
                // Provider
                errorProvider1.SetError(txtTaiKhoan, "Không được bỏ trống vùng này");
            }
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtMatKhau, "Không được bỏ trống vùng này");
            }
            return flag;
        }
    }
}
