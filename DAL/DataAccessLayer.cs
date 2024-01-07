using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessLayer
    {
        SqlConnection conn = new SqlConnection("Data Source=MR-UNIQUE\\SQLEXPRESS;Initial Catalog=OrderManagementSystemDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;

        public int InsertCustomer(Customer customer)
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }
            cmd = new SqlCommand("sp_InsertCustomer", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@Surname", customer.Surname);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
            cmd.Parameters.AddWithValue("@Date", customer.Date);


            int x = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return x;
        }
        public int UpdateCustomer(Customer customer)
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SqlCommand("sp_UpdateCustomer", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@Surname", customer.Surname);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
            cmd.Parameters.AddWithValue("@Updated", customer.Date);

            int x = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return x;
        }
        public DataTable GetCustomers()
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SqlCommand("sp_GetCustomer", conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable SearchCustomer(string name)
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SqlCommand("sp_SearchCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }

        public int DeleteCustomer(Customer customer)
        {
            int x;

            conn.Open();
            cmd = new SqlCommand("sp_DeleteCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
            x = cmd.ExecuteNonQuery();
            conn.Close();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd = new SqlCommand("sp_GetCustomer", conn);
                x = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return x;
        }
    }
}
