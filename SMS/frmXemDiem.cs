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
using Excel = Microsoft.Office.Interop.Excel;

namespace SMS
{
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
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

        private void frmXemDiem_MouseDown(object sender, MouseEventArgs e)
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


        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            Load_combobox();
        }

        int bo = 0;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bo = 0;
            if (GeneralCheck()) {
                string query = null;
                if (cboMaMon.Text != "") {
                    bo = 1;
                    query = "SELECT DIEM.MAHS as [Mã học sinh], " +
                            "DIEM.TENHOCSINH as [Tên học sinh], " +
                            "DIEMMIENG1 as [Điểm miệng 1], " +
                            "DIEMMIENG2 as [Điểm miệng 2], " +
                            "DIEMMIENG3 as [Điểm miệng 3], " +
                            "DIEM15P1 as [Điểm 15' 1], " +
                            "DIEM15P2 as [Điểm 15' 2], " +
                            "DIEM1TIET as [Điểm 1 tiết], " +
                            "DIEMCUOIKY as [Điểm học kỳ], " +
                            "DIEMTONGKET as [Điểm tổng kết]" +
                            "FROM DIEM, HOCSINH, MONHOC " +
                            "WHERE " +
                                      " DIEM.MAHS=HOCSINH.MAHS " +
                                       "AND DIEM.MAMH=MONHOC.MAMH " +
                                       "AND HOCSINH.MALOP='" + cboMaLop.Text + "' " +
                                       "AND DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                       "AND DIEM.HOCKY='" + txtHocKy.Text + "' " +
                                       "AND MONHOC.MAMH = '" + cboMaMon.Text + "'";
                }
                else {
                    bo = 2;
                    query = "SELECT MONHOC.TENMH AS [Môn học] ," +
                            "DIEM.MAHS as [Mã học sinh], " +
                            "DIEM.TENHOCSINH as [Tên học sinh], " +
                            "DIEM.DIEMTONGKET as [Điểm tổng kết] " +
                            "FROM DIEM, HOCSINH, MONHOC " +
                            "WHERE " +
                                     "DIEM.MAHS=HOCSINH.MAHS " +
                                      "AND DIEM.MAMH=MONHOC.MAMH " +
                                      "AND HOCSINH.MALOP='" + cboMaLop.Text + "' " +
                                      "AND DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                      "AND DIEM.HOCKY='" + txtHocKy.Text + "' " +
                            "GROUP BY MONHOC.TENMH, DIEM.MAHS, DIEM.TENHOCSINH, DIEM.DIEMTONGKET";
                }
                if (DatabaseConnection.GetDataTable(query).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else {
                    bo += 2;
                    dgvDSXD.DataSource = DatabaseConnection.GetDataTable(query);
                    AddChart();
                }
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

            //workbook = app.Workbooks.Add(misValue);
            //worksheet = workbook.Worksheets.get_Item(1);
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Xuất dữ liệu";
            //Tạo dữ liệu cho file Excel

            // Tạo tiêu đề
            //Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("A1", "J1");
            //head.MergeCells = true;
            //head.Value2 = "Bảng Điểm Học Sinh";
            //head.Font.Bold = true;
            //head.Font.Name = "Tahoma";
            //head.Font.Size = "15";
            //head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột
            for (int i = 1; i <= dgvDSXD.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvDSXD.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvDSXD.Rows.Count; i++)
                for (int j = 0; j < dgvDSXD.Columns.Count; j++)
                    worksheet.Cells[i + 2, j + 1] = dgvDSXD.Rows[i].Cells[j].Value.ToString();
            if (fsave.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(fsave.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing);
            }
            app.Quit();
            //Microsoft.Office.Interop.Excel.Range cl1 = xlworsheet.get_Range("A3", "A3");
            //cl1.Value2 = "Mã học sinh";
            //cl1.ColumnWidth = 12.0;

            //Microsoft.Office.Interop.Excel.Range cl2 = xlworsheet.get_Range("B3", "B3");
            //cl2.Value2 = "Tên học sinh";
            //cl2.ColumnWidth = 25.0;

            //Microsoft.Office.Interop.Excel.Range cl3 = xlworsheet.get_Range("C3", "C3");
            //cl3.Value2 = "Điểm miệng 1";
            //cl3.ColumnWidth = 15.0;

            //Microsoft.Office.Interop.Excel.Range cl4 = xlworsheet.get_Range("D3", "D3");
            //cl4.Value2 = "Điểm miệng 2";
            //cl4.ColumnWidth = 15.0;

            //Microsoft.Office.Interop.Excel.Range cl5 = xlworsheet.get_Range("E3", "E3");
            //cl5.Value2 = "Điểm miệng 3";
            //cl5.ColumnWidth = 15.0;

            //Microsoft.Office.Interop.Excel.Range cl6 = xlworsheet.get_Range("F3", "F3");
            //cl6.Value2 = "Điểm 15P 1";
            //cl6.ColumnWidth = 15.0;

            //Microsoft.Office.Interop.Excel.Range cl7 = xlworsheet.get_Range("G3", "G3");
            //cl7.Value2 = "Điểm 15P 2";
            //cl7.ColumnWidth = 15.0;

            //Microsoft.Office.Interop.Excel.Range cl8 = xlworsheet.get_Range("H3", "H3");
            //cl8.Value2 = "Điểm 45P";
            //cl8.ColumnWidth = 12.0;

            //Microsoft.Office.Interop.Excel.Range cl9 = xlworsheet.get_Range("I3", "I3");
            //cl9.Value2 = "Điểm cuối kỳ";
            //cl9.ColumnWidth = 12.0;

            //Microsoft.Office.Interop.Excel.Range cl10 = xlworsheet.get_Range("J3", "J3");
            //cl10.Value2 = "Điểm tổng kết";
            //cl10.ColumnWidth = 14.0;

            //Microsoft.Office.Interop.Excel.Range rowHead = xlworsheet.get_Range("A3", "J3");
            //rowHead.Font.Bold = true;
            //// Kẻ viền
            //rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            //// Thiết lập màu nền
            //rowHead.Interior.ColorIndex = 15;
            //rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            ////Xuất dữ liệu từ dgv ra Excel
            //for (int i = 0; i <= dgvDSXD.RowCount - 1; i++)

            //{
            //    for (int j = 0; j <= dgvDSXD.ColumnCount - 1; j++)
            //    {
            //        DataGridViewCell cell = dgvDSXD[j, i];
            //        xlworsheet.Cells[i + 4, j + 1] = cell.Value;
            //    }
            //}

            //xlworkbook.SaveAs(fsave.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlworkbook.Close(true, misValue, misValue);
            //xlapp.Quit();
            //reOject(xlworsheet);
            //reOject(xlworkbook);
            //reOject(xlapp);
            MessageBox.Show("Xuất dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
            DatabaseConnection.SaveAction("Xuất", "XEMDIEM");
        }

        private void reOject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi");
            }
            finally
            {
                GC.Collect();
            }
        }

        bool GeneralCheck()
        {
            errorProvider1.Clear();
            bool flag = true;
            if (cboMaLop.Text == "")
            {
                cboMaLop.Focus();
                flag = false;
                // Provider
                errorProvider1.SetError(cboMaLop, "Không được bỏ trống vùng này");
            }
            if (txtHocKy.Text == "")
            {
                txtHocKy.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtHocKy, "Không được bỏ trống vùng này");
            }
            if (txtNamHoc.Text == "")
            {
                txtNamHoc.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtNamHoc, "Không được bỏ trống vùng này");
            }
            return flag;
        }

        void Load_combobox()
        {
            cboMaMon.DisplayMember = "MAMH";
            cboMaMon.ValueMember = "MAMH";
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
            string query = "SELECT MALOP FROM LOP";
            DataTable d = DatabaseConnection.GetDataTable(query);
            cboMaLop.DataSource = d;
            query = "SELECT MAMH FROM MONHOC";
            d = DatabaseConnection.GetDataTable(query);
            cboMaMon.DataSource = d;
            cboMaLop.Text = "";
            cboMaMon.Text = "";
            if (DatabaseConnection.isAdmin == false)
            {
                query = "select MALOP FROM PHANCONG where MAGV = '" + DatabaseConnection.MaGV
                             + "' UNION select MALOP from LOP where MAGVCN = '" + DatabaseConnection.MaGV + "'";
                DataTable dt = DatabaseConnection.GetDataTable(query);
                cboMaLop.DataSource = dt;
            }
            UpdateCbo();
        }
        void UpdateCbo()
        {
            string query = "SELECT MAMH FROM MONHOC";
            var d = DatabaseConnection.GetDataTable(query);
            if (DatabaseConnection.isAdmin == false)
            {
                // nếu cbo.MALOP khác lớp chủ nhiệm -> cbo.MAMH = MAMH giáo viên đó dạy
                string query1 = "select MALOP from LOP where MAGVCN = '" + DatabaseConnection.MaGV + "'";
                string query2 = "select Distinct MAMH FROM PHANCONG where MAGV = '" + DatabaseConnection.MaGV + "'";
                DataTable dt1 = DatabaseConnection.GetDataTable(query1);
                DataTable dt2 = DatabaseConnection.GetDataTable(query2);
                if ((dt1.Rows.Count != 0 && cboMaLop.SelectedValue.ToString() != dt1.Rows[0][0].ToString())
                    || (dt1.Rows.Count == 0))
                {
                    cboMaMon.DataSource = DatabaseConnection.GetDataTable(query2);
                }
                else
                {
                    cboMaMon.DataSource = d;
                }
                cboMaMon.Text = "";
            }
        }

        private void cboMaMon_TextChanged(object sender, EventArgs e)
        {
            if (cboMaMon.SelectedValue == null)
                return;
            string query = "SELECT TENMH FROM MONHOC WHERE MAMH = '" + cboMaMon.SelectedValue.ToString() + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMaMon.Text == "")
                txtTenMon.Text = "";
            else
                txtTenMon.Text = dt.Rows[0][0].ToString();
        }

        private void cboMaLop_TextChanged(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedValue == null)
                return;
            string query = "SELECT TENLOP FROM LOP WHERE MALOP = '" + cboMaLop.SelectedValue.ToString() + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMaLop.Text == "")
                txtTenLop.Text = "";
            else
            {
                txtTenLop.Text = dt.Rows[0][0].ToString();
            }
            UpdateCbo();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void AddChart() {
            chart.Series["Diem"].Points.Clear();
            if (bo < 3)
                return;
            int[] bo2 = new int[11];
            float x = 0;
            float result;
            if (bo == 3) {
                for (int i = 0; i < dgvDSXD.Rows.Count; i++) {
                    float.TryParse(dgvDSXD.Rows[i].Cells[9].Value.ToString(), out result);
                    bo2[(int)Math.Floor(result)]++;
                }
            }
            if (bo == 4) {
                for (int i = 0; i < dgvDSXD.Rows.Count; i++) {
                    float.TryParse(dgvDSXD.Rows[i].Cells[3].Value.ToString(), out result);
                    if (result >= 10)
                        result = 9.9f;
                    bo2[(int)Math.Floor(result)]++;
                }
            }
            for (int i = 0; i < bo2.Length; i++)
                chart.Series["Diem"].Points.AddXY(i + 0.5f, (int)Math.Floor((float)bo2[i] / (dgvDSXD.Rows.Count) * 100));
            for (int i = 0; i < 10; i++) {
                chart.Series[0].Points[i].AxisLabel = i + " - " + (i + 1);
            }
        }
    }
}
