using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessCategory
    {
        SqlConnection conn = new SqlConnection("Data Source=MR-UNIQUE\\SQLEXPRESS;Initial Catalog=OrderManagementSystemDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;

        public int InsertCategory(Category category)
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SqlCommand("sp_InsertCategory", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);

            int x = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return x;
        }

        public int DeleteCategory(Category category)
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SqlCommand("sp_DeleteCategory", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);

            int x = cmd.ExecuteNonQuery();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd = new SqlCommand("sp_GetCategory", conn);
                x = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return x;
        }

        public DataTable GetCategory()
        {
            try
            {
                conn.Open(); 
            } 
            catch 
            {

            }

            cmd = new SqlCommand("sp_GetCategory", conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
