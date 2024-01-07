using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer client = new DataAccessLayer();
        DataAccessCategory description = new DataAccessCategory();
        DataAccessItem  product = new DataAccessItem();
        DataAccessOrder request = new DataAccessOrder();

        public int InsertClient(Customer customer)
        {
            return client.InsertCustomer(customer);
        }
        public int UpdateClient(Customer customer)
        {
            return client.UpdateCustomer(customer);
        }
        public int DeleteClient(Customer customer)
        {
            return client.DeleteCustomer(customer);
        }
        public DataTable GetClients()
        {
            return client.GetCustomers();
        }
        public DataTable SearchClient(string name)
        {
            return client.SearchCustomer(name);
        }

        //Methods for Category

        public int InsertDescription(Category category)
        {
            return description.InsertCategory(category);
        }

        public int DeleteDescription(Category category)
        {
            return description.DeleteCategory(category);
        }
        public DataTable GetDescription()
        {
            return description.GetCategory();
        }

        //Methods for Item
        public int InsertProduct(Item item)
        {
            return product.InsertItem(item);
        }
        public int UpdateProduct(Item item)
        {
            return product.UpdateItem(item);
        }
        public int DeleteProduct(Item item)
        {
            return product.DeleteItem(item);
        }
        public DataTable GetProduct()
        {
            return product.GetItem();
        }
        public DataTable SearchProduct(string name)
        {
            return product.SearchItem(name);
        }

        //Methods For Orders
        public DataTable GetProductForOder()
        {
            return product.GetItemsForOder();
        }
        public int InsertOrder(Order order)
        {
            return request.InsertOrder(order);
        }
        public DataTable GetCustomerOrders(Order order)
        {
            return request.GetOrder(order);
        }
        public int InsertOrderItem(Order order)
        {
            return request.InsertOrderItem(order);
        }
        public DataTable GetOrderID()
        {
            return request.GetOrderID();
        }
        public DataTable GetOrderItem(Order order)
        {
            return request.GetOrderItem(order);
        }
    }
}
