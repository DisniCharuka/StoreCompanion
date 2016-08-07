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
        public List<String> supplierDetails = new List<string>();

        [PrimaryKey, AutoIncrement]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierTele { get; set; }

        public List<Classes.SupplierTable> GetSupplierDetails()
        {
            List<Classes.SupplierTable> suppliers = (from p in App.conn.Table<Classes.SupplierTable>()
                                                     select p).ToList();


            //foreach (Classes.SupplierTable obj in suppliers)
            //{
            //    this.SupplierId = obj.SupplierId;
            //    this.SupplierName = obj.SupplierName;
            //    this.SupplierTele = obj.SupplierTele;

            //}

            return suppliers;
        }
    }
}