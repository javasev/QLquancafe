using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QUANLYNHANSU
{
    public class SDataReader
    {
        public static string connectionSTR = @"Data Source=TUAN\SQLEXPRESS02;Initial Catalog=dbtv;Integrated Security=True";

        SqlConnection con = new SqlConnection(connectionSTR);
        DataTable dt = new DataTable();

        public SqlDataReader GetNameAccount(string username, string password)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("USP_GetNameAccount", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@password", password);
            dr = cm.ExecuteReader();
            return dr;
        }

        public SqlDataReader GetTypeAccount(string username, string password)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("USP_GetTypeAccount", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@password", password);
            dr = cm.ExecuteReader();
            return dr;
        }

    }
}
