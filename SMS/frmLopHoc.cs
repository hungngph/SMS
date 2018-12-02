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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLopHoc_Load(object sender, EventArgs e) {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect()) {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
        }
        void FillDataGridView() {
            string query = "SELECT * " +
                "FROM LOP ";
            dgvLH.DataSource = DatabaseConnection.GetDataTable(query);
            // adapter.Dispose();
        }

        private void btnThemmoi_Click(object sender, EventArgs e) {
            string query = "SELECT * " +
                "FROM LOP " +
                "WHERE MALOP='" + txtMaLop.Text + "'";
            if (GeneralCheck())
                if (DatabaseConnection.CheckExist(query)) {
                    MessageBox.Show("Mã lớp đã tồn tại", "Thông báo");
                    txtMaLop.Focus();
                } 
                else {
                    query = "INSERT INTO LOP(MALOP, TENLOP, MAGVCN, SISO) " +
                        "VALUES('" + txtMaLop.Text + "',N'" + txtTenLop.Text + "','" + txtMaGV.Text + "'," + txtSiSo.Text + ")";
                    if (DatabaseConnection.ExcuteSql(query))
                        MessageBox.Show("Thêm mới lớp thành công", "Thông báo");
                    else
                        MessageBox.Show("Thêm mới lớp thất bại", "Thông báo");
                    FillDataGridView();
                }
        }
        bool GeneralCheck() {
            bool flag = true;
            if (txtMaLop.Text == "") {
                txtMaLop.Focus();
                flag = false;
                // Provider
            }
            else if (txtMaGV.Text == "") {
                txtMaGV.Focus();
                flag = false;
                //Provider
            }
            else if (txtTenLop.Text == "") {
                txtTenLop.Focus();
                flag = false;
                //Provider;
            }
            else if (txtSiSo.Text == "") {
                txtSiSo.Focus();
                flag = false;
                //Provider
            }
            return flag;
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            string query = "DELETE FROM LOP WHERE MALOP='";
            if (dgvLH.SelectedRows.Count > 0) {
                for (int i = 0; i < dgvLH.SelectedRows.Count; i++) {
                    if (!DatabaseConnection.ExcuteSql(query + dgvLH.SelectedRows[i].Cells[0].Value + "'")) {
                        MessageBox.Show("Xóa không thành công " + dgvLH.SelectedRows[i].Cells[0].Value);
                        return;
                    }
                }
            }
            else
            if (GeneralCheck()) {
                query = "DELETE FROM LOP WHERE MALOP='" + txtMaLop.Text + "'";
                if (DatabaseConnection.ExcuteSql(query))
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                else
                    MessageBox.Show("Lỗi", "Thông báo");
            }
            FillDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (GeneralCheck()) {
                string query1 = "SELECT * " +
                    "FROM TAIKHOAN " +
                    "WHERE MALOP='" + txtMaLop.Text + "'";
                if (DatabaseConnection.CheckExist(query1))
                    MessageBox.Show("Không có tài khoản này", "Thông báo");
                else {
                    string query2 = "UPDATE LOP SET " +
                        "TENLOP='" + txtTenLop.Text + "' " +
                        "MAGVCN='" + txtMaGV.Text + "' " +
                        "SISO='" + txtSiSo.Text + "' " +
                        "WHERE MALOP='" + txtMaLop.Text + "'";
                    FillDataGridView();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaGV.Text = "";
            txtSiSo.Text = "";
        }
    }
}
