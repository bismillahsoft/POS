using System.Collections.Generic;


namespace POS.BO
{
    public class ProductWisePackSize
    {
        private long _PPSID;

        public long PPSID
        {
            get { return _PPSID; }
            set { _PPSID = value; }
        }

        private int _PackSizeID;

        public int PackSizeID
        {
            get { return _PackSizeID; }
            set { _PackSizeID = value; }
        }

        private long _ProductID;

        public long ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }

        public string PackSize { get; set; }

        public bool IsDelete { get; set; }

        public bool IsNewData { get; set; }

        public int Sln { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }
        public string SAPCode { get; set; }
    }
}