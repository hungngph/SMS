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
    public partial class frmChinhSuaDSNguoiDung : Form
    {
        public frmChinhSuaDSNguoiDung()
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
        }
        //Di chuyển form
        Boolean flag; int x, y;

        private void frmChinhSuaDSNguoiDung_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmChinhSuaDSNguoiDung_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        private void frmChinhSuaDSNguoiDung_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);

        }
        //

        private void btnThemmoi_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }


    }
}
