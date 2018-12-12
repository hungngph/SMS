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

namespace SMS
{
    public partial class frmChucNang : Form
    {
        public frmChucNang()
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

        private void frmChucNang_MouseDown(object sender, MouseEventArgs e)
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

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoan1.Visible = true;
            capNhatThongTin1.Visible = false;
            quanLyDiemLopHoc1.Visible = false;
            gioiThieu1.Visible = false;
        }

        private void btnCapNhapThongTin_Click(object sender, EventArgs e)
        {
            capNhatThongTin1.Visible = true;
            quanLyTaiKhoan1.Visible = false;
            quanLyDiemLopHoc1.Visible = false;
            gioiThieu1.Visible = false;
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            quanLyDiemLopHoc1.Visible = true;
            capNhatThongTin1.Visible = false;
            quanLyTaiKhoan1.Visible = false;
            gioiThieu1.Visible = false;
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            gioiThieu1.Visible = true;
            quanLyDiemLopHoc1.Visible = false;
            capNhatThongTin1.Visible = false;
            quanLyTaiKhoan1.Visible = false;
        }

    }
}
