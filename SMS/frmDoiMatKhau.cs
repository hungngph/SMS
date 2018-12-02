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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM " +
                "TAIKHOAN='" + txtTaikhoan.Text + "'" +
                "MATKHAU='" + txtMKcu + "'";
            if (txtMKmoi.Text != txtXacNhanMk.Text) {
                //provider
                return;
            }
            if (DatabaseConnection.CheckExist(query)) {
                query = "UPDATE TAIKHOAN SET " +
                        "MATKHAU='" + txtMKmoi + "' " +
                        "WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
                if (DatabaseConnection.ExcuteSql(query))
                    MessageBox.Show("Thay đổi thành công");
            }
            else
                MessageBox.Show("Không đúng tên tài khoản hoặc mật khẩu"); 
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e) {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect()) {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) {
            txtTaikhoan.Text = "";
            txtMKcu.Text = "";
            txtMKmoi.Text = "";
            txtXacNhanMk.Text = "";
        }
    }
}
