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
    public partial class frmDoiMatKhau : Form {
        public frmDoiMatKhau() {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (GeneralCheck())
            {
                string query = "SELECT * FROM " +
                    "TAIKHOAN WHERE TENDANGNHAP='" + txtTaikhoan.Text + "' AND " +
                    "MATKHAU='" + txtMKcu.Text + "'";
                if (txtMKmoi.Text != txtXacNhanMk.Text)
                {
                    //provider
                    return;
                }
                if (DatabaseConnection.CheckExist(query))
                {
                    query = "UPDATE TAIKHOAN SET " +
                            "MATKHAU='" + txtMKmoi.Text + "' " +
                            "WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
                    if (DatabaseConnection.ExcuteSql(query))
                        MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Không đúng tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtTaikhoan.Text = "";
            txtMKcu.Text = "";
            txtMKmoi.Text = "";
            txtXacNhanMk.Text = "";
        }

        bool GeneralCheck()
        {
            errorProvider1.Clear();
            bool flag = true;
            if (txtTaikhoan.Text == "")
            {
                txtTaikhoan.Focus();
                flag = false;
                // Provider
                errorProvider1.SetError(txtTaikhoan, "Không được bỏ trống vùng này");
            }
            if (txtMKcu.Text == "")
            {
                txtMKcu.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtMKcu, "Không được bỏ trống vùng này");
            }
            if (txtMKmoi.Text == "")
            {
                txtMKmoi.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtMKmoi, "Không được bỏ trống vùng này");
            }
            if (txtXacNhanMk.Text != txtMKmoi.Text) {
                txtXacNhanMk.Focus();
                flag = false;
                errorProvider1.SetError(txtXacNhanMk, "Không khớp mật khẩu");
                //Provider;
            }
            return flag;
        }
    }
}
