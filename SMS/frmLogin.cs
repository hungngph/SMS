using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SMS
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM TAIKHOAN WHERE" +
                " TENDANGNHAP='" + txtTaiKhoan.Text +
                "' AND MATKHAU='" + txtMatKhau.Text;
            string admin = "' AND QUYENTRUYCAP='Admin'";
            string student = "' AND QUYENTRUYCAP='Sinh Viên'";
            string gVQL = "' AND QUYENTRUYCAP='GVQL'";
            string gVHT = "' AND QUYENTRUYCAP='GVHT'";
            if (DatabaseConnection.CheckExist(query + admin))
                return;
            if (DatabaseConnection.CheckExist(query + student))
                return;
            if (DatabaseConnection.CheckExist(query + gVQL))
                return;
            if (DatabaseConnection.CheckExist(query + gVHT))
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
