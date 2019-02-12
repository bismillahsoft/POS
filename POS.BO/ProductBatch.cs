using System;

namespace POS.BO
{
    public class ProductBatch : BaseClass
    {
        private long _BatchID;

        public long BatchID
        {
            get { return _BatchID; }
            set { _BatchID = value; }
        }

        private string _BatchNo;

        public string BatchNo
        {
            get { return _BatchNo; }
            set { _BatchNo = value; }
        }

        private long _ProductID;

        public long ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }

        private bool _IsActive;

        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }

        private DateTime _LastUpdate;

        public DateTime LastUpdate
        {
            get { return _LastUpdate; }
            set { _LastUpdate = value; }
        }

        public string ProductName { get; set; }

        public string ProductCode { get; set; }
        public string BatchDescription { get; set; }
        public string BatchName { get; set; }
    }
}