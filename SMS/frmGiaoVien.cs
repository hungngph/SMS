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
    public partial class frmGiaoVien : Form {
        public frmGiaoVien() {
            InitializeComponent();
        }
        private void btnXoa_Click(object sender, EventArgs e) {
            string query = "DELETE FROM GIAOVIEN WHERE MAGV='";
            if (dgvGV.SelectedRows.Count > 0) {
                for (int i = 0; i < dgvGV.SelectedRows.Count; i++) {
                    if (!DatabaseConnection.ExcuteSql(query + dgvGV.SelectedRows[i].Cells[0].Value + "'")) {
                        MessageBox.Show("Xóa không thành công " + dgvGV.SelectedRows[i].Cells[0].Value);
                        return;
                    }
                }
            }
            else
            if (GeneralCheck()) {
                query = "SELECT * FROM GIAOVIEN WHERE MaGV ='" + txtMaGV.Text + "'";
                if (!DatabaseConnection.CheckExist(query)) {
                    MessageBox.Show("Không tồn tại giáo viên này");
                    return;
                }
                query = "DELETE FROM GIAOVIEN WHERE MAGV='" + txtMaGV.Text + "'";
                if (DatabaseConnection.ExcuteSql(query))
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                else
                    MessageBox.Show("Lỗi", "Thông báo");
            }
            FillDataGridView();
        }
        private void frmGiaoVien_Load(object sender, EventArgs e) {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect()) {
                MessageBox.Show("Không kết nối được dữ liệu");
            }
            else
                FillDataGridView();
        }
        void FillDataGridView() {
            string query = "SELECT GIAOVIEN.*, LOP.TENLOP AS TENLOP " +
            "FROM GIAOVIEN LEFT JOIN LOP " +
            "ON GIAOVIEN.MAGV = LOP.MAGVCN";
            dgvGV.DataSource = DatabaseConnection.GetDataTable(query);
        }
        private void btnThemMoi_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM GIAOVIEN WHERE MAGV='" + txtMaGV.Text + "'";
            if (!GeneralCheck())
                return;
            if (DatabaseConnection.CheckExist(query)) {
                MessageBox.Show("Mã giáo viên đã tồn tại");
                return;
            }
            query = "INSERT INTO GIAOVIEN " +
                "VALUES('" + txtMaGV.Text + "'," +
                "N'" + txtHoTen.Text + "'," +
                "N'" + cboGioiTinh.Text + "'," +
                "'" + txtNgSinh.Text + "'," +
                "'" + mtxPhone.Text + "'," +
                "N'" + txtDiaChi.Text + "'," +
                "N'" + txtDanToc.Text + "'," +
                "'" + txtEmail.Text + "'," +
                "N'" + txtChucVu.Text + "'," +
                "'" + txtMon.Text + "')";
            if (DatabaseConnection.ExcuteSql(query)) {
                MessageBox.Show("Thêm thành công", "Thông báo");
                FillDataGridView();
            }
            else {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }
        bool GeneralCheck() {
            bool flag = true;
            if (txtHoTen.Text == "") {
                flag = false;
            }
            else if (cboGioiTinh.Text == "") {
                flag = false;
            }
            else if (txtNgSinh.Text == "") {
                flag = false;
            }
            else if (txtEmail.Text == "") {
                flag = false;
            }
            else if (txtMaGV.Text == "") {
                flag = false;
            }
            else if (txtDanToc.Text == "") {
                flag = false;
            }
            else if (txtDiaChi.Text == "") {
                flag = false;
            }
            else if (mtxPhone.Text == "") {
                flag = false;
            }
            else if (txtChucVu.Text == "") {
                flag = false;
            }
            else if (txtMon.Text == "") {
                flag = false;
            }
            return flag;
        }

        private void btnSua_Click(object sender, EventArgs e) {
            string query = "SELECT * " +
                    "FROM GIAOVIEN " +
                    "WHERE MAGV='" + txtMaGV.Text + "'";
            if (GeneralCheck()) {
                if (!DatabaseConnection.CheckExist(query))
                    MessageBox.Show("Không có giáo viên này", "Thông báo");
                else {
                    query = "UPDATE GIAOVIEN SET " +
                        "HOTEN=N'" + txtHoTen.Text + "'," +
                        "GIOITINH=N'" + cboGioiTinh.Text + "'," +
                        "NGAYSINH='" + txtNgSinh.Text + "'," +
                        "SODIENTHOAI='" + mtxPhone.Text + "'," +
                        "DIACHI=N'" + txtDiaChi.Text + "'," +
                        "DANTOC=N'" + txtDanToc.Text + "'," +
                        "EMAIL='" + txtEmail.Text + "'," +
                        "CHUCVU=N'" + txtChucVu.Text + "'," +
                        "MONGIANGDAY='" + txtMon.Text + "' " +
                        "WHERE MAGV='" + txtMaGV.Text + "'";
                    if (DatabaseConnection.ExcuteSql(query))
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    FillDataGridView();
                }
            }
        }
        private void dgvGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtMaGV.Text = dgvGV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvGV.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgvGV.CurrentRow.Cells[2].Value.ToString();
            txtNgSinh.Text = dgvGV.CurrentRow.Cells[3].Value.ToString();
            mtxPhone.Text = dgvGV.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dgvGV.CurrentRow.Cells[5].Value.ToString();
            txtDanToc.Text = dgvGV.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvGV.CurrentRow.Cells[7].Value.ToString();
            txtChucVu.Text = dgvGV.CurrentRow.Cells[8].Value.ToString();
            txtMon.Text = dgvGV.CurrentRow.Cells[9].Value.ToString();
            txtLop.Text = dgvGV.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e) {
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            cboGioiTinh.Text = "";
            txtNgSinh.Text = "";
            mtxPhone.Text = "";
            txtDiaChi.Text = "";
            txtDanToc.Text = "";
            txtEmail.Text = "";
            txtChucVu.Text = "";
            txtMon.Text = "";
            txtLop.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e) {
            string query = "SELECT GIAOVIEN.*, LOP.TENLOP AS TENLOP " +
            "FROM GIAOVIEN LEFT JOIN LOP " +
            "ON GIAOVIEN.MAGV = LOP.MAGVCN " +
            "WHERE ";
            string query2 = "SELECT GIAOVIEN.*, LOP.TENLOP AS TENLOP " +
            "FROM GIAOVIEN LEFT JOIN LOP " +
            "ON GIAOVIEN.MAGV = LOP.MAGVCN " +
            "WHERE ";
            if (txtMaGV.Text != "") 
                query += "MAGV='" + txtMaGV.Text + "' AND ";
            if (txtHoTen.Text != "")
                query += "HOTEN=N'" + txtHoTen.Text + "' AND ";
            if (cboGioiTinh.Text != "")
                query += "GIOITINH=N'" + cboGioiTinh.Text + "' AND ";
            if (txtNgSinh.Text != "")
                query += "NGAYSINH='" + txtNgSinh.Text + "' AND ";
            //if (mtxPhone.Text != "            ")
            //    query += "SODIENTHOAI='" + mtxPhone.Text + "' AND ";
            if (txtDiaChi.Text != "")
                query += "DIACHI=N'" + txtDiaChi.Text + "' AND ";
            if (txtDanToc.Text != "")
                query += "DANTOC=N'" + txtDanToc.Text + "' AND ";
            if (txtEmail.Text != "")
                query += "EMAIL='" + txtEmail.Text + "' AND ";
            if (txtMon.Text != "")
                query += "MONGIANGDAY='" + txtMon.Text + "' AND ";
            if (txtChucVu.Text != "")
                query += "CHUCVU=N'" + txtChucVu.Text + "' AND ";
            else
                query += "CHUCVU LIKE '%'";   
            if (query2 == query)
                return;
            dgvGV.DataSource = null;
            dgvGV.DataSource = DatabaseConnection.GetDataTable(query);
        }
    }
}
