using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }

        public Customer() 
        {

        }

        public Customer(int customerID, string name, string surname, string email, string address, DateTime date)
        {
            CustomerID = customerID;
            Name = name;
            Surname = surname;
            Email = email;
            Address = address;
            Date = date;
        }
        public Customer(int customerID)
        {
            CustomerID = customerID;
        }
        public Customer(string name)
        {
            Name = name;
        }
    }
}
