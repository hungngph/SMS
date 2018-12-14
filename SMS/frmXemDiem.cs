using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SMS
{
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            Load_combobox();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (GeneralCheck())
            {
                string query = null;
                if (cboMaMon.Text != "")
                {
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
                else
                {
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
                else
                    dgvDSXD.DataSource = DatabaseConnection.GetDataTable(query);
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
            string query = "SELECT * FROM LOP";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.DataSource = dt;
            cboMaLop.Text = "";
            query = "SELECT * FROM MONHOC";
            dt = DatabaseConnection.GetDataTable(query);
            cboMaMon.DisplayMember = "MAMH";
            cboMaMon.DataSource = dt;
            cboMaMon.Text = "";
        }

        private void cboMaMon_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT TENMH FROM MONHOC WHERE MAMH = '" + cboMaMon.Text + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMaMon.Text == "")
                txtTenMon.Text = "";
            else
                txtTenMon.Text = dt.Rows[0][0].ToString();
        }
    }
}
