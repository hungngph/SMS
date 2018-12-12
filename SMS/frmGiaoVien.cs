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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
            }
            else
                FillDataGridView();
            Load_combobox();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            validateHoTen();
            validateGioiTinh();
            validateNgaySinh();
            validateEmail();
            validateMaGV();
            validateDanToc();
            validateDiaChi();
            validateDienThoai();
            validateChucVu();
            validateMonDay();
            // Câu lệnh truy vấn Table HOCSINH
            string strSelect = "Select * From GIAOVIEN Where MAGV = '" + txtMaGV.Text + "'";
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("Mã GV đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaGV.Focus();
                    txtMaGV.SelectAll();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Set Dateformat dmy Insert into GIAOVIEN values ('";
                    strInsert += txtMaGV.Text + "', N'";
                    strInsert += txtHoTen.Text + "', N'";
                    strInsert += cboGioiTinh.Text + "', '";
                    strInsert += dtpNgaySinh.Text + "', '";
                    strInsert += mtxSDT.Text + "', N'";
                    strInsert += txtDiaChi.Text + "', N'";
                    strInsert += txtDanToc.Text + "', '";
                    strInsert += txtEmail.Text + "', N'";
                    strInsert += txtChucVu.Text + "', '";
                    strInsert += cboMon.Text + "')";
                    MessageBox.Show(strInsert);
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                    {
                        MessageBox.Show("Thêm Giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaGV.ReadOnly = true;
                    }
                    else
                        MessageBox.Show("Thêm Giáo viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dgvGV.SelectedRows.Count > 0)
            {
                validateHoTen();
                validateGioiTinh();
                validateNgaySinh();
                validateEmail();
                validateMaGV();
                validateDanToc();
                validateDiaChi();
                validateDienThoai();
                validateChucVu();
                validateMonDay();
                if (GeneralCheck())
                {
                    string strUpdate = "Set Dateformat dmy Update GIAOVIEN Set HOTEN = N'" + txtHoTen.Text + "', ";
                    strUpdate += "GIOITINH = N'" + cboGioiTinh.Text + "', ";
                    strUpdate += "NGAYSINH = '" + txtNgaySinh.Text + "', ";
                    strUpdate += "EMAIL = '" + txtEmail.Text + "', ";
                    strUpdate += "DANTOC = N'" + txtDanToc.Text + "', ";
                    strUpdate += "DIACHI = N'" + txtDiaChi.Text + "', ";
                    strUpdate += "SODIENTHOAI = '" + mtxSDT.Text + "', ";
                    strUpdate += "CHUCVU = N'" + txtChucVu.Text + "', ";
                    strUpdate += "MONGIANGDAY = '" + cboMon.Text + "' ";
                    strUpdate += "Where MAGV = '" + txtMaGV.Text + "'";
                    //
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                        MessageBox.Show("Chỉnh sửa Giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chỉnh sửa Giáo viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Giáo viên cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strDelete = "Delete from GIAOVIEN Where MAGV = '";
                    {
                        for (int i = 0; i < dgvGV.SelectedRows.Count; i++)
                            if (!DatabaseConnection.ExcuteSql(strDelete + dgvGV.SelectedRows[i].Cells[0].Value + "'"))
                            {
                                MessageBox.Show("Không thể xóa Giáo viên có Mã GV " + dgvGV.SelectedRows[i].Cells[0].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                        FillDataGridView();
                        MessageBox.Show("Xóa giáo viên thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Giáo viên cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            cboGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            mtxSDT.Text = "";
            txtDiaChi.Text = "";
            txtDanToc.Text = "";
            txtEmail.Text = "";
            txtChucVu.Text = "";
            cboMon.Text = "";
            txtLop.Text = "";
            txtMon.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "set dateformat dmy SELECT GIAOVIEN.*, LOP.TENLOP AS TENLOP " +
            "FROM GIAOVIEN JOIN LOP " +
            "ON GIAOVIEN.MAGV = LOP.MAGVCN " +
            "WHERE ";
            string query2 = "set dateformat dmy SELECT GIAOVIEN.*, LOP.TENLOP AS TENLOP " +
            "FROM GIAOVIEN JOIN LOP " +
            "ON GIAOVIEN.MAGV = LOP.MAGVCN " +
            "WHERE ";
            if (txtMaGV.Text != "")
                query += "MAGV='" + txtMaGV.Text + "' AND ";
            if (txtHoTen.Text != "")
                query += "HOTEN=N'" + txtHoTen.Text + "' AND ";
            if (cboGioiTinh.Text != "")
                query += "GIOITINH= N'" + cboGioiTinh.Text + "' AND ";
            if (txtNgaySinh.Text != "")
                query += "NGAYSINH='" + txtNgaySinh.Text + "' AND ";
            if (mtxSDT.Text != "         ")
                query += "SODIENTHOAI='" + mtxSDT.Text + "' AND ";
            if (txtDiaChi.Text != "")
                query += "DIACHI=N'" + txtDiaChi.Text + "' AND ";
            if (txtDanToc.Text != "")
                query += "DANTOC=N'" + txtDanToc.Text + "' AND ";
            if (txtEmail.Text != "")
                query += "EMAIL='" + txtEmail.Text + "' AND ";
            if (txtMon.Text != "")
                query += "MONGIANGDAY='" + cboMon.Text + "' AND ";
            if (txtChucVu.Text != "")
                query += "CHUCVU = N'" + txtChucVu.Text + "' AND ";      
            if (query2 == query)
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FillDataGridView();
            }
            else
            {
                query = query.Substring(0, query.Length - 4);
                MessageBox.Show(query);
                if (DatabaseConnection.GetDataTable(query).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    dgvGV.DataSource = DatabaseConnection.GetDataTable(query);
            }
        }


        void FillDataGridView()
        {
            string query = "SELECT GIAOVIEN.*, LOP.TENLOP AS LOPCHUNHIEM " +
            "FROM GIAOVIEN LEFT JOIN LOP " +
            "ON GIAOVIEN.MAGV = LOP.MAGVCN";
            dgvGV.DataSource = DatabaseConnection.GetDataTable(query);
        }
        
        bool GeneralCheck()
        {
            bool flag = true;
            if (txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                flag = false;
            }
            else if (cboGioiTinh.Text == "")
            {
                cboGioiTinh.Focus();
                flag = false;
            }
            else if (txtNgaySinh.Text == "")
            {
                txtNgaySinh.Focus();
                flag = false;
            }
            else if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                flag = false;
            }
            else if (txtMaGV.Text == "")
            {
                txtMaGV.Focus();
                flag = false;
            }
            else if (txtDanToc.Text == "")
            {
                txtDanToc.Focus();
                flag = false;
            }
            else if (txtDiaChi.Text == "")
            {
                txtDiaChi.Focus();
                flag = false;
            }
            else if (mtxSDT.Text == "         ")
            {
                mtxSDT.Focus();
                flag = false;
            }
            else if (txtChucVu.Text == "")
            {
                txtChucVu.Focus();
                flag = false;
            }
            else if (cboMon.Text == "")
            {
                cboMon.Focus();
                flag = false;
            }
            return flag;
        }

        
        private void dgvGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaGV.Text = dgvGV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvGV.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgvGV.CurrentRow.Cells[2].Value.ToString();
            txtNgaySinh.Text = dgvGV.CurrentRow.Cells[3].Value.ToString();
            mtxSDT.Text = dgvGV.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dgvGV.CurrentRow.Cells[5].Value.ToString();
            txtDanToc.Text = dgvGV.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvGV.CurrentRow.Cells[7].Value.ToString();
            txtChucVu.Text = dgvGV.CurrentRow.Cells[8].Value.ToString();
            cboMon.Text = dgvGV.CurrentRow.Cells[9].Value.ToString();
            txtLop.Text = dgvGV.CurrentRow.Cells[10].Value.ToString();
        }

        void Load_combobox()
        {
            string query = "SELECT * FROM MONHOC";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            cboMon.DisplayMember = "MAMH";
            cboMon.DataSource = dt;
            cboMon.Text = "";
        }

        private void cboMon_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT TENMH FROM MONHOC WHERE MAMH = '" + cboMon.Text + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMon.Text == "")
                txtMon.Text = "";
            else
                txtMon.Text = dt.Rows[0][0].ToString();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            txtNgaySinh.Text = dtpNgaySinh.Text;
        }

        //Xác thực đã nhập text
        protected bool validateMaGV()
        {
            bool flag = false;
            if (txtMaGV.Text == "")
            {
                errorProvider1.SetError(txtMaGV, "Chưa nhập mã GV");
                flag = true;
            }
            else
                errorProvider1.SetError(txtMaGV, "");
            return flag;

        }
        protected bool validateHoTen()
        {
            bool flag = false;
            if (txtHoTen.Text == "")
            {
                errorProvider1.SetError(txtHoTen, "Chưa nhập họ tên");
                flag = true;
            }
            else
                errorProvider1.SetError(txtHoTen, "");
            return flag;
        }
        protected bool validateGioiTinh()
        {
            bool flag = false;
            if (cboGioiTinh.Text == "")
            {
                errorProvider1.SetError(cboGioiTinh, "Chưa nhập giới tính");
                flag = true;
            }
            else errorProvider1.SetError(cboGioiTinh, "");
            return flag;
        }
        protected bool validateNgaySinh()
        {
            bool flag = false;
            if (txtNgaySinh.Text == "")
            {
                errorProvider1.SetError(txtNgaySinh, "Chưa nhập ngày sinh");
                flag = true;
            }
            else errorProvider1.SetError(txtNgaySinh, "");
            return flag;
        }//
        protected bool validateEmail()
        {
            bool flag = false;
            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Chưa nhập email");
                flag = true;
            }
            else
                errorProvider1.SetError(txtEmail, "");
            return flag;
        }
        protected bool validateDanToc()
        {
            bool flag = false;
            if (txtDanToc.Text == "")
            {
                errorProvider1.SetError(txtDanToc, "Chưa nhập dân tộc");
                flag = true;
            }
            else errorProvider1.SetError(txtDanToc, "");
            return flag;
        }
        protected bool validateDiaChi()
        {
            bool flag = false;
            if (txtDiaChi.Text == "")
            {
                errorProvider1.SetError(txtDiaChi, "Chưa nhập địa chỉ");
                flag = true;
            }
            else errorProvider1.SetError(txtDiaChi, "");
            return flag;
        }//
        protected bool validateDienThoai()
        {
            bool flag = false;
            if (mtxSDT.Text == "         ")
            {
                errorProvider1.SetError(mtxSDT, "Chưa nhập số điện thoại");
                flag = true;
            }
            else
                errorProvider1.SetError(mtxSDT, "");
            return flag;
        }
        protected bool validateChucVu()
        {
            bool flag = false;
            if (txtHoTen.Text == "")
            {
                errorProvider1.SetError(txtChucVu, "Chưa nhập chức vụ");
                flag = true;
            }
            else
                errorProvider1.SetError(txtChucVu, "");
            return flag;
        }
        protected bool validateMonDay()
        {
            bool flag = false;
            if (cboMon.Text == "")
            {
                errorProvider1.SetError(txtMon, "Chưa nhập môn dạy");
                flag = true;
            }
            else
                errorProvider1.SetError(txtMon, "");
            return flag;

        }
        
    }
}
