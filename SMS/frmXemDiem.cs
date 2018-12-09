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
    public partial class frmXemDiem : Form {
        public frmXemDiem() {
            InitializeComponent();
        }
        bool GeneralCheck() {
            bool flag = true;
            if (txtMaLop.Text == "") {
                txtMaLop.Focus();
                flag = false;
                // Provider
            }
            else if (txtHocKy.Text == "") {
                txtHocKy.Focus();
                flag = false;
                //Provider
            }
            else if (txtNamHoc.Text == "") {
                txtNamHoc.Focus();
                flag = false;
                //Provider
            }
            return flag;
        }

        private void btnTimKiem_Click(object sender, EventArgs e) {
            validateMaLop();
            validateNamHoc();
            validateHocKy();
            if (GeneralCheck()) {
                string query = null;
                if (txtMaMon.Text != "") {
                    query = "SELECT dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, DIEMMIENG1, DIEMMIENG2, DIEMMIENG3, DIEM15P1, DIEM15P2, DIEM1TIET, DIEMCUOIKY, DIEMTONGKET " +
                            "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                            "WHERE " +
                                      "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                       "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH " +
                                       "AND dbo.HOCSINH.MALOP='" + txtMaLop.Text + "' " +
                                       "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                       "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "' " +
                                       "AND dbo.MONHOC.MAMH = '" + txtMaMon.Text + "'";
                }
                else {
                    query = "SELECT dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, DIEMMIENG1, DIEMMIENG2, DIEMMIENG3, DIEM15P1, DIEM15P2, DIEM1TIET, DIEMCUOIKY, DIEMTONGKET " +
                           "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                           "WHERE " +
                                     "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                      "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH " +
                                      "AND dbo.HOCSINH.MALOP='" + txtMaLop.Text + "' " +
                                      "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                      "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "' ";
                }
                dgvDSXD.DataSource = DatabaseConnection.GetDataTable(query);
            }
        }

        private void frmXemDiem_Load(object sender, EventArgs e) {

        }
        //Xác thực đã nhập text
        protected bool validateMaLop() {
            bool flag = false;
            if (txtMaLop.Text == "") {
                errorProvider1.SetError(txtMaLop, "Chưa nhập mã lớp");
                flag = true;
            }
            else errorProvider1.SetError(txtMaLop, "");
            return flag;

        }

        protected bool validateNamHoc() {
            bool flag = false;
            if (txtNamHoc.Text == "") {
                errorProvider1.SetError(txtNamHoc, "Chưa nhập năm học");
                flag = true;
            }
            else errorProvider1.SetError(txtNamHoc, "");
            return flag;
        }
        protected bool validateHocKy() {
            bool flag = false;
            if (txtHocKy.Text == "") {
                errorProvider1.SetError(txtHocKy, "Chưa nhập học kỳ");
                flag = true;
            }
            else errorProvider1.SetError(txtHocKy, "");
            return flag;
        }
    }
}
