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
    public partial class frmNhapLop : Form
    {
        public frmNhapLop()
        {
            InitializeComponent();
        }

        private void frmNhapLop_Load(object sender, EventArgs e)
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
            // Câu lệnh truy vấn Table KHOA
            string strSelect = "Select * From LOPQUANLY Where MALOP = '" + txtMaLop.Text + "'and KHOAHOC = " + txtKhoaHoc.Text;
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("Lớp học đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaLop.Focus();
                    txtMaLop.SelectAll();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Insert into LOPQUANLY values ('";
                    strInsert += txtMaLop.Text + "', ";
                    strInsert += txtKhoaHoc.Text + ", '";
                    strInsert += txtMaKhoa.Text + "', ";
                    strInsert += txtSiSo.Text + ", '";
                    strInsert += txtMaGVQL.Text + "')";
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                        MessageBox.Show("Thêm Lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm Lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }

        // Xử lí sự kiện btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLH.SelectedRows.Count > 0)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Update LOPQUANLY Set MAKHOA = '" + txtMaKhoa.Text + "', ";
                    strUpdate += "MAGVQLY = '" + txtMaGVQL.Text + "', ";
                    strUpdate += "SISO = " + txtSiSo.Text + " ";
                    strUpdate += "Where MALOP = '" + txtMaLop.Text + "' and KHOAHOC = " + txtKhoaHoc.Text;
                    //
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                        MessageBox.Show("Chỉnh sửa Lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chỉnh sửa Lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Lớp học cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Xử lí sự kiện btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLH.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strDelete = "Delete from LOPQUANLY Where MALOP = '";
                    {
                        for (int i = 0; i < dgvLH.SelectedRows.Count; i++)
                            if (!DatabaseConnection.ExcuteSql(strDelete + dgvLH.SelectedRows[i].Cells[0].Value + "' and KHOAHOC = " + dgvLH.SelectedRows[i].Cells[1].Value))
                            {
                                MessageBox.Show("Không thể xóa Lớp học có mã lớp " + dgvLH.SelectedRows[i].Cells[0].Value + ", Khóa: " + dgvLH.SelectedRows[i].Cells[1].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                        FillDataGridView();
                        MessageBox.Show("Xóa Lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Lớp học cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Xử lí sự kiện btnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.ReadOnly = false;
            txtKhoaHoc.ReadOnly = false;
            // Làm trắng lại các ô textbox
            txtMaLop.Text = "";
            txtKhoaHoc.Text = "";
            txtMaKhoa.Text = "";
            txtMaGVQL.Text = "";
            txtSiSo.Text = "";
            txtMaLop.Focus();
        }

        // Hiển thị csdl vào datagridview
        private void FillDataGridView()
        {
            string query = "SELECT * FROM LOPQUANLY";
            dgvLH.DataSource = DatabaseConnection.GetDataTable(query);

            // Chỉnh sửa kích thước các cột
            //dgvMH.Columns[0].Width = dgvMH.Width / 4;
            //dgvMH.Columns[1].Width = dgvMH.Width / 2;
            //dgvMH.Columns[2].Width = dgvMH.Width / 4;
        }

        // Kiểm tra có textbox nào chưa nhập dữ liệu hay không
        bool GeneralCheck()
        {
            bool flag = true;
            if (txtMaLop.Text == "")
            {
                txtMaLop.Focus();
                flag = false;
                // Provider
            }
            else if (txtKhoaHoc.Text == "")
            {
                txtKhoaHoc.Focus();
                flag = false;
                //Provider
            }
            else if (txtMaKhoa.Text == "")
            {
                txtMaKhoa.Focus();
                flag = false;
                //Provider
            }
            else if (txtSiSo.Text == "")
            {
                txtSiSo.Focus();
                flag = false;
                //Provider
            }
            else if (txtMaGVQL.Text == "")
            {
                txtMaGVQL.Focus();
                flag = false;
                //Provider
            }
            

            return flag;
        }

        // Xử lí sự kiện click chuột vào phần tử trong DataGridView
        private void dgvLH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaLop.Text = dgvLH.CurrentRow.Cells[0].Value.ToString();
            txtKhoaHoc.Text = dgvLH.CurrentRow.Cells[1].Value.ToString();
            txtMaKhoa.Text = dgvLH.CurrentRow.Cells[2].Value.ToString();
            txtSiSo.Text = dgvLH.CurrentRow.Cells[3].Value.ToString();
            txtMaGVQL.Text = dgvLH.CurrentRow.Cells[4].Value.ToString();
            txtMaLop.ReadOnly = true; // Không cho phép sửa Mã môn học
            txtKhoaHoc.ReadOnly = true;
            txtMaLop.Visible = true;
        }
    }
}
