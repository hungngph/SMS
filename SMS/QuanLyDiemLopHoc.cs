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
    public partial class QuanLyDiemLopHoc : UserControl
    {
        public QuanLyDiemLopHoc()
        {
            InitializeComponent();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            frmNhapDiem ndiem = new frmNhapDiem();
            ndiem.Show();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            frmXemDiem xdiem = new frmXemDiem();
            xdiem.Show();
        }
    }
}
