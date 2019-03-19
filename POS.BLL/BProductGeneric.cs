using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POS.BLL
{


    public class BProductGeneric : IDAL.IProductGeneric
    {
        private IDAL.IProductGeneric _iProductGeneric = null;
        public BProductGeneric()
        {
            _iProductGeneric = new DAL.DProductGeneric();

        }
        public Int32 Insert(BO.ProductGeneric objProductGeneric)
        {
            return _iProductGeneric.Insert(objProductGeneric);

        }
        public Int32 Update(BO.ProductGeneric objProductGeneric)
        {
            return _iProductGeneric.Update(objProductGeneric);

        }
        public Int32 Update(BO.ProductGeneric objProductGeneric, Int32 PGenericID)
        {
            return _iProductGeneric.Update(objProductGeneric, PGenericID);

        }
        public Int32 Delete(Int32 PGenericID)
        {
            return _iProductGeneric.Delete(PGenericID);

        }
        public IList<BO.ProductGeneric> GetProductGeneric(Int32 pageIndex, Int32 pageSize, String orderBy, String sortindex)
        {
            return _iProductGeneric.GetProductGeneric(pageIndex, pageSize, orderBy, sortindex);

        }
        public IList<BO.ProductGeneric> GetProductGenericByObject(BO.ProductGeneric objProductGeneric, Int32 pageIndex, Int32 pageSize, String orderBy, String sortindex)
        {
            return _iProductGeneric.GetProductGenericByObject(objProductGeneric, pageIndex, pageSize, orderBy, sortindex);

        }
        public IList<BO.ProductGeneric> GetProductGenericList()
        {
            return _iProductGeneric.GetProductGenericList();

        }
        public IList<BO.ProductGeneric> GetProductGenericByOthersList(String columnsString)
        {
            return _iProductGeneric.GetProductGenericByOthersList(columnsString);

        }
        public BO.ProductGeneric GetProductGenericByID(Int32 PGenericID)
        {
            return _iProductGeneric.GetProductGenericByID(PGenericID);

        }


        public int GetGenericIDByName(string genericName)
        {
            return _iProductGeneric.GetGenericIDByName(genericName);

        }
    }
}