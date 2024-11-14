using System.Data.SqlClient;
using System;
using System.Data;


namespace QuanLiMayBay
{
    public class DatabaseConnection
    {
        private readonly string connectionString =
            "Data Source=Nign_Doung\\SQLEXPRESS;Initial Catalog=SanBay;Integrated Security=True";
        private SqlConnection conn;

        // Constructor to initialize the connection with the defined connection string
        public DatabaseConnection()
        {
            conn = new SqlConnection(connectionString);
        }

        // Method to open the connection
        public bool MoKetNoi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi mở kết nối: {ex.Message}");
                return false;
            }
        }

        // Method to close the connection
        public void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Method to fetch data from the database and return it as a DataTable
        public DataTable LayDuLieu(string query, SqlParameter[] parameters = null)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                if (parameters != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                return null;
            }
        }

        // Method to fetch data from the database and return it as a DataSet
        public DataSet LayDataSet(string query, SqlParameter[] parameters = null)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                if (parameters != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy DataSet: {ex.Message}");
                return null;
            }
        }

        // Method to execute a command (INSERT, UPDATE, DELETE) and return the result
        public bool ThucThiLenh(string query, SqlParameter[] parameters = null)
        {
            try
            {
                MoKetNoi();  // Open the connection
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                int result = cmd.ExecuteNonQuery();
                return result > 0;  // Return true if at least one row was affected
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thực thi lệnh: {ex.Message}");
                return false;
            }
            finally
            {
                DongKetNoi();  // Close the connection
            }
        }
    }
}
