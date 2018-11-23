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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Di chuyeerg form
        Boolean flag; int x, y;
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;

        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
        //

        //Nút đóng form
        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }
        //

        //Nút thu nhỏ form
        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
    }
}
