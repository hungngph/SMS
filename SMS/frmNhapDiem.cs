using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SMS
{
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        //Sử dụng thư viện
        //using System.Runtime.InteropServices;
        //để di chuyển frm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmNhapDiem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
            Load_combobox();
            if (DatabaseConnection.isAdmin == false)
            {
                string query = "select MALOP FROM PHANCONG where MAGV = '" + DatabaseConnection.MaGV
                             + "' UNION select MALOP from LOP where MAGVCN = '" + DatabaseConnection.MaGV + "'";
                
                string strSelect = "SELECT dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, DIEMMIENG1, DIEMMIENG2, DIEMMIENG3, DIEM15P1, DIEM15P2, DIEM1TIET, DIEMCUOIKY, DIEMTONGKET " +
                            "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                            "WHERE " +
                                   "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                   "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH " +
                                   "AND HOCSINH.MALOP IN (" + query + ")";
                dgvDSNDi.DataSource = DatabaseConnection.GetDataTable(strSelect);
            }
        }

        private void btnTimKem_Click(object sender, EventArgs e)
        {

            if (GeneralCheck())
            {
                string query = "SELECT dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, DIEMMIENG1, DIEMMIENG2, DIEMMIENG3, DIEM15P1, DIEM15P2, DIEM1TIET, DIEMCUOIKY, DIEMTONGKET " +
                            "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                            "WHERE " +
                                   "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                   "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH " +
                                   "AND dbo.HOCSINH.MALOP='" + cboMaLop.Text + "' " +
                                   "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                   "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "' " +
                                   "AND dbo.MONHOC.MAMH = '" + cboMaMon.Text + "'";
                if (DatabaseConnection.GetDataTable(query).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    dgvDSNDi.DataSource = DatabaseConnection.GetDataTable(query);
                DatabaseConnection.SaveAction("Tìm kiếm", "NHAPDIEM");
            }
        }

        //Nút lưu điểm
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dbo.DIEM SET " +
                     "DIEMMIENG1=" + txtDM1.Text.Replace(",", ".") + ", " +
                     "DIEMMIENG2=" + txtDM2.Text.Replace(",", ".") + ", " +
                     "DIEMMIENG3=" + txtDM3.Text.Replace(",", ".") + ", " +
                     "DIEM15P1=" + txt15P1.Text.Replace(",", ".") + ", " +
                     "DIEM15P2=" + txt15P2.Text.Replace(",", ".") + ", " +
                     "DIEM1TIET=" + txt45P.Text.Replace(",", ".") + ", " +
                     "DIEMCUOIKY=" + txtCuoiKy.Text.Replace(",", ".") + " " +
                     "WHERE " +
                                "dbo.DIEM.MAHS='" + txtMaHS.Text + "' " +
                                "AND dbo.DIEM.MAMH='" + cboMaMon.Text + "' " +
                                //"AND dbo.HOCSINH.MALOP='" + txtMaLop.Text + "' " +
                                "AND dbo.DIEM.NAMHOC='" + txtNamHoc.Text + "' " +
                                "AND dbo.DIEM.HOCKY='" + txtHocKy.Text + "'";
            //"AND dbo.MONHOC.MAMH = '" + txtMaMon.Text + "'";
            if (DatabaseConnection.ExcuteSql(query))
                MessageBox.Show("Lưu điểm thành công");
            FillDataGridView();
            DatabaseConnection.SaveAction("Lưu", "NHAPDIEM");
        }

        //Nút làm  mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            cboMaLop.Text = "";
            cboMaMon.Text = "";
            txtHocKy.Text = "";
            txtNamHoc.Text = "";
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtDM1.Text = "";
            txtDM2.Text = "";
            txtDM3.Text = "";
            txt15P1.Text = "";
            txt15P2.Text = "";
            txt45P.Text = "";
            txtCuoiKy.Text = "";
            txtTongKet.Text = "";
        }


        bool GeneralCheck()
        {
            errorProvider1.Clear();
            bool flag = true;
            if (cboMaLop.Text == "")
            {
                cboMaLop.Focus();
                flag = false;
                // Provider
                errorProvider1.SetError(txtTenLop, "Không được bỏ trống vùng này");
            }
            if (cboMaMon.Text == "")
            {
                cboMaMon.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtTenMon, "Không được bỏ trống vùng này");
            }
            if (txtHocKy.Text == "")
            {
                txtHocKy.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtHocKy, "Không được bỏ trống vùng này");
            }
            if (txtNamHoc.Text == "")
            {
                txtNamHoc.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtNamHoc, "Không được bỏ trống vùng này");
            }
            return flag;
        }

        //Xử lí sự kiện click chuột vào phần tử trong DataGridView
        private void dgvDSNDi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            errorProvider1.Clear();
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

        private void FillDataGridView()
        {
            string query = "SELECT dbo.DIEM.MAHS, dbo.DIEM.TENHOCSINH, DIEMMIENG1, DIEMMIENG2, DIEMMIENG3, DIEM15P1, DIEM15P2, DIEM1TIET, DIEMCUOIKY, DIEMTONGKET " +
                            "FROM dbo.DIEM, dbo.HOCSINH, dbo.MONHOC " +
                            "WHERE " +
                                   "dbo.DIEM.MAHS=dbo.HOCSINH.MAHS " +
                                   "AND dbo.DIEM.MAMH=dbo.MONHOC.MAMH ";
            dgvDSNDi.DataSource = DatabaseConnection.GetDataTable(query);
        }

        void Load_combobox()
        {
            cboMaMon.DisplayMember = "MAMH";
            cboMaMon.ValueMember = "MAMH";
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
            string query = "SELECT MALOP FROM LOP";
            DataTable d = DatabaseConnection.GetDataTable(query);
            cboMaLop.DataSource = d;
            query = "SELECT MAMH FROM MONHOC";
            d = DatabaseConnection.GetDataTable(query);
            cboMaMon.DataSource = d;
            cboMaLop.Text = "";
            cboMaMon.Text = "";
            if (DatabaseConnection.isAdmin == false)
            {
                query = "select MALOP FROM PHANCONG where MAGV = '" + DatabaseConnection.MaGV
                             + "' UNION select MALOP from LOP where MAGVCN = '" + DatabaseConnection.MaGV + "'";
                DataTable dt = DatabaseConnection.GetDataTable(query);
                cboMaLop.DataSource = dt;
            }
            UpdateCbo();
        }
        void UpdateCbo()
        {
            string query = "SELECT MAMH FROM MONHOC";
            var d = DatabaseConnection.GetDataTable(query);
            if (DatabaseConnection.isAdmin == false)
            {
                // nếu cbo.MALOP khác lớp chủ nhiệm -> cbo.MAMH = MAMH giáo viên đó dạy
                string query1 = "select MALOP from LOP where MAGVCN = '" + DatabaseConnection.MaGV + "'";
                string query2 = "select Distinct MAMH FROM PHANCONG where MAGV = '" + DatabaseConnection.MaGV + "'";
                DataTable dt1 = DatabaseConnection.GetDataTable(query1);
                DataTable dt2 = DatabaseConnection.GetDataTable(query2);
                if ((dt1.Rows.Count != 0 && cboMaLop.SelectedValue.ToString() != dt1.Rows[0][0].ToString()) 
                    || (dt1.Rows.Count == 0))
                {
                    cboMaMon.DataSource = DatabaseConnection.GetDataTable(query2);
                }
                else
                {
                    cboMaMon.DataSource = d;
                }
                cboMaMon.Text = "";
            }
        }

        private void cboMaMon_TextChanged(object sender, EventArgs e)
        {
            if (cboMaMon.SelectedValue == null)
                return;
            string query = "SELECT TENMH FROM MONHOC WHERE MAMH = '" + cboMaMon.SelectedValue.ToString() + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMaMon.Text == "")
                txtTenMon.Text = "";
            else
                txtTenMon.Text = dt.Rows[0][0].ToString();
        }

        private void cboMaLop_TextChanged(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedValue == null)
                return;
            string query = "SELECT TENLOP FROM LOP WHERE MALOP = '" + cboMaLop.SelectedValue.ToString() + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMaLop.Text == "")
                txtTenLop.Text = "";
            else
            {
                txtTenLop.Text = dt.Rows[0][0].ToString();
            }
            UpdateCbo();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
