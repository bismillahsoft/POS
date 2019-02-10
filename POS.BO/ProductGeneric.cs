using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POS.BO
{

    public class ProductGeneric : BaseClass
    {
        private Int32 _PGenericID;
        public Int32 PGenericID
        {
            get { return _PGenericID; }
            set { _PGenericID = value; }
        }
        private String _PGenericName;
        public String GenericName
        {
            get { return _PGenericName; }
            set { _PGenericName = value; }
        }
        private Boolean _IsActive;
        public Boolean IsActive
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
    }
}