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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
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

        private void frmLopHoc_MouseDown(object sender, MouseEventArgs e)
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

        private void frmLopHoc_Load(object sender, EventArgs e)
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Câu lệnh truy vấn Table LOP
            string strSelect = "Select * From LOP Where MALOP = '" + txtMaLop.Text + "'";
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("Mã lớp đã tồn tại. Xin vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaLop.Focus();
                    //txtMaLop.SelectAll();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Insert into LOP values ('";
                    strInsert += txtMaLop.Text + "', N'";
                    strInsert += txtTenLop.Text + "', '";
                    strInsert += cboMAGVCN.Text + "', ";
                    strInsert += txtSiSo.Text + ")";
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                    {
                        MessageBox.Show("Thêm Lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaLop.Enabled = false;
                        DatabaseConnection.SaveAction("Thêm mới", "LOP");
                    }
                    else
                        MessageBox.Show("Thêm Lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }



        private void btnChinhSua_Click(object sender, EventArgs e)
        {

            if (dgvLH.SelectedRows.Count == 1)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Update LOP Set TENLOP = N'" + txtTenLop.Text + "', ";
                    strUpdate += "MAGVCN = '" + cboMAGVCN.Text + "', ";
                    strUpdate += "SISO = " + txtSiSo.Text + " ";
                    strUpdate += "Where MALOP = '" + txtMaLop.Text + "'";
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                    {
                        MessageBox.Show("Chỉnh sửa Lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatabaseConnection.SaveAction("Chỉnh sửa", "LOP");
                    }
                    else
                        MessageBox.Show("Chỉnh sửa Lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Học sinh cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLH.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strDelete = "Delete from LOP Where MALOP = '";
                    {
                        for (int i = 0; i < dgvLH.SelectedRows.Count; i++)
                            if (!DatabaseConnection.ExcuteSql(strDelete + dgvLH.SelectedRows[i].Cells[0].Value + "'"))
                            {
                                MessageBox.Show("Không thể xóa Lop hoc có Mã lớp " + dgvLH.SelectedRows[i].Cells[0].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                        FillDataGridView();
                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatabaseConnection.SaveAction("Xóa", "LOP");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Lớp học cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtMaLop.Enabled = true;
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboMAGVCN.Text = "";
            txtTenGVCN.Text = "";
            txtSiSo.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s1 = "Select * From LOP Where ";
            string strSelect = "Select * From LOP Where ";
            if (txtMaLop.Text != "")
                strSelect += "MALOP = '" + txtMaLop.Text + "'and ";
            if (txtTenLop.Text != "")
                strSelect += "TENLOP = N'" + txtTenLop.Text + "' and ";
            if (cboMAGVCN.Text != "")
                strSelect += "MAGVCN = N'" + cboMAGVCN.Text + "' and ";
            if (txtSiSo.Text != "")
                strSelect += "SISO = " + txtSiSo.Text + " and ";
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
                    dgvLH.DataSource = DatabaseConnection.GetDataTable(strSelect);
                DatabaseConnection.SaveAction("Tìm Kiếm", "LOP");
            }
        }

        private void FillDataGridView()
        {
            string query = "SELECT * FROM LOP";
            dgvLH.DataSource = DatabaseConnection.GetDataTable(query);
            //// Chỉnh sửa kích thước các cột
            dgvLH.Columns[0].Width = dgvLH.Width / 4;
            dgvLH.Columns[1].Width = dgvLH.Width / 4;
            dgvLH.Columns[2].Width = dgvLH.Width / 4;
            dgvLH.Columns[3].Width = dgvLH.Width / 4;
            // adapter.Dispose();
        }

        private void dgvLH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            errorProvider1.Clear();
            txtMaLop.Text = dgvLH.CurrentRow.Cells[0].Value.ToString();
            txtTenLop.Text = dgvLH.CurrentRow.Cells[1].Value.ToString();
            cboMAGVCN.Text = dgvLH.CurrentRow.Cells[2].Value.ToString();
            txtSiSo.Text = dgvLH.CurrentRow.Cells[3].Value.ToString();
            txtMaLop.Enabled = false; // Không cho phép sửa Mã Lớp học
        }

        void Load_combobox()
        {
            string query = "SELECT * FROM GIAOVIEN";
            DataTable dt = DatabaseConnection.GetDataTable(query);
            cboMAGVCN.DisplayMember = "MAGV";
            cboMAGVCN.DataSource = dt;
            cboMAGVCN.Text = "";
        }

        private void cboMAGVCN_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT HOTEN FROM GIAOVIEN WHERE MAGV = '" + cboMAGVCN.Text + "'";
            DataTable dt = DatabaseConnection.GetDataTable(query);

            if (cboMAGVCN.Text == "")
                txtTenGVCN.Text = "";
            else
                txtTenGVCN.Text = dt.Rows[0][0].ToString();
        }

        bool GeneralCheck()
        {
            errorProvider1.Clear();
            bool flag = true;
            if (txtMaLop.Text == "")
            {
                txtMaLop.Focus();
                flag = false;
                // Provider
                errorProvider1.SetError(txtMaLop, "Không được bỏ trống vùng này");
            }
            if (cboMAGVCN.Text == "")
            {
                cboMAGVCN.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(cboMAGVCN, "Không được bỏ trống vùng này");
            }
            if (txtTenLop.Text == "")
            {
                txtTenLop.Focus();
                flag = false;
                //Provider;
                errorProvider1.SetError(txtTenLop, "Không được bỏ trống vùng này");
            }
            if (txtSiSo.Text == "")
            {
                txtSiSo.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtSiSo, "Không được bỏ trống vùng này");
            }
            return flag;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
