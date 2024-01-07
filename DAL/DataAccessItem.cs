using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessItem
    {
        SqlConnection conn = new SqlConnection("Data Source=MR-UNIQUE\\SQLEXPRESS;Initial Catalog=OrderManagementSystemDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;

        //DataAccessCategory category = new DataAccessCategory();

        public DataTable GetItemsForOder()
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SqlCommand("sp_GetItemsForOder", conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
   
        public int InsertItem(Item item)
        {
            try { conn.Open(); } catch { }

            cmd = new SqlCommand("sp_InsertItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemName", item.Name);
            cmd.Parameters.AddWithValue("@CategoryID" ,item.CategoryID);
            cmd.Parameters.AddWithValue("@Manufacturer", item.Design);
            cmd.Parameters.AddWithValue("@Price", item.Price);
            cmd.Parameters.AddWithValue("@Date", item.Date);

            int x = cmd.ExecuteNonQuery();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return x;
        }
        public int UpdateItem(Item item)
        {
            try { conn.Open(); } catch { }

            cmd = new SqlCommand("sp_UpdateItem", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemID", item.ItemID);
            cmd.Parameters.AddWithValue("@ItemName", item.Name);
            cmd.Parameters.AddWithValue("@CategoryID", item.CategoryID);
            cmd.Parameters.AddWithValue("@Manufacturer", item.Design);
            cmd.Parameters.AddWithValue("@Price", item.Price);
            cmd.Parameters.AddWithValue("@Updated", item.Date);

            int x = cmd.ExecuteNonQuery();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return x;
        }
        public int DeleteItem(Item item)
        {
            try 
            { 
                conn.Open(); 
            } 
            catch 
            {
            
            }

            cmd = new SqlCommand("sp_DeleteItem", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ItemID", item.ItemID);

            int x = cmd.ExecuteNonQuery();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd = new SqlCommand("sp_GetItem", conn);
                x = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return x;
        }
        public DataTable GetItem()
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SqlCommand("sp_GetItem", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable SearchItem(string name)
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SqlCommand("sp_SearchItem", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ItemName", name);

            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
