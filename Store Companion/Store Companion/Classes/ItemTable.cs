using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Store_Companion.Classes
{
    class ItemTable
    {
        [PrimaryKey, AutoIncrement]
        public int LotNo { get; set; }
        public string ItemName { get; set; }
       // public DateTime BuyingDate { get; set; }
        public double Price { get; set; }
        public int QuantityInLot { get; set;
            }
       // public DateTime ExpDate { get; set; }
        // public byte Attachments { get; set; }  // will be implemented later..
        public string SupplierName { get; set; }

        public List<Classes.ItemTable> GetItemDetails()
        {
            
            List<Classes.ItemTable> item = (from p in App.conn.Table<Classes.ItemTable>()
                                                select p).ToList();
            
            return item;
        }

      
    }
}
