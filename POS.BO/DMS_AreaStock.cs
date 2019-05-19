using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BO
{
    public class DMS_AreaStock : BaseClass
    {
        public int AsID
        {
            get
            {
                return _AsID;
            }
            set
            {
                _AsID = value;
            }
        }

        public int AreaID
        {
            get
            {
                return _AreaID;
            }

            set
            {
                _AreaID = value;
            }
        }

        public int ProductID
        {
            get
            {
                return _ProductID;
            }

            set
            {
                _ProductID = value;
            }
        }

        public int CtnOrPkt
        {
            get
            {
                return _CtnOrPkt;
            }

            set
            {
                _CtnOrPkt = value;
            }
        }

        public int Pcs
        {
            get
            {
                return _Pcs;
            }

            set
            {
                _Pcs = value;
            }
        }

        public int Qty
        {
            get
            {
                return _Qty;
            }

            set
            {
                _Qty = value;
            }
        }

        public int Balance
        {
            get
            {
                return _Balance;
            }

            set
            {
                _Balance = value;
            }
        }

        public decimal PP
        {
            get
            {
                return _PP;
            }

            set
            {
                _PP = value;
            }
        }

        public decimal TP
        {
            get
            {
                return _TP;
            }

            set
            {
                _TP = value;
            }
        }

        public decimal MRP
        {
            get
            {
                return _MRP;
            }

            set
            {
                _MRP = value;
            }
        }

        public decimal Vat
        {
            get
            {
                return _Vat;
            }

            set
            {
                _Vat = value;
            }
        }

        public int StockType
        {
            get
            {
                return _StockType;
            }

            set
            {
                _StockType = value;
            }
        }

        public DateTime StockDate
        {
            get
            {
                return _StockDate;
            }
            set
            {
                _StockDate = value;
            }
        }

        public DateTime StockTransantionDate
        {
            get
            {
                return _StockTransantionDate;
            }
            set
            {
                _StockTransantionDate = value;
            }
        }

        public int ProductName { get; set; }
        public string Remarks { get; set; }

        public int Strip
        {
            get
            {
                return _Strip;
            }

            set
            {
                _Strip = value;
            }
        }

        public int PcsPerStrip
        {
            get
            {
                return _PcsPerStrip;
            }

            set
            {
                _PcsPerStrip = value;
            }
        }

        private int _AsID;
        private int _AreaID;
        private int _ProductID;
        private int _CtnOrPkt;
        private int _Pcs;
        private int _Qty;
        private int _Strip;
        private int _PcsPerStrip;
        private int _Balance;
        private decimal _PP;
        private decimal _TP;
        private decimal _MRP;
        private decimal _Vat;
        private int _StockType;
        private DateTime _StockDate;
        private DateTime _StockTransantionDate; 
    }
}
