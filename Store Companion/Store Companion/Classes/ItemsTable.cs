using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Companion.Classes
{
    class ItemsTable
    {
        [PrimaryKey, AutoIncrement]
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int TotalQuantity { get; set; }
        public int QuantityAlert { get; set; }
        public int ExpireAlert { get; set; }
        //no of days from exp.date
        public string ProductType { get; set; }


        public List<Classes.ItemsTable> GetItemsDetails()
        {
            List<Classes.ItemsTable> items = (from p in App.conn.Table<Classes.ItemsTable>()
                                                     select p).ToList();

            return items;
        }
    }
}
