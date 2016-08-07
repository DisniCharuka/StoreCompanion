using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Companion.Classes
{
    class ItemTypesTable
    {
        [PrimaryKey, AutoIncrement]
        public int TypeId { get; set; }
        public string TypeDescription { get; set; }


        public List<ItemTypesTable> GetItemTypeDetails()
        {
            List<Classes.ItemTypesTable> itemTypes = (from p in App.conn.Table<Classes.ItemTypesTable>()
                                                      select p).ToList();
            return itemTypes;
        }
    }
    
}
