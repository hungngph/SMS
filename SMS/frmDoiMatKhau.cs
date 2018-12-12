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
            validateTenTK();
            validateMatKhauCu();
            validateMatKhauMoi();
            validateXacNhanMK();
            string query = "SELECT * FROM " +
                "TAIKHOAN WHERE TENDANGNHAP='" + txtTaikhoan.Text + "' AND " +
                "MATKHAU='" + txtMKcu.Text + "'";
            if (txtMKmoi.Text != txtXacNhanMk.Text) {
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

        private void btnLamMoi_Click(object sender, EventArgs e) {
            txtTaikhoan.Text = "";
            txtMKcu.Text = "";
            txtMKmoi.Text = "";
            txtXacNhanMk.Text = "";
        }

        bool GeneralCheck() {
            bool flag = true;
            if (txtTaikhoan.Text == "") {
                txtTaikhoan.Focus();
                flag = false;
                // Provider
            }
            else if (txtMKcu.Text == "") {
                txtMKcu.Focus();
                flag = false;
                //Provider
            }
            else if (txtMKmoi.Text == "") {
                flag = false;
                //Provider
            }
            else if (txtXacNhanMk.Text != txtMKmoi.Text) {
                txtXacNhanMk.Focus();
                flag = false;
                //Provider;
            }
            return flag;
        }

        //Xác thực đã nhập text
        protected bool validateTenTK()
        {
            bool flag = false;
            if (txtTaikhoan.Text == "")
            {
                errorProvider1.SetError(txtTaikhoan, "Chưa nhập tên tài khoản");
                flag = true;
            }
            else
                errorProvider1.SetError(txtTaikhoan, "");
            return flag;

        }
        protected bool validateMatKhauCu()
        {
            bool flag = false;
            if (txtMKcu.Text == "")
            {
                errorProvider1.SetError(txtMKcu, "Không được bỏ trống vùng này");
                flag = true;
            }
            else
                errorProvider1.SetError(txtMKcu, "");
            return flag;
        }
        protected bool validateMatKhauMoi()
        {
            bool flag = false;
            if (txtMKmoi.Text == "")
            {
                errorProvider1.SetError(txtXacNhanMk, "Không được bỏ trống vùng này");
                flag = true;
            }
            else errorProvider1.SetError(txtMKmoi, "");
            return flag;
        }
        protected bool validateXacNhanMK()
        {
            bool flag = false;
            if (txtXacNhanMk.Text == "")
            {
                errorProvider1.SetError(txtXacNhanMk, "Chưa xác nhận mật khẩu");
                flag = true;
            }
            else errorProvider1.SetError(txtXacNhanMk, "");
            return flag;
        }//
    }
}
