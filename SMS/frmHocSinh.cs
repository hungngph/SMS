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
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {

            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
            // Load dữ liệu MALOP vào cboMALOP
            Load_combobox();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Câu lệnh truy vấn Table HOCSINH
            string strSelect = "Select * From HOCSINH Where MAHS = '" + txtMSHS.Text + "'";
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("MSHS đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMSHS.Focus();
                    txtMSHS.SelectAll();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Set Dateformat dmy Insert into HOCSINH values ('";
                    strInsert += txtMSHS.Text + "', N'";
                    strInsert += txtHoTen.Text + "', '";
                    strInsert += cboMaLop.Text + "', ";
                    strInsert += txtKhoa.Text + ", '";
                    strInsert += dtpNgaySinh.Text + "', N'";
                    strInsert += cboGioiTinh.Text + "', N'";
                    strInsert += txtDiaChi.Text + "', ";
                    if (txtHoTenCha.Text != "")
                        strInsert += "N'" + txtHoTenCha.Text + "', ";
                    else
                        strInsert += "NULL, ";
                    if (txtHoTenMe.Text != "")
                        strInsert += "N'" + txtHoTenMe.Text + "', ";
                    else
                        strInsert += "NULL, ";
                    if (mtxSDTCha.Text != "")
                        strInsert += "'" + mtxSDTCha.Text + "', ";
                    else
                        strInsert += "NULL, ";
                    if (mtxSDTMe.Text != "")
                        strInsert += "'" + mtxSDTMe.Text + "', ";
                    else
                        strInsert += "NULL, ";
                    strInsert += "N'" + txtDanToc.Text + "', ";
                    if (txtEmail.Text != "")
                        strInsert += "'" + txtEmail.Text + "', ";
                    else
                        strInsert += "NULL, ";
                    if (mtxSDT.Text != "")
                        strInsert += "'" + mtxSDTMe.Text + "') ";
                    else
                        strInsert += "NULL)";
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                    {
                        MessageBox.Show("Thêm Học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMSHS.ReadOnly = true;
                    }
                    else
                        MessageBox.Show("Thêm Học sinh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHS.SelectedRows.Count > 0)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Set Dateformat dmy Update HOCSINH Set HOTEN = N'" + txtHoTen.Text + "', ";
                    strUpdate += "GIOITINH = N'" + cboGioiTinh.Text + "', ";
                    strUpdate += "NGAYSINH = '" + txtNgaySinh.Text + "', ";
                    strUpdate += "KHOAHOC = " + txtKhoa.Text + ", ";
                    strUpdate += "MALOP = '" + cboMaLop.Text + "', ";
                    strUpdate += "DANTOC = N'" + txtDanToc.Text + "', ";
                    strUpdate += "DIACHI = N'" + txtDiaChi.Text + "', ";
                    if (mtxSDT.Text != "")
                        strUpdate += "DIENTHOAI = '" + mtxSDT.Text + "', ";
                    else
                        strUpdate += "DIENTHOAI = NULL, ";
                    if (txtEmail.Text != "")
                        strUpdate += "EMAIL = '" + txtEmail.Text + "', ";
                    else
                        strUpdate += "EMAIL = NULL, ";
                    if (txtHoTenCha.Text != "")
                        strUpdate += "HOTENCHA = N'" + txtHoTenCha.Text + "', ";
                    else
                        strUpdate += "HOTENCHA = NULL, ";
                    if (txtHoTenMe.Text != "")
                        strUpdate += "HOTENME = N'" + txtHoTenMe.Text + "', ";
                    else
                        strUpdate += "HOTENME = NULL, ";
                    if (mtxSDTCha.Text != "")
                        strUpdate += "SDTCHA = '" + mtxSDTCha.Text + "', ";
                    else
                        strUpdate += "SDTCHA = NULL, ";
                    if (mtxSDTMe.Text != "")
                        strUpdate += "SDTME = '" + mtxSDTMe.Text + "' ";
                    else
                        strUpdate += "SDTME = NULL, ";
                    strUpdate += "Where MAHS = '" + txtMSHS.Text + "'";
                    //
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                        MessageBox.Show("Chỉnh sửa Học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chỉnh sửa Học sinh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Học sinh cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHS.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strDelete = "Delete from HOCSINH Where MAHS = '";
                    {
                        for (int i = 0; i < dgvHS.SelectedRows.Count; i++)
                            if (!DatabaseConnection.ExcuteSql(strDelete + dgvHS.SelectedRows[i].Cells[0].Value + "'"))
                            {
                                MessageBox.Show("Không thể xóa Hoc sinh có MSHS " + dgvHS.SelectedRows[i].Cells[0].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                        FillDataGridView();
                        MessageBox.Show("Xóa học sinh thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Học sinh cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMSHS.ReadOnly = false;
            // Làm trắng lại các ô textbox
            txtHoTen.Text = "";
            cboGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtKhoa.Text = "";
            cboMaLop.Text = "";
            txtMSHS.Text = "";
            txtDanToc.Text = "";
            txtDiaChi.Text = "";
            mtxSDT.Text = "";
            txtEmail.Text = "";
            txtHoTenMe.Text = "";
            txtHoTenCha.Text = "";
            mtxSDTCha.Text = "";
            mtxSDTMe.Text = "";
            txtHoTen.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s1 = "Set dateformat dmy Select * From HOCSINH Where ";
            string strSelect = "Set dateformat dmy Select * From HOCSINH Where ";
            if (txtMSHS.Text != "")
                strSelect += "MAHS = '" + txtMSHS.Text + "'and ";
            if (txtHoTen.Text != "")
                strSelect += "HOTEN LIKE N'%" + txtHoTen.Text + "' and ";
            if (cboGioiTinh.Text != "")
                strSelect += "GIOITINH = N'" + cboGioiTinh.Text + "' and ";
            if (txtNgaySinh.Text != "")
                strSelect += "NGAYSINH = '" + txtNgaySinh.Text + "' and ";
            if (txtKhoa.Text != "")
                strSelect += "KHOAHOC = " + txtKhoa.Text + " and ";
            if (cboMaLop.Text != "")
                strSelect += "MALOP = '" + cboMaLop.Text + "' and ";
            if (txtDanToc.Text != "")
                strSelect += "DANTOC = N'" + txtDanToc.Text + "' and ";
            if (txtDiaChi.Text != "")
                strSelect += "DIACHI = N'" + txtDiaChi.Text + "' and ";
            if (mtxSDT.Text != "         ")
                strSelect += "DIENTHOAI = '" + mtxSDT.Text + "' and ";
            if (txtEmail.Text != "")
                strSelect += "EMAIL = '" + txtEmail.Text + "' and ";
            if (txtHoTenCha.Text != "")
                strSelect += "HOTENCHA = N'" + txtHoTenCha.Text + "' and ";
            if (txtHoTenMe.Text != "")
                strSelect += "HOTENME = N'" + txtHoTenMe.Text + "' and ";
            if (mtxSDTCha.Text != "         ")
                strSelect += "SDTCHA = '" + mtxSDTCha.Text + "' and ";
            if (mtxSDTMe.Text != "         ")
                strSelect += "SDTME = '" + mtxSDTMe.Text + "' and";
            if (s1 == strSelect)
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FillDataGridView();
            }
            else
            {
                strSelect = strSelect.Substring(0, strSelect.Length - 4);
                if (DatabaseConnection.GetDataTable(strSelect).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    dgvHS.DataSource = DatabaseConnection.GetDataTable(strSelect);
            }
        }

        private void FillDataGridView()
        {
            string query = "SELECT * FROM HOCSINH";
            dgvHS.DataSource = DatabaseConnection.GetDataTable(query);
            //// Chỉnh sửa kích thước các cột
            dgvHS.Columns[0].Width = dgvHS.Width / 14;
            dgvHS.Columns[1].Width = dgvHS.Width / 14 * 5 / 2;
            dgvHS.Columns[2].Width = dgvHS.Width / 14;
            dgvHS.Columns[3].Width = dgvHS.Width / 14;
            dgvHS.Columns[4].Width = dgvHS.Width / 14 * 3 / 2;
            //dgvHS.Columns[5].Width = dgvHS.Width / 14;
            //dgvHS.Columns[6].Width = dgvHS.Width / 14;
            //dgvHS.Columns[7].Width = dgvHS.Width / 14;
            //dgvHS.Columns[8].Width = dgvHS.Width / 14;
            //dgvHS.Columns[9].Width = dgvHS.Width / 14;
            //dgvHS.Columns[10].Width = dgvHS.Width / 14;
            //dgvHS.Columns[11].Width = dgvHS.Width / 14;
            //dgvHS.Columns[12].Width = dgvHS.Width / 14;
            //dgvHS.Columns[13].Width = dgvHS.Width / 14;
            // adapter.Dispose();
        }

        bool GeneralCheck()
        {
            bool flag = true;
            if (txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                flag = false;
                //provider
            }
            if (cboGioiTinh.Text == "")
            {
                cboGioiTinh.Focus();
                flag = false;
                //provider
            }
            if (txtNgaySinh.Text == "")
            {
                txtNgaySinh.Focus();
                flag = false;
                //provider
            }
            if (txtKhoa.Text == "")
            {
                txtKhoa.Focus();
                flag = false;
                //provider
            }
            if (cboMaLop.Text == "")
            {
                cboMaLop.Focus();
                flag = false;
                //provider
            }
            if (txtMSHS.Text == "")
            {
                txtMSHS.Focus();
                flag = false;
                //provider
            }
            if (txtDanToc.Text == "")
            {
                txtDanToc.Focus();
                flag = false;
                //provider
            }
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Focus();
                flag = false;
                //provider
            }
            return flag;
        }

        private void dgvHS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMSHS.Text = dgvHS.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvHS.CurrentRow.Cells[1].Value.ToString();
            cboMaLop.Text = dgvHS.CurrentRow.Cells[2].Value.ToString();
            txtKhoa.Text = dgvHS.CurrentRow.Cells[3].Value.ToString();
            txtNgaySinh.Text = dgvHS.CurrentRow.Cells[4].Value.ToString();
            cboGioiTinh.Text = dgvHS.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text = dgvHS.CurrentRow.Cells[6].Value.ToString();
            txtHoTenCha.Text = dgvHS.CurrentRow.Cells[7].Value.ToString();
            txtHoTenMe.Text = dgvHS.CurrentRow.Cells[8].Value.ToString();
            mtxSDTCha.Text = dgvHS.CurrentRow.Cells[9].Value.ToString();
            mtxSDTMe.Text = dgvHS.CurrentRow.Cells[10].Value.ToString();
            txtDanToc.Text = dgvHS.CurrentRow.Cells[11].Value.ToString();
            txtEmail.Text = dgvHS.CurrentRow.Cells[12].Value.ToString();
            mtxSDT.Text = dgvHS.CurrentRow.Cells[13].Value.ToString();
            txtMSHS.ReadOnly = true; // Không cho phép sửa Mã học sinh
            txtMSHS.Visible = true;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            txtNgaySinh.Text = dtpNgaySinh.Text;
        }
        void Load_combobox()
        {
            string query = "SELECT * FROM LOP";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.DataSource = dt;
            cboMaLop.Text = "";
        }
    }
}
