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
    public partial class frmLopHoc : Form {
        public frmLopHoc() {
            InitializeComponent();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
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
                    txtMaLop.SelectAll();
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
                        txtMaLop.ReadOnly = true;
                    }
                    else
                        MessageBox.Show("Thêm Lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }

        

        private void btnSua_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Chỉnh sửa Lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtMaLop.ReadOnly = false;
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboMAGVCN.Text = "";
            txtTenGVCN.Text = "";
            txtSiSo.Text = "";
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
            txtMaLop.ReadOnly = true; // Không cho phép sửa Mã Lớp học
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
    }
}
