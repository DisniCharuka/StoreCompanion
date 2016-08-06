using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Companion.Classes
{
    class Item
    {
        public string LotNo { get; set; }
        public DateTime BuyingDate { get; set; }
        public double Price { get; set; }
        public int QuantityInLot { get; set; }
        public DateTime ExpDate { get; set; }
        // public byte Attachments { get; set; }  // will be implemented later..
    }
}
