using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

//using ms = Microsoft.Office.Interop.Excel;

namespace SMS
{
    class ExportToExcel
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        //public static void Export(DataGridView dgv)
        //{
        //    CultureInfo old = Thread.CurrentThread.CurrentCulture;
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        //    //ms.ApplicationClass exa = new ms.ApplicationClass();
        //    ms.Workbook wb = exa.Application.Workbooks.Add(ms.XlSheetType.xlWorksheet);
        //    ms.Worksheet ws = (ms.Worksheet)exa.ActiveSheet;
        //    exa.Visible = true;
        //    for (int i = 0; i < dgv.Columns.Count; ++i)
        //    {
        //        ws.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
        //    }
        //    ms.Range ran = ws.get_Range("a1", "z1");
        //    ran.Font.Bold = true;
        //    ran.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Navy);

        //    for (int i = 0; i < dgv.Rows.Count; ++i)
        //    {
        //        for (int j = 0; j < dgv.Columns.Count; ++j)
        //        {
        //            ws.Cells[i + 2, j + 1] = dgv[j, i].Value;
        //        }
        //    }
        //    ws.Columns.AutoFit();
        //    Thread.CurrentThread.CurrentCulture = old;
        //}
        //private SqlConnection Connected()
        //{
        //    throw new NotImplementedException();
        //}
        //public void Export(DataGridView dgv, string sheetName, string title)
        //{

        //    DataTable dt = (DataTable)dgv.DataSource;
        //    // Khởi động
        //    ms.Application oExcel = new ms.Application();
        //    //Tạo các đối tượng Excel

        //    ms.Workbooks oBooks;

        //    ms.Sheets oSheets;

        //    ms.Workbook oBook;

        //    ms.Worksheet oSheet;

        //    //Tạo mới một Excel WorkBook 

        //    oExcel.Visible = true;

        //    oExcel.DisplayAlerts = false;

        //    oExcel.Application.SheetsInNewWorkbook = 1;

        //    oBooks = oExcel.Workbooks;

        //    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

        //    oSheets = oBook.Worksheets;

        //    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

        //    oSheet.Name = sheetName;

        //    // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

        //    // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

        //    object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

        //    //Chuyển dữ liệu từ DataTable vào mảng đối tượng

        //    for (int r = 0; r < dt.Rows.Count; r++)

        //    {

        //        DataRow dr = dt.Rows[r];

        //        for (int c = 0; c < dt.Columns.Count; c++)

        //        {
        //            arr[r, c] = dr[c];
        //        }
        //    }

        //    //Thiết lập vùng điền dữ liệu

        //    int rowStart = 4;

        //    int columnStart = 1;

        //    int rowEnd = rowStart + dt.Rows.Count - 1;

        //    int columnEnd = dt.Columns.Count;

        //    // Ô bắt đầu điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

        //    // Ô kết thúc điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

        //    // Lấy về vùng điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

        //    //Điền dữ liệu vào vùng đã thiết lập

        //    range.Value2 = arr;
        //}
    }
}
