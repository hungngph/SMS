using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS {
    public partial class frmHocSinh : Form {
        public frmHocSinh() {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmHocSinh_Load(object sender, EventArgs e) {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect()) {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
        }
        void FillDataGridView() {
            string query = "SELECT * " +
                "FROM HOCSINH";
            dgvHS.DataSource = DatabaseConnection.GetDataTable(query);
            // adapter.Dispose();
        }

        private void button4_Click(object sender, EventArgs e) {
            
        }
        //bool GeneralCheck() {
        //    bool flag = true;
        //    if (txtHoTen.Text == "") {
        //        flag = false;
        //        //provider
        //    }
        //    if (cboGioiTinh.Text == "") {
        //        flag = false;
        //        //provider
        //    }
        //    //if (dtpNgSinh.)
        //    return flag;
        //}
    }
}
