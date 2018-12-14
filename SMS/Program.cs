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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // frmChucNang
            //Application.Run(new frmChucNang());

            // frmDanhSachNguoiDung
            //Application.Run(new frmDanhSachNguoiDung());

            // frmDoiMatKhau
            //Application.Run(new frmDoiMatKhau());

            // frmGiaoVien
            //Application.Run(new frmGiaoVien());

            //
            //Application.Run(new frmNhapDiem());
            //Application.Run(new frmChucNang());
            // frmHocSinh
            //Application.Run(new frmHocSinh());
            //Application.Run(new frmLopHoc());
            Application.Run(new frmDangNhap());
            //Application.Run(new frmDoiMatKhau());
            //Application.Run(new frmNhapDiem());
            //Application.Run(new frmXemDiem());
            //Application.Run(new frmPhanCong());
        }
    }
}
