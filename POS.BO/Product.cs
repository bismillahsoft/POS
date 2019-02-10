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

        private IList<ProductWisePackSize> _prodPackSizeList = new List<ProductWisePackSize>();

        public IList<ProductWisePackSize> ProdPackSizeList
        {
            get { return _prodPackSizeList; }
            set { _prodPackSizeList = value; }
        }

        public string PackSize { get; set; }
    }
}