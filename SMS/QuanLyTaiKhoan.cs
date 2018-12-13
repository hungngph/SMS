using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class QuanLyTaiKhoan : UserControl
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.Show();
        }

        private void btnDanhSachNguoiDung_Click(object sender, EventArgs e)
        {
            frmDanhSachNguoiDung csdsng = new frmDanhSachNguoiDung();
            csdsng.Show();
        }
    }
}
