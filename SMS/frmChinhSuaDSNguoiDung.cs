using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMS {
    public partial class frmChinhSuaDSNguoiDung : Form {
        public frmChinhSuaDSNguoiDung() {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
        }
        //Di chuyển form
        Boolean flag; int x, y;

        private void frmChinhSuaDSNguoiDung_MouseDown(object sender, MouseEventArgs e) {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmChinhSuaDSNguoiDung_MouseUp(object sender, MouseEventArgs e) {
            flag = false;
        }
        private void frmChinhSuaDSNguoiDung_MouseMove(object sender, MouseEventArgs e) {
            if (flag == true)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }
        //

        private void btnSua_Click(object sender, EventArgs e) {
            if (GeneralCheck()) {
                string query1 = "SELECT * " +
                    "FROM TAIKHOAN " +
                    "WHERE TENDANGNHAP =" + txtTaikhoan.Text + "'";
                if (DatabaseConnection.CheckExist(query1))
                    MessageBox.Show("Không có tài khoản này", "Thông báo");
                else {
                    string query2 = "UPDATE TAIKHOAN SET " +
                        "MATKHAU='" + txtMK + "' " +
                        "QUYENTRUYCAP='" + cboQuyen + "' " +
                        "WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
                    FillDataGridView();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e) {
            string query = "SELECT * " +
                "FROM TAIKHOAN " +
                "WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
            if (GeneralCheck())
                if (DatabaseConnection.CheckExist(query)) {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo");
                    txtTaikhoan.Focus();
                }
                else {
                    query = "INSERT INTO TAIKHOAN(TENDANGNHAP, MATKHAU, QUYENTRUYCAP) " +
                        "VALUES(N'" + txtTaikhoan.Text + "',N'" + txtMK.Text + "','" + cboQuyen.Text + "')";
                    if (DatabaseConnection.AddRow(query))
                        MessageBox.Show("Thêm mới tài khoản thành công", "Thông báo");
                    else
                        MessageBox.Show("Thêm mới tài khoản thất bại", "Thông báo");
                    FillDataGridView();
                }
        }

        private void frmChinhSuaDSNguoiDung_Load(object sender, EventArgs e) {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect()) {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
        }
        private void btnXoa_Click(object sender, EventArgs e) {
            string query = "DELETE FROM TAIKHOAN WHERE TENDANGNHAP='";
            if (dgvDSND.SelectedRows.Count > 0) {
                for (int i = 0; i < dgvDSND.SelectedRows.Count; i++) {
                    if (!DatabaseConnection.RemoveRow(query + dgvDSND.SelectedRows[i].Cells[0].Value + "'")) {
                        MessageBox.Show("Xóa không thành công " + dgvDSND.SelectedRows[i].Cells[0].Value);
                        return;
                    }
                }
            } else 
            if (GeneralCheck()) {
                query = "DELETE FROM TAIKHOAN WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
                if (DatabaseConnection.RemoveRow(query))
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                else
                    MessageBox.Show("Lỗi", "Thông báo");
            }
            FillDataGridView();
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
                //Provider;
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
    }
}
