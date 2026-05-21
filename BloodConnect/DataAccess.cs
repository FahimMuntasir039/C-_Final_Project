using System.Data;
using Microsoft.Data.SqlClient;

namespace BloodConnect
{
    public class DataAccess
    {
        // Named pipe works when SQL Server Browser is stopped (common on SQLEXPRESS).
        // Alternative: Server=localhost\SQLEXPRESS (requires SQL Browser service running).
        private readonly string connectionString =
            @"Server=np:\\.\pipe\MSSQL$SQLEXPRESS\sql\query;Database=BloodConnectDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                con.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
