using System;

namespace POS.BO
{
    public class ProductCategory : BaseClass
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private bool _IsContinuing;

        public bool IsContinuing
        {
            get { return _IsContinuing; }
            set { _IsContinuing = value; }
        }

        private bool _IsDeleted;

        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }

        private DateTime? _LastUpdate;

        public DateTime? LastUpdate
        {
            get { return _LastUpdate; }
            set { _LastUpdate = value; }
        }
    }
}