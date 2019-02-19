using System.Collections.Generic;

namespace POS.BO
{
    public class ProductPrice
    {
        private long _ProductId;
        public long ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }

        private long _PPID;
        public long PPID
        {
            get { return _PPID; }
            set { _PPID = value; }
        }

        private decimal _PurchasePrice;

        public decimal PurchasePrice
        {
            get { return _PurchasePrice; }
            set { _PurchasePrice = value; }
        }

        private decimal _MRP;

        public decimal MRP
        {
            get { return _MRP; }
            set { _MRP = value; }
        }

        private decimal _Vat;

        public decimal Vat
        {
            get { return _Vat; }
            set { _Vat = value; }
        }

        private decimal _TradePrice;
        public decimal TradePrice
        {
            get
            {
                return _TradePrice;
            }

            set
            {
                _TradePrice = value;
            }
        }

    }
}