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
    public partial class frmNhapThongTinSV : Form
    {
        public frmNhapThongTinSV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhapThongTinSV_Load(object sender, EventArgs e)
        {
            // Kết nối Database SQL Server
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            // Hiển thị csdl vào datagridview
            FillDataGridView();
        }

        // Xử lí sự kiện btnThemMoi_Click
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Câu lệnh truy vấn Table SINHVIEN
            string strSelect = "Select * From SINHVIEN Where MASV = '" + txtMSSV.Text + "'";
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("MSSV đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMSSV.Focus();
                    txtMSSV.SelectAll();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Set Dateformat dmy Insert into SINHVIEN values ('";
                    strInsert += txtMSSV.Text + "', N'";
                    strInsert += txtHoTen.Text + "', '";
                    strInsert += dtpNgaySinh.Text + "', N'";
                    strInsert += txtDiaChi.Text + "', N'";
                    if(chkNam.Checked)
                        strInsert += chkNam.Text + "', '";
                    else
                        strInsert += chkNu.Text + "', '";
                    strInsert += mskPhone.Text + "', '";
                    strInsert += txtEmail.Text + "', '";
                    strInsert += txtMaLop.Text + "', ";
                    strInsert += txtKhoaHoc.Text + ", ";
                    strInsert += "NULL)";
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                        MessageBox.Show("Thêm Sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm Sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }

        // Xử lí sự kiện btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count > 0)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Set Dateformat dmy Update SINHVIEN Set TENSV = N'" + txtHoTen.Text + "', ";
                    strUpdate += "NGAYSINH = '" + dtpNgaySinh.Text + "', ";
                    strUpdate += "DIACHI = N'" + txtDiaChi.Text + "', ";
                    if(chkNam.Checked)
                        strUpdate += "GIOITINH = '" + chkNam.Text + "', ";
                    else
                        strUpdate += "GIOITINH = N'" + chkNu.Text + "', ";
                    strUpdate += "SODIENTHOAI = '" + mskPhone.Text + "', ";
                    strUpdate += "EMAIL = '" + txtEmail.Text + "', "; 
                    strUpdate += "MALOP = '" + txtMaLop.Text + "', ";
                    strUpdate += "KHOAHOC = " + txtKhoaHoc.Text + " ";
                    strUpdate += "Where MASV = '" + txtMSSV.Text + "'";
                    //
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                        MessageBox.Show("Chỉnh sửa Sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chỉnh sửa Sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Sinh viên cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Xử lí sự kiện btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strDelete = "Delete from SINHVIEN Where MASV = '";
                    {
                        for (int i = 0; i < dgvSV.SelectedRows.Count; i++)
                            if (!DatabaseConnection.ExcuteSql(strDelete + dgvSV.SelectedRows[i].Cells[0].Value + "'"))
                            {
                                MessageBox.Show("Không thể xóa Sinh viên có MSSV " + dgvSV.SelectedRows[i].Cells[0].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                        FillDataGridView();
                        MessageBox.Show("Xóa Sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Sinh viên cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Xử lí sự kiện btnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMSSV.ReadOnly = false;
            // Làm trắng lại các ô textbox
            txtMSSV.Text = "";
            txtMaLop.Text = "";
            txtKhoaHoc.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            chkNam.Checked = false;
            chkNu.Checked = false;
            dtpNgaySinh.Text = "";
            mskPhone.Text = "";
            txtHoTen.Focus();
        }

        // Hiển thị csdl vào datagridview
        private void FillDataGridView()
        {
            string query = "SELECT * FROM SINHVIEN";
            dgvSV.DataSource = DatabaseConnection.GetDataTable(query);

            //// Chỉnh sửa kích thước các cột
            dgvSV.Columns[0].Width = dgvSV.Width / 10 * 2 / 3;
            dgvSV.Columns[1].Width = dgvSV.Width / 10 * 3 / 2;
            dgvSV.Columns[2].Width = dgvSV.Width / 10 * 2 / 3;
            dgvSV.Columns[3].Width = dgvSV.Width / 10 * 2 / 3;
            dgvSV.Columns[4].Width = dgvSV.Width / 10 * 2 / 3;
            dgvSV.Columns[5].Width = dgvSV.Width / 10;
            dgvSV.Columns[6].Width = dgvSV.Width / 10 * 3 / 2;
            dgvSV.Columns[7].Width = dgvSV.Width / 10 * 2 / 3;
            dgvSV.Columns[8].Width = dgvSV.Width / 10 * 2 / 3;
            dgvSV.Columns[9].Width = dgvSV.Width / 10;
        }

        // Kiểm tra có textbox nào chưa nhập dữ liệu hay không
        bool GeneralCheck()
        {
            bool flag = true;
            if (txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                flag = false;
                // Provider
            }
            else if (!(chkNam.Checked || chkNu.Checked))
            {
                flag = false;
                //Provider
            }
            else if (mskPhone.Text == "")
            {
                mskPhone.Focus();
                flag = false;
                //Provider
            }
            else if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                flag = false;
                //Provider
            }
            else if (txtMSSV.Text == "")
            {
                txtMSSV.Focus();
                flag = false;
                //Provider
            }
            else if (txtMaLop.Text == "")
            {
                txtMaLop.Focus();
                flag = false;
                //Provider
            }
            else if (txtKhoaHoc.Text == "")
            {
                txtKhoaHoc.Focus();
                flag = false;
                //Provider
            }
            else if (txtDiaChi.Text == "")
            {
                txtDiaChi.Focus();
                flag = false;
                //Provider
            }
            return flag;
        }

        // Xử lí sự kiện click chuột vào phần tử trong DataGridView
        private void dgvSV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMSSV.Text = dgvSV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvSV.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvSV.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvSV.CurrentRow.Cells[3].Value.ToString();
            if (dgvSV.CurrentRow.Cells[4].Value.ToString() == "Nam")
            {
                chkNam.Checked = true;
                chkNu.Checked = false;
            }
                
            else
            {
                chkNam.Checked = false;
                chkNu.Checked = true;
            }          
            mskPhone.Text = dgvSV.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgvSV.CurrentRow.Cells[6].Value.ToString();
            txtMaLop.Text = dgvSV.CurrentRow.Cells[7].Value.ToString();
            txtKhoaHoc.Text = dgvSV.CurrentRow.Cells[8].Value.ToString();
            txtMSSV.ReadOnly = true; // Không cho phép sửa Mã môn học
            txtMSSV.Visible = true;
        }
    }
}
