using System;

namespace POS.BO
{
    public class ProductPackSize : BaseClass
    {
        private int _PackSizeID;

        public int PackSizeID
        {
            get { return _PackSizeID; }
            set { _PackSizeID = value; }
        }

        private string _PackSize;

        public string PackSize
        {
            get { return _PackSize; }
            set { _PackSize = value; }
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
        public int Strip { get; set; }
        public int PcsPerStrip { get; set; }
        public long ProductId { get; set; }

        public bool ChkStatus { get; set; }

        public bool IsDelete { get; set; }

        public bool IsInsert { get; set; }

        public string PackSizeDescription
        {
            get
            {
                return packSizeDescription;
            }

            set
            {
                packSizeDescription = value;
            }
        }

        private string packSizeDescription;
    }
}