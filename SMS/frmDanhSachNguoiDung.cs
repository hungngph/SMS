﻿using System;
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
    public partial class frmDanhSachNguoiDung : Form
    {
        public frmDanhSachNguoiDung()
        {
            InitializeComponent();
        }

        private void frmDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            
            // Câu lệnh truy vấn Table TAIKHOAN
            string strSelect = "Select * From TAIKHOAN Where TENDANGNHAP = '" + txtTaikhoan.Text + "'";
            if (GeneralCheck())
            {
                if (DatabaseConnection.CheckExist(strSelect))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTaikhoan.Focus();
                    txtTaikhoan.SelectAll();
                }
                else
                {
                    // Câu lệnh insert dữ liệu
                    string strInsert = "Insert into TAIKHOAN values ('";
                    strInsert += txtTaikhoan.Text + "', N'";
                    strInsert += txtMK.Text + "', N'";
                    strInsert += cboQuyen.Text + "')";
                    //
                    if (DatabaseConnection.ExcuteSql(strInsert))
                    {
                        txtTaikhoan.ReadOnly = true;
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSND.SelectedRows.Count == 1)
            {
                if (GeneralCheck())
                {
                    string strUpdate = "Update TAIKHOAN Set MATKHAU = '" + txtMK.Text + "', ";
                    strUpdate += "QUYENTRUYCAP = N'" + cboQuyen.Text + "' ";
                    strUpdate += "Where TENDANGNHAP = '" + txtTaikhoan.Text + "'";
                    if (DatabaseConnection.ExcuteSql(strUpdate))
                        MessageBox.Show("Chỉnh sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Chỉnh sửa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSND.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strDelete = "Delete from TAIKHOAN Where TENDANGNHAP = '";
                    {
                        for (int i = 0; i < dgvDSND.SelectedRows.Count; i++)
                            if (!DatabaseConnection.ExcuteSql(strDelete + dgvDSND.SelectedRows[i].Cells[0].Value + "'"))
                            {
                                MessageBox.Show("Không thể xóa tài khoản có tên đăng nhập là " + dgvDSND.SelectedRows[i].Cells[0].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                        FillDataGridView();
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTaikhoan.ReadOnly = false;
            errorProvider1.Clear();
            txtTaikhoan.ReadOnly = false;
            txtTaikhoan.Text = "";
            txtMK.Text = "";
            txtXacNhanMk.Text = "";
            cboQuyen.Text = "";
            errorProvider1.Clear();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s1 = "Select * From TAIKHOAN Where ";
            string strSelect = "Select * From TAIKHOAN Where ";
            if (txtTaikhoan.Text != "")
                strSelect += "TENDANGNHAP = '" + txtTaikhoan.Text + "'and ";
            if (txtMK.Text != "")
                strSelect += "MATKHAU = '" + txtMK.Text + "' and ";
            if (cboQuyen.Text != "")
                strSelect += "QUYENTRUYCAP = N'" + cboQuyen.Text + "' and ";
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
                    dgvDSND.DataSource = DatabaseConnection.GetDataTable(strSelect);
            }
        }

        private void dgvDSND_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            errorProvider1.Clear();
            txtTaikhoan.Text = dgvDSND.CurrentRow.Cells[0].Value.ToString();
            txtMK.Text = dgvDSND.CurrentRow.Cells[1].Value.ToString();
            txtXacNhanMk.Text = txtMK.Text;
            cboQuyen.Text = dgvDSND.CurrentRow.Cells[2].Value.ToString();
            txtTaikhoan.ReadOnly = true;
        }

        void FillDataGridView()
        {
            string query = "SELECT * " +
                "FROM TAIKHOAN ";
            dgvDSND.DataSource = DatabaseConnection.GetDataTable(query);
            // adapter.Dispose();
        }

        bool GeneralCheck()
        {
            errorProvider1.Clear();
            bool flag = true;
            if (txtTaikhoan.Text == "")
            {
                txtTaikhoan.Focus();
                errorProvider1.SetError(txtTaikhoan, "Không được bỏ trống vùng này");
                flag = false;
            }
            if (txtMK.Text == "")
            {
                txtMK.Focus();
                errorProvider1.SetError(txtMK, "Không được bỏ trống vùng này");
                flag = false;
                //Provider
            }
            if (txtMK.Text != txtXacNhanMk.Text)
            {
                txtXacNhanMk.Focus();
                errorProvider1.SetError(txtXacNhanMk, "Không khớp mật khẩu");
                flag = false;
                //Provider;
            }
            if (cboQuyen.Text == "")
            {
                cboQuyen.Focus();
                flag = false;
                errorProvider1.SetError(cboQuyen, "Không được bỏ trống vùng này");
                //Provider
            }
            return flag;
        }
    }
}
