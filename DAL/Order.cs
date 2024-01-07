using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Order
    {
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }

        public Order() 
        { 

        }

        public Order(int orderID, int quantity, int productID)
        {
            OrderID = orderID;
            Quantity = quantity;
            ProductID = productID;
        }

        public Order(int customerID, DateTime date)
        {
            CustomerID = customerID;
            Date = date;
        }
        public Order(int orderID)
        {
            OrderID = orderID;
        }
    }
}
