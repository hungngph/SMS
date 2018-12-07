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
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        bool GeneralCheck()
        {
            bool flag = true;
            if (txtMaLop.Text == "")
            {
                txtMaLop.Focus();
                flag = false;
                // Provider
            }
            else if (txtMaMon.Text == "")
            {
                txtMaMon.Focus();
                flag = false;
                //Provider
            }
            else if (txtHocKy.Text == "")
            {
                txtHocKy.Focus();
                flag = false;
                //Provider
            }
            else if (txtNamHoc.Text == "")
            {
                txtNamHoc.Focus();
                flag = false;
                //Provider
            }
            return flag;
        }
        private void btnTimKiem(object sender, EventArgs e)
        {
            validateMaLop();
            validateMaMon();
            validateHocKy();
            validateNamHoc();
            if (GeneralCheck())
            {
                string query = "SELECT dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, DIEMMIENG1, DIEMMIENG2, DIEMMIENG3, DIEM15P1, DIEM15P2, DIEM1TIET, DIEMCUOIKY, DIEMTONGKET " +
                            "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                            "WHERE " +
                                   "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                   "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH " +
                                   "AND dbo.HOCSINH.MALOP='" + txtMaLop.Text + "' " +
                                   "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                   "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "' " +
                                   "AND dbo.MONHOC.MAMH = '" + txtMaMon.Text + "'";
                dgvDSNDi.DataSource = DatabaseConnection.GetDataTable(query);
            }
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
        }

        //Xử lí sự kiện click chuột vào phần tử trong DataGridView
        private void dgvDSNDi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHS.Text = dgvDSNDi.CurrentRow.Cells[0].Value.ToString();
            txtTenHS.Text = dgvDSNDi.CurrentRow.Cells[1].Value.ToString();
            txtDM1.Text = dgvDSNDi.CurrentRow.Cells[2].Value.ToString();
            txtDM2.Text = dgvDSNDi.CurrentRow.Cells[3].Value.ToString();
            txtDM3.Text = dgvDSNDi.CurrentRow.Cells[4].Value.ToString();
            txt15P1.Text = dgvDSNDi.CurrentRow.Cells[5].Value.ToString();
            txt15P2.Text = dgvDSNDi.CurrentRow.Cells[6].Value.ToString();
            txt45P.Text = dgvDSNDi.CurrentRow.Cells[7].Value.ToString();
            txtCuoiKy.Text = dgvDSNDi.CurrentRow.Cells[8].Value.ToString();
            txtTongKet.Text = dgvDSNDi.CurrentRow.Cells[9].Value.ToString();
        }

        //Xác thực đã nhập text
        protected bool validateMaLop()
        {
            bool flag = false;
            if (txtMaLop.Text == "")
            {
                errorProvider1.SetError(txtMaLop, "Chưa nhập mã lớp");
                flag = true;
            }
            else errorProvider1.SetError(txtMaLop, "");
            return flag;

        }
        protected bool validateMaMon()
        {
            bool flag = false;
            if (txtMaMon.Text == "")
            {
                errorProvider1.SetError(txtMaMon, "Chưa nhập mã lớp");
                flag = true;
            }
            else errorProvider1.SetError(txtMaMon, "");
            return flag;

        }
        protected bool validateNamHoc()
        {
            bool flag = false;
            if (txtNamHoc.Text == "")
            {
                errorProvider1.SetError(txtNamHoc, "Chưa nhập năm học");
                flag = true;
            }
            else errorProvider1.SetError(txtNamHoc, "");
            return flag;
        }
        protected bool validateHocKy()
        {
            bool flag = false;
            if (txtHocKy.Text == "")
            {
                errorProvider1.SetError(txtHocKy, "Chưa nhập học kỳ");
                flag = true;
            }
            else errorProvider1.SetError(txtHocKy, "");
            return flag;
        }//

        //Nút làm  mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtMaMon.Text = "";
            txtHocKy.Text = "";
            txtNamHoc.Text = "";
        }

        //Nút lưu điểm
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dbo.DIEM SET " +
                     "DIEMMIENG1=" + txtDM1.Text + ", " +
                     "DIEMMIENG2=" + txtDM2.Text + ", " +
                     "DIEMMIENG3=" + txtDM3.Text + ", " +
                     "DIEM15P1=" + txt15P1.Text + ", " +
                     "DIEM15P2=" + txt15P2.Text + ", " +
                     "DIEM1TIET=" + txt45P.Text + ", " +
                     "DIEMCUOIKY=" + txtCuoiKy.Text + " " +
                     "WHERE " +
                                "dbo.DIEM.MAHS='" + txtMaHS.Text + "' " +
                                "AND dbo.DIEM.MAMH='" + txtMaMon.Text + "' " +
                                //"AND dbo.HOCSINH.MALOP='" + txtMaLop.Text + "' " +
                                "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "'";
                                   //"AND dbo.MONHOC.MAMH = '" + txtMaMon.Text + "'";
            if (DatabaseConnection.ExcuteSql(query))
                    MessageBox.Show("Lưu điểm thành công");

            string query2 = "SELECT dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, DIEMMIENG1, DIEMMIENG2, DIEMMIENG3, DIEM15P1, DIEM15P2, DIEM1TIET, DIEMCUOIKY, DIEMTONGKET " +
                            "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                            "WHERE " +
                                   "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                   "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH " +
                                   "AND dbo.HOCSINH.MALOP='" + txtMaLop.Text + "' " +
                                   "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                   "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "' " +
                                   "AND dbo.MONHOC.MAMH = '" + txtMaMon.Text + "'";
            dgvDSNDi.DataSource = DatabaseConnection.GetDataTable(query2);
        }
    }
}
