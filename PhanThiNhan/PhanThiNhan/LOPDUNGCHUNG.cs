﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PhanThiNhan
{
    class LOPDUNGCHUNG
    {
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\demo_PhanThiNhan\PhanThiNhan\PhanThiNhan\PhanThiNhan\PhanThiNhan.mdf;Integrated Security=True";
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
