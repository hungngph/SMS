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
    public partial class CapNhatThongTin : UserControl
    {
        public CapNhatThongTin()
        {
            InitializeComponent();
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh hs = new frmHocSinh();
            hs.Show();
        }

        private void btnQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.Show();

        }

        private void btnQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            frmLopHoc lh = new frmLopHoc();
            lh.Show();
        }

        private void btnQuanLyGiangDay_Click(object sender, EventArgs e)
        {
            frmPhanCong pc = new frmPhanCong();
            pc.Show();
        }

        private void CapNhatThongTin_Load(object sender, EventArgs e)
        {
            if (DatabaseConnection.isAdmin == true)
            {
                btnQuanLyGiangDay.Visible = true;
                btnQuanLyLopHoc.Visible = true;
            }
            else
            {
                btnQuanLyGiaoVien.LabelText = "Thông Tin Giáo Viên";
                btnQuanLyGiangDay.Visible = false;
                btnQuanLyLopHoc.Visible = false;
            }
            string query = "Select MAGVCN from LOP where MAGVCN = '" + DatabaseConnection.MaGV + "'";
            if (DatabaseConnection.GetDataTable(query).Rows.Count == 0)
                btnQuanLyHocSinh.Visible = false;
        }
    }
}
