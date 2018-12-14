using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SMS
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        //Sử dụng thư viện
        //using System.Runtime.InteropServices;
        //để di chuyển frm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmGiaoVien_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
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
            // Câu lệnh truy vấn Table HOCSINH
            string strSelect = "Select * From GIAOVIEN Where MAGV = '" + txtMaGV.Text + "'";
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("Mã GV đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaGV.Focus();
                    //txtMaGV.Select();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Set Dateformat dmy Insert into GIAOVIEN values ('";
                    strInsert += txtMaGV.Text + "', N'";
                    strInsert += txtHoTen.Text + "', N'";
                    strInsert += cboGioiTinh.Text + "', '";
                    strInsert += dtpNgaySinh.Text + "', '";
                    strInsert += txtSDT.Text + "', N'";
                    strInsert += txtDiaChi.Text + "', N'";
                    strInsert += txtDanToc.Text + "', '";
                    strInsert += txtEmail.Text + "', N'";
                    strInsert += txtChucVu.Text + "')";
                    MessageBox.Show(strInsert);
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                    {
                        MessageBox.Show("Thêm Giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaGV.Enabled = false;
                    }
                    else
                        MessageBox.Show("Thêm Giáo viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

            if (dgvGV.SelectedRows.Count == 1)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Set Dateformat dmy Update GIAOVIEN Set HOTEN = N'" + txtHoTen.Text + "', ";
                    strUpdate += "GIOITINH = N'" + cboGioiTinh.Text + "', ";
                    strUpdate += "NGAYSINH = '" + txtNgaySinh.Text + "', ";
                    strUpdate += "EMAIL = '" + txtEmail.Text + "', ";
                    strUpdate += "DANTOC = N'" + txtDanToc.Text + "', ";
                    strUpdate += "DIACHI = N'" + txtDiaChi.Text + "', ";
                    strUpdate += "SODIENTHOAI = '" + txtSDT.Text + "', ";
                    strUpdate += "CHUCVU = N'" + txtChucVu.Text + "' ";
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
            errorProvider1.Clear();
            txtMaGV.Enabled = true;
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            cboGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtDanToc.Text = "";
            txtEmail.Text = "";
            txtChucVu.Text = "";
            txtLop.Text = "";
            txtMon.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "set dateformat dmy SELECT GIAOVIEN.*, LOP.TENLOP AS TENLOP " +
            "FROM GIAOVIEN LEFT JOIN LOP " +
            "ON GIAOVIEN.MAGV = LOP.MAGVCN " +
            "WHERE ";
            string query2 = "set dateformat dmy SELECT GIAOVIEN.*, LOP.TENLOP AS TENLOP " +
            "FROM GIAOVIEN LEFT JOIN LOP " +
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
            if (txtSDT.Text != "")
                query += "SODIENTHOAI='" + txtSDT.Text + "' AND ";
            if (txtDiaChi.Text != "")
                query += "DIACHI=N'" + txtDiaChi.Text + "' AND ";
            if (txtDanToc.Text != "")
                query += "DANTOC=N'" + txtDanToc.Text + "' AND ";
            if (txtEmail.Text != "")
                query += "EMAIL='" + txtEmail.Text + "' AND ";
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
            string query = "SELECT MAGV AS [Mã GV], HOTEN AS [Họ tên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], "
            + "SODIENTHOAI AS [Số điện thoại], DIACHI AS [Địa chỉ], DANTOC AS [Dân tộc], EMAIL AS [Email], "
            + "CHUCVU AS [Chức vụ], LOP.TENLOP AS [Lớp Chủ Nhiệm] " +
            "FROM GIAOVIEN LEFT JOIN LOP " +
            "ON GIAOVIEN.MAGV = LOP.MAGVCN";
            dgvGV.DataSource = DatabaseConnection.GetDataTable(query);
            // Chỉnh sửa kích thước các cột
        }


        private void dgvGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            errorProvider1.Clear();
            txtMaGV.Text = dgvGV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvGV.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgvGV.CurrentRow.Cells[2].Value.ToString();
            txtNgaySinh.Text = dgvGV.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = dgvGV.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dgvGV.CurrentRow.Cells[5].Value.ToString();
            txtDanToc.Text = dgvGV.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvGV.CurrentRow.Cells[7].Value.ToString();
            txtChucVu.Text = dgvGV.CurrentRow.Cells[8].Value.ToString();
            txtLop.Text = dgvGV.CurrentRow.Cells[9].Value.ToString();
            txtMaGV.Enabled = false;
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

        private void dtpNgaySinh_onValueChanged(object sender, EventArgs e)
        {
            
            txtNgaySinh.Text = dtpNgaySinh.Text;
        }

        bool GeneralCheck()
        {
            errorProvider1.Clear();
            bool flag = true;
            if (txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                flag = false;
                // Provider
                errorProvider1.SetError(txtHoTen, "Không được bỏ trống vùng này");
            }
            if (cboGioiTinh.Text == "")
            {
                cboGioiTinh.Focus();
                flag = false;
                // provider
                errorProvider1.SetError(cboGioiTinh, "Không được bỏ trống vùng này");
            }
            if (txtNgaySinh.Text == "")
            {
                txtNgaySinh.Focus();
                flag = false;
                // provider
                errorProvider1.SetError(dtpNgaySinh, "Không được bỏ trống vùng này");
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                flag = false;
                // provider
                errorProvider1.SetError(txtEmail, "Không được bỏ trống vùng này");
            }
            if (txtMaGV.Text == "")
            {
                txtMaGV.Focus();
                flag = false;
                // provider
                errorProvider1.SetError(txtMaGV, "Không được bỏ trống vùng này");
            }
            if (txtDanToc.Text == "")
            {
                txtDanToc.Focus();
                flag = false;
                // provider
                errorProvider1.SetError(txtDanToc, "Không được bỏ trống vùng này");
            }
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Focus();
                flag = false;
                // provider
                errorProvider1.SetError(txtDiaChi, "Không được bỏ trống vùng này");
            }
            if (txtSDT.Text == "")
            {
                txtSDT.Focus();
                flag = false;
                // provider
                errorProvider1.SetError(txtSDT, "Không được bỏ trống vùng này");
            }
            if (txtChucVu.Text == "")
            {
                txtChucVu.Focus();
                flag = false;
                // provider
                errorProvider1.SetError(txtChucVu, "Không được bỏ trống vùng này");
            }
            return flag;
        }
    }
}
