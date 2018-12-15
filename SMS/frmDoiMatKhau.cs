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
using System.Security.Cryptography;

namespace SMS
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
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

        private void frmDoiMatKhau_MouseDown(object sender, MouseEventArgs e)
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

        public static string EnCrypt(string strEnCrypt, string key)
        {
            try
            {
                byte[] keyArr;
                byte[] EnCryptArr = UTF8Encoding.UTF8.GetBytes(strEnCrypt);
                MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
                keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
                tripDes.Key = keyArr;
                tripDes.Mode = CipherMode.ECB;
                tripDes.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = tripDes.CreateEncryptor();
                byte[] arrResult = transform.TransformFinalBlock(EnCryptArr, 0, EnCryptArr.Length);
                return Convert.ToBase64String(arrResult, 0, arrResult.Length);
            }
            catch (Exception ex) { }
            return "";
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            txtTaikhoan.Text = DatabaseConnection.TenDangNhap;
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect())
            {
                MessageBox.Show("Không kết nối được dữ liệu");
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (GeneralCheck())
            {
                string query = "SELECT * FROM " +
                    "TAIKHOAN WHERE TENDANGNHAP='" + txtTaikhoan.Text + "' AND " +
                    "MATKHAU='" + EnCrypt("LTTQ", txtMK.Text) + "'";
                if (txtMKmoi.Text != txtXacNhanMk.Text)
                {
                    //provider
                    return;
                }
                if (DatabaseConnection.CheckExist(query))
                {
                    query = "UPDATE TAIKHOAN SET " +
                            "MATKHAU='" + EnCrypt("LTTQ", txtMKmoi.Text) + "' " +
                            "WHERE TENDANGNHAP='" + txtTaikhoan.Text + "'";
                    if (DatabaseConnection.ExcuteSql(query))
                    {
                        MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatabaseConnection.SaveAction("Đổi mật khẩu", "TAIKHOAN");
                    }
                }
                else
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtTaikhoan.Text = "";
            txtMK.Text = "";
            txtMKmoi.Text = "";
            txtXacNhanMk.Text = "";
        }

        bool GeneralCheck()
        {
            errorProvider1.Clear();
            bool flag = true;
            if (txtMK.Text == "")
            {
                txtMK.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtMK, "Không được bỏ trống vùng này");
            }
            if (txtMKmoi.Text == "")
            {
                txtMKmoi.Focus();
                flag = false;
                //Provider
                errorProvider1.SetError(txtMKmoi, "Không được bỏ trống vùng này");
            }
            if (txtXacNhanMk.Text != txtMKmoi.Text)
            {
                txtXacNhanMk.Focus();
                flag = false;
                errorProvider1.SetError(txtXacNhanMk, "Không khớp mật khẩu");
                //Provider;
            }
            return flag;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
