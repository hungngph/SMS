using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS {
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
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
                    frmMain frm = new frmMain();
                    frm.Show();
                    return;
                }
                if (DatabaseConnection.CheckExist(query + teacher))
                {
                    DatabaseConnection.isAdmin = false;
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                    return;
                }
                lblKiemTra.Text = "Sai tên đăng nhập hoặc mật khẩu";
                txtMatKhau.Text = "";
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
