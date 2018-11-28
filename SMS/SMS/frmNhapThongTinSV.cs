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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //// Câu lệnh truy vấn Table KHOA
            //string strSelect = "Select * From KHOA Where MAKHOA = '" + txtMaMH.Text + "'";
            //if (GeneralCheck())
            //{
            //    if (DatabaseConnection.CheckExist(strSelect))
            //    {
            //        MessageBox.Show("Mã khoa đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtMaMH.Focus();
            //        txtMaMH.SelectAll();
            //    }
            //    else
            //    {
            //        // Câu lệnh insert dữ liệu
            //        string strInsert = "Insert into MONHOC values ('";
            //        strInsert += txtMaMH.Text + "', N'";
            //        strInsert += txtTenMH.Text + "', '";
            //        strInsert += txtTinChi.Text + "')";
            //        //
            //        if (DatabaseConnection.ExcuteSql(strInsert))
            //            MessageBox.Show("Thêm Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        else
            //            MessageBox.Show("Thêm Khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        FillDataGridView();
            //    }
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (dgvMH.SelectedRows.Count > 0)
            //{
            //    if (GeneralCheck())
            //    {
            //        string strUpdate = "Update MONHOC Set MAMH = '" + txtMaMH.Text + "', ";
            //        strUpdate += "TENMH = N'" + txtTenMH.Text + "', ";
            //        strUpdate += "SOTINCHI = '" + txtTinChi.Text + "' "; ;
            //        strUpdate += "Where MAMH = '" + txtMaMH.Text + "'";
            //        //
            //        if (DatabaseConnection.ExcuteSql(strUpdate))
            //            MessageBox.Show("Chỉnh sửa Môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        else
            //            MessageBox.Show("Chỉnh sửa Môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        FillDataGridView();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa chọn Môn học cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (dgvMH.SelectedRows.Count > 0)
            //{
            //    if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        string strDelete = "Delete from MONHOC Where MAMH = '";
            //        {
            //            for (int i = 0; i < dgvMH.SelectedRows.Count; i++)
            //                if (!DatabaseConnection.ExcuteSql(strDelete + dgvMH.SelectedRows[i].Cells[0].Value + "'"))
            //                {
            //                    MessageBox.Show("Không thể xóa Môn học có mã khoa " + dgvMH.SelectedRows[i].Cells[0].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                    continue;
            //                }
            //            FillDataGridView();
            //            MessageBox.Show("Xóa Môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa chọn Môn học cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //txtMaMH.ReadOnly = false;
            //// Làm trắng lại các ô textbox
            //txtMaMH.Text = "";
            //txtTenMH.Text = "";
            //txtTinChi.Text = "";
            //txtTenMH.Focus();
        }

        // Hiển thị csdl vào datagridview
        private void FillDataGridView()
        {
            string query = "SELECT * FROM SINHVIEN";
            dgvSV.DataSource = DatabaseConnection.GetDataTable(query);

            //// Chỉnh sửa kích thước các cột
            //dgvSV.Columns[0].Width = dgvSV.Width / 4;
            //dgvSV.Columns[1].Width = dgvSV.Width / 2;
            //dgvSV.Columns[2].Width = dgvSV.Width / 4;
        }

        // Kiểm tra có textbox nào chưa nhập dữ liệu hay không
        bool GeneralCheck()
        {
            return true;
            //bool flag = true;
            //if (txtTenMH.Text == "")
            //{
            //    txtTenMH.Focus();
            //    flag = false;
            //    // Provider
            //}
            //else if (txtMaMH.Text == "")
            //{
            //    txtMaMH.Focus();
            //    flag = false;
            //    //Provider
            //}
            //else if (txtTinChi.Text == "")
            //{
            //    txtTinChi.Focus();
            //    flag = false;
            //    //Provider
            //}
            //return flag;
        }

        // Xử lí sự kiện click chuột vào phần tử trong DataGridView
        private void dgvSV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMSSV.Text = dgvSV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvSV.CurrentRow.Cells[1].Value.ToString();

            txtDiaChi.Text = dgvSV.CurrentRow.Cells[3].Value.ToString();
            if (dgvSV.CurrentRow.Cells[4].Value.ToString() == "Nam")
                cboGioiTinh.Text = "Nam";
            else
                cboGioiTinh.Text = "Nữ";
            mskPhone.Text = dgvSV.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgvSV.CurrentRow.Cells[6].Value.ToString();
            txtMaLop.Text = dgvSV.CurrentRow.Cells[7].Value.ToString();
            txtKhoaHoc.Text = dgvSV.CurrentRow.Cells[8].Value.ToString();
            txtMSSV.ReadOnly = true; // Không cho phép sửa Mã môn học
            txtMSSV.Visible = true;
        }
    }
}
