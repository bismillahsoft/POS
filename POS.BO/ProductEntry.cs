using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BO
{
    public class ProductEntry
    {
        private int PID { get; set; }
        private string ProductName { get; set; }
        private int ProductCode { get; set; }
        private int PackSizeID { get; set; }
        private int BrandID { get; set; }
        private int GenericNameID {get; set;}
        private int PurchasePrice { get; set; }
        private int TradePrice { get; set; }
        private int Vat { get; set; }
        private string Description { get; set; }
    }
}
