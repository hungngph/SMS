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

namespace SMS
{
    public partial class frmNhapMonHoc : Form
    {

        public frmNhapMonHoc()
        {
            InitializeComponent();
        }

        private void frmNhapMonHoc_Load(object sender, EventArgs e)
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
            string strSelect = "Select * From MONHOC Where MAMH = '" + txtMaMH.Text + "'";
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("Mã môn học đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaMH.Focus();
                    txtMaMH.SelectAll();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Insert into MONHOC values ('";
                    strInsert += txtMaMH.Text + "', N'";
                    strInsert += txtTenMH.Text + "', '";
                    strInsert += txtTinChi.Text + "')";
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                        MessageBox.Show("Thêm Môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm Môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }

        // Xử lí sự kiện btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMH.SelectedRows.Count > 0)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Update MONHOC Set TENMH = N'" + txtTenMH.Text + "', ";
                    strUpdate += "SOTINCHI = '" + txtTinChi.Text + "' "; ;
                    strUpdate += "Where MAMH = '" + txtMaMH.Text + "'";
                    //
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                        MessageBox.Show("Chỉnh sửa Môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chỉnh sửa Môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Môn học cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Xử lí sự kiện btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMH.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strDelete = "Delete from MONHOC Where MAMH = '";                 
                    {
                        for (int i = 0; i < dgvMH.SelectedRows.Count; i++)
                            if (!DatabaseConnection.ExcuteSql(strDelete + dgvMH.SelectedRows[i].Cells[0].Value + "'"))
                            {
                                MessageBox.Show("Không thể xóa Môn học có mã khoa " + dgvMH.SelectedRows[i].Cells[0].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                        FillDataGridView();
                        MessageBox.Show("Xóa Môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Môn học cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        

        // Xử lí sự kiện btnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMH.ReadOnly = false;
            // Làm trắng lại các ô textbox
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtTinChi.Text = "";
            txtTenMH.Focus();
        }

        // Hiển thị csdl vào datagridview
        private void FillDataGridView()
        {
            string query = "SELECT * FROM MONHOC";
            dgvMH.DataSource = DatabaseConnection.GetDataTable(query);

            // Chỉnh sửa kích thước các cột
            dgvMH.Columns[0].Width = dgvMH.Width / 4;
            dgvMH.Columns[1].Width = dgvMH.Width / 2;
            dgvMH.Columns[2].Width = dgvMH.Width / 4;
        }

        // Kiểm tra có textbox nào chưa nhập dữ liệu hay không
        bool GeneralCheck()
        {
            bool flag = true;
            if (txtTenMH.Text == "")
            {
                txtTenMH.Focus();
                flag = false;
                // Provider
            }
            else if (txtMaMH.Text == "")
            {
                txtMaMH.Focus();
                flag = false;
                //Provider
            }
            else if (txtTinChi.Text == "")
            {
                txtTinChi.Focus();
                flag = false;
                //Provider
            }
            return flag;
        }

        // Xử lí sự kiện click chuột vào phần tử trong DataGridView
        private void dgvMH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaMH.Text = dgvMH.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dgvMH.CurrentRow.Cells[1].Value.ToString();            
            txtTinChi.Text = dgvMH.CurrentRow.Cells[2].Value.ToString();
            txtMaMH.ReadOnly = true; // Không cho phép sửa Mã môn học
            txtMaMH.Visible = true;
        }
    }
}
