using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SMS
{
    class DatabaseConnection
    {
        public static bool isAdmin = false;
        public static string MaGV;
        // Thành phần kết nối
        static SqlConnection sqlConnection;

        // Hàm kiểm tra kết nối sql có thành công hay không
        public static bool IsConnect()
        {
            return (sqlConnection != null && sqlConnection.State == ConnectionState.Open);
        }

        // Hàm kết nối sql
        public static bool Connected()
        {
            if (IsConnect())
                return true;
            string connect = SystemInformation.UserDomainName.ToString();
            string source = "Data Source =" + connect +
                ";Initial Catalog=QuanLyHocSinh;" +
                "Integrated Security=True";
            sqlConnection = new SqlConnection(source);
            sqlConnection.Open();
            return (sqlConnection.State == ConnectionState.Open);
        }

        // Lấy table thông qua DataTable
        public static DataTable GetDataTable(string query)
        {
            DataTable ds = new DataTable();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            adapter.Dispose();
            ds.Dispose();
            cmd.Dispose();
            return ds;
        }
        // Kiểm tra đã tồn tại Row kèm theo khóa chính
        public static bool CheckExist(string query)
        {
            bool flag = true;
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
                flag = false;
            cmd.Dispose();
            reader.Dispose();
            return flag;
        }
        // Thực thi câu lệnh sql
        public static bool ExcuteSql(string query)
        {
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                cmd.Dispose();
                return false;
            }
            return true;
        }
    }
}