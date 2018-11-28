using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Form Main
            //Application.Run(new frmMain());

            //Form NhapKhoa
            Application.Run(new frmNhapKhoa());

            //Form NhapMonHoc
            //Application.Run(new frmNhapMonHoc());

            //Form NhapThongTinSV
            //Application.Run(new frmNhapThongTinSV());
        }
    }
}
