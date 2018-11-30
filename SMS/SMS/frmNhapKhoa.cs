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
    public partial class frmNhapKhoa : Form
    {
        public frmNhapKhoa()
        {
            InitializeComponent();
        }

        private void frmNhapKhoa_Load(object sender, EventArgs e)
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

        // Xử lí sự kiện btnThemmoi_Click
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Câu lệnh truy vấn Table KHOA
            string strSelect = "Select * From KHOA Where MAKHOA = '" + txtMaKhoa.Text + "'";
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("Mã khoa đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaKhoa.Focus();
                    txtMaKhoa.SelectAll();
                }
                else
                {
                    // Câu lệnh Insert dữ liệu
                    string strInsert = "Insert into KHOA values ('";
                    strInsert += txtMaKhoa.Text + "', N'";
                    strInsert += txtTenKhoa.Text + "')";
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                        MessageBox.Show("Thêm Khoa thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm Khoa thất bại!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }

        // Xử lí sự kiện btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {            
            if (dgvKhoa.SelectedRows.Count > 0)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Update KHOA Set TENKHOA = N'" + txtTenKhoa.Text + "' ";
                    strUpdate += "Where MAKHOA = '" + txtMaKhoa.Text + "'";
                    //
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                        MessageBox.Show("Chỉnh sửa Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chỉnh sửa Khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khoa cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Xử lí sự kiện btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strDelete = "Delete from KHOA Where MAKHOA = '";                    
                    {
                        for (int i = 0; i < dgvKhoa.SelectedRows.Count; i++)
                            if (!DatabaseConnection.ExcuteSql(strDelete + dgvKhoa.SelectedRows[i].Cells[0].Value + "'"))
                            {
                                MessageBox.Show("Không thể xóa Khoa có mã khoa " + dgvKhoa.SelectedRows[i].Cells[0].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                        FillDataGridView();
                        MessageBox.Show("Xóa Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khoa cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        // Xử lí sự kiện btnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.ReadOnly = false;
            // Làm trắng lại các ô textbox
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtTenKhoa.Focus();
        }

        // Hiển thị csdl vào datagridview
        private void FillDataGridView()
        {
            string query = "SELECT * FROM KHOA";
            dgvKhoa.DataSource = DatabaseConnection.GetDataTable(query);

            // Chỉnh sửa kích thước các cột
            dgvKhoa.Columns[0].Width = dgvKhoa.Width / 4;
            dgvKhoa.Columns[1].Width = dgvKhoa.Width - dgvKhoa.Columns[0].Width - 5;
        }
                
        // Kiểm tra có textbox nào chưa nhập dữ liệu hay không
        bool GeneralCheck()
        {
            bool flag = true;
            if (txtTenKhoa.Text == "")
            {
                txtTenKhoa.Focus();
                flag = false;
                // Provider
            }
            else if (txtMaKhoa.Text == "")
            {
                txtMaKhoa.Focus();
                flag = false;
                //Provider
            }
            return flag;
        }

        // Xử lí sự kiện click chuột vào phần tử trong DataGridView
        private void dgvKhoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaKhoa.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            txtMaKhoa.ReadOnly = true; // Không cho phép sửa Mã Khoa
            txtMaKhoa.Visible = true;
        }
    }
}
