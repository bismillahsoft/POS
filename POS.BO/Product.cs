using System.Collections.Generic;

namespace POS.BO
{
    public class Product : Brand
    {
        private long _ProductId;
        public long ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }

        private string _ProductCode;

        public string ProductCode
        {
            get { return _ProductCode; }
            set { _ProductCode = value; }
        }

        private string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private int _PackSizeID;

        public int PackSizeID
        {
            get { return _PackSizeID; }
            set { _PackSizeID = value; }
        }

        private decimal? _Price;

        public decimal? Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        private string _ProductShortName;

        public string ProductShortName
        {
            get { return _ProductShortName; }
            set { _ProductShortName = value; }
        }

        private ProductWisePackSize _prodPackSize = new ProductWisePackSize();

        public ProductWisePackSize ProdPackSize
        {
            get { return _prodPackSize; }
            set { _prodPackSize = value; }
        }

        private ProductGeneric _ProductGeneric = new ProductGeneric();

        public ProductGeneric ProductGeneric
        {
            get { return _ProductGeneric; }
            set { _ProductGeneric = value; }
        }


        private Brand _Brand = new Brand();

        public Brand Brand
        {
            get { return _Brand; }
            set { _Brand = value; }
        }

        private ProductCategory _ProductCategory = new ProductCategory();

        public ProductCategory ProductCategory
        {
            get { return _ProductCategory; }
            set { _ProductCategory = value; }
        }
        public string PackSize { get; set; }

        private string _GenericName;
        public string GenericName
        {
            get { return _GenericName; }
            set { _GenericName = value; }
        }
        public int CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }

        public string CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }

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

        public decimal PurchesePrice
        {
            get
            {
                return _PurchesePrice;
            }

            set
            {
                _PurchesePrice = value;
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

        public string BatchNo
        {
            get
            {
                return _BatchNo;
            }

            set
            {
                _BatchNo = value;
            }
        }

        private int _CategoryID;
        private string _CategoryName;
        private decimal _TradePrice;
        private decimal _PurchesePrice;
        private decimal _Vat;
        private decimal _MRP;
        private string _BatchNo;
    }
}