﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace SMS
{
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }
        string imgTest;
        //Sử dụng thư viện
        //using System.Runtime.InteropServices;
        //để di chuyển frm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmHocSinh_MouseDown(object sender, MouseEventArgs e)
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

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHocSinhDataSet1.HOCSINH' table. You can move, or remove it, as needed.


            this.WindowState = FormWindowState.Normal;
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            // Load dữ liệu MALOP vào cboMALOP
            Load_combobox();
            if (DatabaseConnection.isAdmin == true)
                FillDataGridView();
            else
            {
                string query = "Select MALOP from LOP Where MAGVCN = '" + DatabaseConnection.MaGV + "'";
                DataTable dt = DatabaseConnection.GetDataTable(query);
                cboMaLop.Text = dt.Rows[0][0].ToString();
                cboMaLop.Enabled = false;
                string strSelect = "SELECT * FROM HOCSINH where MALOP = '" + cboMaLop.Text + "'";
                dgvHS.DataSource = DatabaseConnection.GetDataTable(strSelect);

            }
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
                    //txtMSHS.SelectAll();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Declare @img varbinary(MAX) Set Dateformat dmy Insert into HOCSINH values ('";
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
                    if (txtSDTCha.Text != "")
                        strInsert += "'" + txtSDTCha.Text + "', ";
                    else
                        strInsert += "NULL, ";
                    if (txtSDTMe.Text != "")
                        strInsert += "'" + txtSDTMe.Text + "', ";
                    else
                        strInsert += "NULL, ";
                    strInsert += "N'" + txtDanToc.Text + "', ";
                    if (txtEmail.Text != "")
                        strInsert += "'" + txtEmail.Text + "', ";
                    else
                        strInsert += "NULL, ";
                    if (txtSDT.Text != "")
                        strInsert += "'" + txtSDT.Text + "', @img2)";
                    else
                        strInsert += "NULL, @img2)";

                    byte[] img = null;
                    FileStream fs = new FileStream(imgTest, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    DatabaseConnection.Connected();
                    SqlCommand cmd = new SqlCommand(strInsert, DatabaseConnection.sqlConnection);
                    cmd.Parameters.Add(new SqlParameter("@img2", img));

                    if (DatabaseConnection.ExcuteSql(cmd))
                    {
                        MessageBox.Show("Thêm Học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatabaseConnection.SaveAction("Thêm mới", "HOCSINH");
                        txtMSHS.Enabled = false;
                    }
                    else
                        MessageBox.Show("Thêm Học sinh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dgvHS.SelectedRows.Count == 1)
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
                    if (txtSDT.Text != "")
                        strUpdate += "DIENTHOAI = '" + txtSDT.Text + "', ";
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
                    if (txtSDTCha.Text != "")
                        strUpdate += "SDTCHA = '" + txtSDTCha.Text + "', ";
                    else
                        strUpdate += "SDTCHA = NULL, ";
                    if (txtSDTMe.Text != "")
                        strUpdate += "SDTME = '" + txtSDTMe.Text + "' ";
                    else
                        strUpdate += "SDTME = NULL, ";
                    strUpdate += "Where MAHS = '" + txtMSHS.Text + "'";
                    //
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                    {
                        MessageBox.Show("Chỉnh sửa Học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatabaseConnection.SaveAction("Sua", "HOCSINH");
                    }
                    else
                        MessageBox.Show("Chỉnh sửa Học sinh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                    DatabaseConnection.SaveAction("Chỉnh sửa", "TAIKHOAN");
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
                        DatabaseConnection.SaveAction("Xóa", "HOCSINH");
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
            errorProvider1.Clear();
            txtMSHS.Enabled = true;
            // Làm trắng lại các ô textbox
            txtHoTen.Text = "";
            cboGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtKhoa.Text = "";
            cboMaLop.Text = "";
            txtMSHS.Text = "";
            txtDanToc.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtHoTenMe.Text = "";
            txtHoTenCha.Text = "";
            txtSDTCha.Text = "";
            txtSDTMe.Text = "";
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
            if (txtSDT.Text != "")
                strSelect += "DIENTHOAI = '" + txtSDT.Text + "' and ";
            if (txtEmail.Text != "")
                strSelect += "EMAIL = '" + txtEmail.Text + "' and ";
            if (txtHoTenCha.Text != "")
                strSelect += "HOTENCHA = N'" + txtHoTenCha.Text + "' and ";
            if (txtHoTenMe.Text != "")
                strSelect += "HOTENME = N'" + txtHoTenMe.Text + "' and ";
            if (txtSDTCha.Text != "")
                strSelect += "SDTCHA = '" + txtSDTCha.Text + "' and ";
            if (txtSDTMe.Text != "")
                strSelect += "SDTME = '" + txtSDTMe.Text + "' and";
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
                DatabaseConnection.SaveAction("Tìm kiếm", "GIAOVIEN"); 
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            //Tạo FileName
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "All files|*.*|Excel file|*.xlsx";
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;


            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Xuất dữ liệu";
            //Tạo dữ liệu cho file Excel

            for (int i = 1; i <= dgvHS.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvHS.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvHS.Rows.Count; i++)
                for (int j = 0; j < dgvHS.Columns.Count; j++)
                    worksheet.Cells[i + 2, j + 1] = dgvHS.Rows[i].Cells[j].Value.ToString();
            if (fsave.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(fsave.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing);
            }
            app.Quit();

            MessageBox.Show("Xuất dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
            DatabaseConnection.SaveAction("Xuất dữ liệu", "GIAOVIEN");
        }

        private void FillDataGridView()
        {
            string strSelect = "SELECT * FROM HOCSINH";
            dgvHS.DataSource = DatabaseConnection.GetDataTable(strSelect);
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

        private void dgvHS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            errorProvider1.Clear();
            txtMSHS.Text = dgvHS.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvHS.CurrentRow.Cells[1].Value.ToString();
            cboMaLop.Text = dgvHS.CurrentRow.Cells[2].Value.ToString();
            txtKhoa.Text = dgvHS.CurrentRow.Cells[3].Value.ToString();
            txtNgaySinh.Text = dgvHS.CurrentRow.Cells[4].Value.ToString();
            cboGioiTinh.Text = dgvHS.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text = dgvHS.CurrentRow.Cells[6].Value.ToString();
            txtHoTenCha.Text = dgvHS.CurrentRow.Cells[7].Value.ToString();
            txtHoTenMe.Text = dgvHS.CurrentRow.Cells[8].Value.ToString();
            txtSDTCha.Text = dgvHS.CurrentRow.Cells[9].Value.ToString();
            txtSDTMe.Text = dgvHS.CurrentRow.Cells[10].Value.ToString();
            txtDanToc.Text = dgvHS.CurrentRow.Cells[11].Value.ToString();
            txtEmail.Text = dgvHS.CurrentRow.Cells[12].Value.ToString();
            txtSDT.Text = dgvHS.CurrentRow.Cells[13].Value.ToString();
            if (string.IsNullOrEmpty(dgvHS.CurrentRow.Cells[14].Value.ToString()))
                return;
            byte[] img = (byte[])dgvHS.CurrentRow.Cells[14].Value;
            if (img == null)
                ptbAnh.Image = null;
            else
            {
                MemoryStream ms = new MemoryStream(img);
                ptbAnh.Image = Image.FromStream(ms);
            }

            //txtMSHS.Enabled = false; // Không cho phép sửa Mã học sinh
        }

        private void dtpNgaySinh_onValueChanged(object sender, EventArgs e)
        {
            txtNgaySinh.Text = dtpNgaySinh.Value.ToString();
        }

        void Load_combobox()
        {
            string query = "SELECT * FROM LOP";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.DataSource = dt;
            cboMaLop.Text = "";
        }

        private void cboMaLop_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT TENLOP FROM LOP WHERE MALOP = '" + cboMaLop.Text + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMaLop.Text == "")
                txtTenLop.Text = "";
            else
                txtTenLop.Text = dt.Rows[0][0].ToString();
        }

        bool GeneralCheck()
        {
            errorProvider1.Clear();
            bool flag = true;
            if (txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                flag = false;
                //provider
                errorProvider1.SetError(txtHoTen, "Không được bỏ trống vùng này");
            }
            if (cboGioiTinh.Text == "")
            {
                cboGioiTinh.Focus();
                flag = false;
                //provider
                errorProvider1.SetError(cboGioiTinh, "Không được bỏ trống vùng này");
            }
            if (txtNgaySinh.Text == "")
            {
                txtNgaySinh.Focus();
                flag = false;
                //provider
                errorProvider1.SetError(dtpNgaySinh, "Không được bỏ trống vùng này");
            }
            if (txtKhoa.Text == "")
            {
                txtKhoa.Focus();
                flag = false;
                //provider
                errorProvider1.SetError(txtKhoa, "Không được bỏ trống vùng này");
            }
            if (cboMaLop.Text == "")
            {
                cboMaLop.Focus();
                flag = false;
                //provider
                errorProvider1.SetError(cboMaLop, "Không được bỏ trống vùng này");
            }
            if (txtMSHS.Text == "")
            {
                txtMSHS.Focus();
                flag = false;
                //provider
                errorProvider1.SetError(txtMSHS, "Không được bỏ trống vùng này");
            }
            if (txtDanToc.Text == "")
            {
                txtDanToc.Focus();
                flag = false;
                //provider
                errorProvider1.SetError(txtDanToc, "Không được bỏ trống vùng này");
            }
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Focus();
                flag = false;
                //provider
                errorProvider1.SetError(txtDiaChi, "Không được bỏ trống vùng này");
            }
            return flag;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "All File(.)|*.*";
                dlg.Title = "Select Employee Picture...";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgTest = dlg.FileName.ToString();
                    ptbAnh.ImageLocation = imgTest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");

            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
