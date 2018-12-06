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
    public partial class frmDanhSachNguoiDung : Form {
        public frmDanhSachNguoiDung() {   
            InitializeComponent();
        }
        bool GeneralCheck() {
            bool flag = true;
            if (txtTaikhoan.Text == "") {
                txtTaikhoan.Focus();
                flag = false;
                // Provider
            }
            else if (txtMK.Text == "") {
                txtMK.Focus();
                flag = false;
                //Provider
            }
            else if (txtMK.Text != txtXacNhanMk.Text) {
                txtXacNhanMk.Focus();
                flag = false;
                //Provider
            }
            else if (cboQuyen.Text == "") {
                flag = false;
                //Provider
            }
            return flag;
        }
        void FillDataGridView() {
            string query = "SELECT * " +
                "FROM TAIKHOAN ";
            dgvDSND.DataSource = DatabaseConnection.GetDataTable(query);
            // adapter.Dispose();
        }

        //Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (GeneralCheck())
            {
                string query1 = "SELECT * " +
                    "FROM TAIKHOAN " +
                    "WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
                if (DatabaseConnection.CheckExist(query1))
                    MessageBox.Show("Không có tài khoản này", "Thông báo");
                else
                {
                    string query2 = "UPDATE TAIKHOAN SET " +
                        "MATKHAU='" + txtMK.Text + "' " +
                        "QUYENTRUYCAP='" + cboQuyen.Text + "' " +
                        "WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
                    FillDataGridView();
                }
            }
        }

        //Thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string query = "SELECT * " +
                "FROM TAIKHOAN " +
                "WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
            if (GeneralCheck())
                if (DatabaseConnection.CheckExist(query))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo");
                    txtTaikhoan.Focus();
                }
                else
                {
                    query = "INSERT INTO TAIKHOAN(TENDANGNHAP, MATKHAU, QUYENTRUYCAP) " +
                        "VALUES(N'" + txtTaikhoan.Text + "',N'" + txtMK.Text + "','" + cboQuyen.Text + "')";
                    if (DatabaseConnection.ExcuteSql(query))
                        MessageBox.Show("Thêm mới tài khoản thành công", "Thông báo");
                    else
                        MessageBox.Show("Thêm mới tài khoản thất bại", "Thông báo");
                    FillDataGridView();
                }

        }

        //Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TAIKHOAN WHERE TENDANGNHAP='";
            if (dgvDSND.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvDSND.SelectedRows.Count; i++)
                {
                    if (!DatabaseConnection.ExcuteSql(query + dgvDSND.SelectedRows[i].Cells[0].Value + "'"))
                    {
                        MessageBox.Show("Xóa không thành công " + dgvDSND.SelectedRows[i].Cells[0].Value);
                        return;
                    }
                }
            }
            else
            if (GeneralCheck())
            {
                query = "DELETE FROM TAIKHOAN WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
                if (DatabaseConnection.ExcuteSql(query))
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                else
                    MessageBox.Show("Lỗi", "Thông báo");
            }
            FillDataGridView();
        }

        //Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Text = "";
            txtMK.Text = "";
            txtXacNhanMk.Text = "";
            cboQuyen.Text = "";

        }

        private void frmDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
        }
    }
}
