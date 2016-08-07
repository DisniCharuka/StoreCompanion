using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Companion.Classes
{
    public class SupplierTable
    {
        [PrimaryKey, AutoIncrement]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierTele { get; set; }

        public List<Classes.SupplierTable> GetSupplierDetails()
        {
            List<Classes.SupplierTable> suppliers = (from p in App.conn.Table<Classes.SupplierTable>()
                                                     select p).ToList();
            
            return suppliers;
        }
    }
}