using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessOrder
    {
        SqlConnection conn = new SqlConnection("Data Source=MR-UNIQUE\\SQLEXPRESS;Initial Catalog=OrderManagementSystemDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;

        public int InsertOrder(Order order)
        {
            try { conn.Open(); } catch { }

            cmd = new SqlCommand("sp_InsertOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
            cmd.Parameters.AddWithValue("@OrderDate", order.Date);

            int x = cmd.ExecuteNonQuery();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            return x;
        }

        public DataTable GetOrder(Order order)
        {
            try { conn.Open(); } catch { }

            cmd = new SqlCommand("sp_GetCustomerOrders", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public int InsertOrderItem(Order order)
        {
            try { conn.Open(); } catch { }
            cmd = new SqlCommand("sp_InsertOrderItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
            cmd.Parameters.AddWithValue("@ItemID", order.ProductID);
            cmd.Parameters.AddWithValue("@Quantity", order.Quantity);
            
            int x = cmd.ExecuteNonQuery();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return x;
        }
        public DataTable GetOrderItem(Order order)
        {
            try { conn.Open(); } catch { }
            cmd = new SqlCommand("sp_GetOrderItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OrderID", order.OrderID);

            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable GetOrderID()
        {
            try { conn.Open(); } catch { }
            cmd = new SqlCommand("sp_GetOrderID", conn);
           
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
