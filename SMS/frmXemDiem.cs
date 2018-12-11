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
        bool GeneralCheck()
        {
            bool flag = true;
            if (txtMaLop.Text == "")
            {
                txtMaLop.Focus();
                flag = false;
                // Provider
            }
            else if (txtHocKy.Text == "")
            {
                txtHocKy.Focus();
                flag = false;
                //Provider
            }
            else if (txtNamHoc.Text == "")
            {
                txtNamHoc.Focus();
                flag = false;
                //Provider
            }
            return flag;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            validateMaLop();
            validateNamHoc();
            validateHocKy();
            if (GeneralCheck())
            {
                string query = null;
                if (txtMaMon.Text != "")
                {
                    query = "SELECT dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, DIEMMIENG1, DIEMMIENG2, DIEMMIENG3, DIEM15P1, DIEM15P2, DIEM1TIET, DIEMCUOIKY, DIEMTONGKET " +
                            "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                            "WHERE " +
                                      "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                       "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH " +
                                       "AND dbo.HOCSINH.MALOP='" + txtMaLop.Text + "' " +
                                       "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                       "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "' " +
                                       "AND dbo.MONHOC.MAMH = '" + txtMaMon.Text + "'";
                    btnXuatMon.Visible = true;
                    btnXuatLop.Visible = false;
                }
                else
                {
                    query = "SELECT dbo.MONHOC.TENMH, dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, dbo.DIEM.DIEMTONGKET " +
                           "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                           "WHERE " +
                                     "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                      "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH " +
                                      "AND dbo.HOCSINH.MALOP='" + txtMaLop.Text + "' " +
                                      "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                      "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "' " +
                            "GROUP BY dbo.MONHOC.TENMH, dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, dbo.DIEM.DIEMTONGKET";
                    btnXuatMon.Visible = false;
                    btnXuatLop.Visible = true;
                }
                dgvDSXD.DataSource = DatabaseConnection.GetDataTable(query);
            }
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
        }
        //Xác thực đã nhập text
        protected bool validateMaLop()
        {
            bool flag = false;
            if (txtMaLop.Text == "")
            {
                errorProvider1.SetError(txtMaLop, "Chưa nhập mã lớp");
                flag = true;
            }
            else errorProvider1.SetError(txtMaLop, "");
            return flag;

        }

        protected bool validateNamHoc()
        {
            bool flag = false;
            if (txtNamHoc.Text == "")
            {
                errorProvider1.SetError(txtNamHoc, "Chưa nhập năm học");
                flag = true;
            }
            else errorProvider1.SetError(txtNamHoc, "");
            return flag;
        }
        protected bool validateHocKy()
        {
            bool flag = false;
            if (txtHocKy.Text == "")
            {
                errorProvider1.SetError(txtHocKy, "Chưa nhập học kỳ");
                flag = true;
            }
            else errorProvider1.SetError(txtHocKy, "");
            return flag;
        }

        private void btnXuatMon_Click(object sender, EventArgs e)
        {
            
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


        private void btnXuatMon_Click_1(object sender, EventArgs e)
        {
            //Tạo FileName
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            fsave.ShowDialog();
            if (fsave.FileName != "")
            {
                Excel.Application xlapp;
                Excel.Workbook xlworkbook;
                Excel.Worksheet xlworsheet;
                object misValue = System.Reflection.Missing.Value;

                xlapp = new Excel.Application();
                xlworkbook = xlapp.Workbooks.Add(misValue);
                xlworsheet = (Excel.Worksheet)xlworkbook.Worksheets.get_Item(1);

                //Tạo dữ liệu cho file Excel
                xlworsheet.Name = "Xuất dữ liệu";

                // Tạo tiêu đề
                Microsoft.Office.Interop.Excel.Range head = xlworsheet.get_Range("A1", "J1");
                head.MergeCells = true;
                head.Value2 = "Bảng Điểm Học Sinh";
                head.Font.Bold = true;
                head.Font.Name = "Tahoma";
                head.Font.Size = "15";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột
                Microsoft.Office.Interop.Excel.Range cl1 = xlworsheet.get_Range("A3", "A3");
                cl1.Value2 = "Mã học sinh";
                cl1.ColumnWidth = 12.0;

                Microsoft.Office.Interop.Excel.Range cl2 = xlworsheet.get_Range("B3", "B3");
                cl2.Value2 = "Tên học sinh";
                cl2.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl3 = xlworsheet.get_Range("C3", "C3");
                cl3.Value2 = "Điểm miệng 1";
                cl3.ColumnWidth = 15.0;

                Microsoft.Office.Interop.Excel.Range cl4 = xlworsheet.get_Range("D3", "D3");
                cl4.Value2 = "Điểm miệng 2";
                cl4.ColumnWidth = 15.0;

                Microsoft.Office.Interop.Excel.Range cl5 = xlworsheet.get_Range("E3", "E3");
                cl5.Value2 = "Điểm miệng 3";
                cl5.ColumnWidth = 15.0;

                Microsoft.Office.Interop.Excel.Range cl6 = xlworsheet.get_Range("F3", "F3");
                cl6.Value2 = "Điểm 15P 1";
                cl6.ColumnWidth = 15.0;

                Microsoft.Office.Interop.Excel.Range cl7 = xlworsheet.get_Range("G3", "G3");
                cl7.Value2 = "Điểm 15P 2";
                cl7.ColumnWidth = 15.0;

                Microsoft.Office.Interop.Excel.Range cl8 = xlworsheet.get_Range("H3", "H3");
                cl8.Value2 = "Điểm 45P";
                cl8.ColumnWidth = 12.0;

                Microsoft.Office.Interop.Excel.Range cl9 = xlworsheet.get_Range("I3", "I3");
                cl9.Value2 = "Điểm cuối kỳ";
                cl9.ColumnWidth = 12.0;

                Microsoft.Office.Interop.Excel.Range cl10 = xlworsheet.get_Range("J3", "J3");
                cl10.Value2 = "Điểm tổng kết";
                cl10.ColumnWidth = 14.0;

                Microsoft.Office.Interop.Excel.Range rowHead = xlworsheet.get_Range("A3", "J3");
                rowHead.Font.Bold = true;
                // Kẻ viền
                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                // Thiết lập màu nền
                rowHead.Interior.ColorIndex = 15;
                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                //Xuất dữ liệu từ dgv ra Excel
                for (int i = 0; i <= dgvDSXD.RowCount - 1; i++)

                {
                    for (int j = 0; j <= dgvDSXD.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvDSXD[j, i];
                        xlworsheet.Cells[i + 4, j + 1] = cell.Value;
                    }
                }

                xlworkbook.SaveAs(fsave.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlworkbook.Close(true, misValue, misValue);
                xlapp.Quit();
                reOject(xlworsheet);
                reOject(xlworkbook);
                reOject(xlapp);
                MessageBox.Show("Xuất dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tệp tin nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXuatLop_Click(object sender, EventArgs e)
        {

        }
    }
}
