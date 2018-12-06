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
    public partial class frmGiaoVien : Form {
        public frmGiaoVien() {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e) {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect()) {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
        }
        void FillDataGridView() {
            string query = "SELECT * " +
                "FROM GIAOVIEN";
            dgvGV.DataSource = DatabaseConnection.GetDataTable(query);
            // adapter.Dispose();
        }

    }
}
