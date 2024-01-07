using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Design { get; set; }
        public int CategoryID { get; set; }
        public string Price { get; set; }
        public DateTime Date { get; set; }

        public Item(int categoryID,int itemID, string name, string design, string price, DateTime date) 
        {
            ItemID = itemID;
            Name = name;
            Design = design;
            CategoryID = categoryID;
            Price = price;
            Date = date;
        }
        public Item() 
        { 
            
        }

        public Item(int itemID)
        {
            ItemID = itemID;
        }

    }
}
