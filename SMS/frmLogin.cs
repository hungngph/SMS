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
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM TAIKHOAN WHERE" +
                " TENDANGNHAP='" + txtTaiKhoan.Text +
                "' AND MATKHAU='" + txtMatKhau.Text;
            string admin = "' AND QUYENTRUYCAP='Admin'";
            string teacher = "' AND QUYENTRUYCAP=N'Giáo viên'";
            if (DatabaseConnection.CheckExist(query + admin))
                return;
            if (DatabaseConnection.CheckExist(query + teacher))
                return;
            MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo");
        }
        private void frmLogin_Load(object sender, EventArgs e) {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect()) {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
        }
    }
}
