using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POS.BO
{

    public class Brand : BaseClass
    {
        private int _BrandID;
        public int BrandID
        {
            get { return _SBGBrandID; }
            set { _SBGBrandID = value; }
        }
        private int _SBGBrandID;
        public int SBGBrandID
        {
            get { return _SBGBrandID; }
            set { _SBGBrandID = value; }
        }
        private string _BrandName;
        public string BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }
        private string _BrandDescription;
        public string BrandDescription
        {
            get { return _BrandDescription; }
            set { _BrandDescription = value; }
        }

        public long TerritoryID { get; set; }

        public int GenericID { get; set; }
    }
}