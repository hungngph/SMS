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
    public partial class frmPhanCong : Form
    {
        public frmPhanCong()
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

        private void frmPhanCong_MouseDown(object sender, MouseEventArgs e)
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

        private void frmPhanCong_Load(object sender, EventArgs e)
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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvTTGD.SelectedRows.Count == 1)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Update PHANCONG Set MALOP = '" + cboMaLop.Text + "', ";
                    strUpdate += "MAMH = '" + cboMaMon.Text + "', ";
                    strUpdate += "MAGV = '" + cboMaGV.Text + "' ";
                    strUpdate += "Where MALOP = '" + cboMaLop.Text + "' and MAMH = '" + cboMaMon.Text + "' and MAGV = '" + cboMaGV.Text + "'";
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                        MessageBox.Show("Chỉnh sửa phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chỉnh sửa phân công thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phần phân công cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            cboMaLop.Text = "";
            cboMaMon.Text = "";
            cboMaGV.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s1 = "Select * From PHANCONG Where ";
            string strSelect = "Select * From PHANCONG Where ";
            if (cboMaLop.Text != "")
                strSelect += "MALOP = '" + cboMaLop.Text + "'and ";
            if (cboMaMon.Text != "")
                strSelect += "MAMH = '" + cboMaMon.Text + "' and ";
            if (cboMaGV.Text != "")
                strSelect += "GIOITINH = '" + cboMaGV.Text + "' and ";
            if (s1 == strSelect)
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FillDataGridView();
            }
            else
            {
                strSelect = strSelect.Substring(0, strSelect.Length - 4);
                if (DatabaseConnection.GetDataTable(strSelect).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    dgvTTGD.DataSource = DatabaseConnection.GetDataTable(strSelect);
            }
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
            return flag;
        }

        private void FillDataGridView()
        {
            string query = "SELECT PC.MALOP AS [Lớp], PC.MAMH AS [Môn học], PC.MAGV AS [Giáo viên dạy] " +
                            "FROM PHANCONG PC ";                            
            dgvTTGD.DataSource = DatabaseConnection.GetDataTable(query);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            errorProvider1.Clear();
            cboMaLop.Text = dgvTTGD.CurrentRow.Cells[0].Value.ToString();
            cboMaMon.Text = dgvTTGD.CurrentRow.Cells[1].Value.ToString();
            cboMaGV.Text = dgvTTGD.CurrentRow.Cells[2].Value.ToString();
        }

        void Load_combobox()
        {
            string query = "SELECT * FROM LOP";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.DataSource = dt;
            cboMaLop.Text = "";
            query = "SELECT * FROM MONHOC";
            dt = DatabaseConnection.GetDataTable(query);
            cboMaMon.DisplayMember = "MAMH";
            cboMaMon.DataSource = dt;
            cboMaMon.Text = "";
            query = "SELECT * FROM GIAOVIEN";
            dt = DatabaseConnection.GetDataTable(query);
            cboMaGV.DisplayMember = "MAGV";
            cboMaGV.DataSource = dt;
            cboMaGV.Text = "";
        }

        private void cboMaLop_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT TENLOP FROM LOP WHERE MALOP = '" + cboMaLop.Text + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMaLop.Text == "")
                txtTenLop.Text = "";
            else
                txtTenLop.Text = dt.Rows[0][0].ToString();
        }

        private void cboMaGV_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT HOTEN FROM GIAOVIEN WHERE MAGV = '" + cboMaGV.Text + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);

            if (cboMaGV.Text == "")
                txtTenGV.Text = "";
            else
                txtTenGV.Text = dt.Rows[0][0].ToString();
        }

        private void cboMaMon_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT TENMH FROM MONHOC WHERE MAMH = '" + cboMaMon.Text + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            if (cboMaMon.Text == "")
                txtTenMon.Text = "";
            else
                txtTenMon.Text = dt.Rows[0][0].ToString();
        }
    }
}
