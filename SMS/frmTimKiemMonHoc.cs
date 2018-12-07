using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class frmTimKiemMonHoc : Form
    {
        public frmTimKiemMonHoc()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDanhSachMH dsmh = new frmDanhSachMH();
            dsmh.Show();
        }
    }
}
