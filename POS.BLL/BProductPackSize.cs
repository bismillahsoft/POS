using System;
using System.Collections.Generic;

namespace POS.BLL
{
    public class BProductPackSize : IDAL.IProductPackSize
    {
        private IDAL.IProductPackSize _iProductPackSize = null;

        public BProductPackSize()
        {
            _iProductPackSize = new DAL.DProductPackSize();
        }

        public int Insert(BO.ProductPackSize objProduct)
        {
            return _iProductPackSize.Insert(objProduct);
        }

        public int Update(BO.ProductPackSize objProduct)
        {
            return _iProductPackSize.Update(objProduct);
        }

        public int Delete(Int32 CategoryId)
        {
            return _iProductPackSize.Delete(CategoryId);
        }

        public IList<BO.ProductPackSize> GetProductPackSizeList()
        {
            return _iProductPackSize.GetProductPackSizeList();
        }
        public BO.ProductPackSize GETStripAndPcsPerStripByProductID(long productID)
        {
            return _iProductPackSize.GETStripAndPcsPerStripByProductID(productID);
        }
        public BO.ProductPackSize GetProductPackSizeByID(Int32 PackSizeID)
        {
            return _iProductPackSize.GetProductPackSizeByID(PackSizeID);
        }

        public int GetPackSizeIdByName(string packSize)
        {
            return _iProductPackSize.GetPackSizeIdByName(packSize);
        }

        public long GetPPSIdByProductIdPackSizeId(long productID, int packSizeID)
        {
            return _iProductPackSize.GetPPSIdByProductIdPackSizeId(productID, packSizeID);
        }

        public IList<BO.ProductPackSize> GetProductPackSizeByProductID(long productID)
        {
            return _iProductPackSize.GetProductPackSizeByProductID(productID);
        }


        public long InsertProductPackSize(long productID, int packSizeID)
        {
            return _iProductPackSize.InsertProductPackSize(productID, packSizeID);
        }

        public long GetPPSIDBySAPCode(string SAPCode)
        {
            return _iProductPackSize.GetPPSIDBySAPCode(SAPCode);
        }

        public long GetIDByPPSIDAndSBGID(long ppsID, int SBGID)
        {
            return _iProductPackSize.GetIDByPPSIDAndSBGID(ppsID, SBGID);
        }
        public int InsertSBGWiseProductPackSize(int sbgID, long PPSID)
        {
            return _iProductPackSize.InsertSBGWiseProductPackSize(sbgID, PPSID);
        }
    }
}