using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Companion.Classes
{
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int SupplierTele { get; set; }

        public List<String> GetSupplierDetails() {
            List<Classes.Supplier> Suppliers = (from p in App.conn.Table<Classes.Supplier>()
                                      select p).ToList();


            foreach (Classes.Supplier obj in Suppliers) {
                this.SupplierId = obj.SupplierId;
                this.SupplierName = obj.SupplierName;
                this.SupplierTele = obj.SupplierTele;

            }



            return null;
        }

       

        //private static List<Supplier> GetSuppliers()
        //{
        //    List<Supplier> Suppliers = (from p in App.conn.Table<Classes.Supplier>()
        //                                select p).ToList();
        //    return Suppliers;
        //}

        //private void GetSupplierDetails() {
        //    private List<Supplier> supplierDetails = GetSuppliers();
        //}
    }
}


//public Supplier(string supplier_id, string supplier_name, int telephone)
//{
//    SupplierId = supplier_id;
//    SupplierName = supplier_name;
//    SupplierTele = telephone.ToString();
//}


    /* 
    retrieve each data and
    call to GetSupplierDetails() from supplierList class */


