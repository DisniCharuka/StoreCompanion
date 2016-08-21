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
        //ItemsTable itemsTable = new ItemsTable();

        [PrimaryKey, AutoIncrement]
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int TotalQuantity { get; set; }
        public int QuantityAlert { get; set; }
        public int ExpireAlert { get; set; }
        //no of days from exp.date
        public string ProductType { get; set; }
        public List<Classes.ItemsTable> items;
        public List<Classes.ItemTable> items1;

        public List<Classes.ItemsTable> GetItemsDetails()
        {
           items = (from p in App.conn.Table<Classes.ItemsTable>()
                                                     select p).ToList();

            return items;
        }
        
        public void CalculateTotalQuantity(string itemName, int quantityInLot)
        {
            foreach (Classes.ItemTable itemRow in items1) {
                if (itemRow.ItemName == itemName) {
                    this.TotalQuantity = itemRow.QuantityInLot;
                    break;
                }
            }
            this.TotalQuantity += quantityInLot;
            this.ItemName = itemName;
            // itemsTable.TotalQuantity = TotalQuantity;
            //itemsTable.ItemName = itemName;
            App.conn.Update(this);
        }
    }
}
