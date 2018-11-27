﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace SMS {
    class DatabaseConnection {
        static SqlConnection sqlConnection;
        public static bool IsConnect() {
            return (sqlConnection != null && sqlConnection.State == ConnectionState.Open);
        }
        public static bool Connected() {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                return true;
            string connect = SystemInformation.UserDomainName.ToString();
            string source = "Data Source =" + connect +
                ";Initial Catalog=QuanLySinhVien;" +
                "Integrated Security=True";
            sqlConnection = new SqlConnection(source);
            sqlConnection.Open();
            return (sqlConnection.State == ConnectionState.Open);
        }
        public static DataTable GetDataTable(string query) {
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            DataTable ds = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            cmd.Dispose();
            adapter.Dispose();
            return ds;
        }
        public static bool CheckExist(string query) {
            bool flag = true;
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
                flag = false;
            cmd.Dispose();
            reader.Dispose();
            return flag;
        }
        public static bool RemoveRow(string query) {
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try {
                cmd.ExecuteNonQuery();
            }
            catch {
                cmd.Dispose();
                return false;
            }
            cmd.Dispose();
            return true;
        }
        public static bool AddRow(string query) {
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try {
                cmd.ExecuteNonQuery();
            }
            catch {
                cmd.Dispose();
                return false;
            }
            cmd.Dispose();
            return true;
        }
    }
}
