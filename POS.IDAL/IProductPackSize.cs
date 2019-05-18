using System;
using System.Collections.Generic;

namespace POS.IDAL
{
    public interface IProductPackSize
    {
        int Insert(BO.ProductPackSize objProduct);

        int Update(BO.ProductPackSize objProduct);

        int Delete(Int32 PackSizeID);

        IList<BO.ProductPackSize> GetProductPackSizeList();

        BO.ProductPackSize GetProductPackSizeByID(Int32 PackSizeID);

        int GetPackSizeIdByName(string packSize);

        long GetPPSIdByProductIdPackSizeId(long productID, int packSizeID);
        IList<BO.ProductPackSize> GETStripAndPcsPerStripByProductID(long produtID);

        IList<BO.ProductPackSize> GetProductPackSizeByProductID(long productID);

        long InsertProductPackSize(long productID, int packSizeID);

        long GetPPSIDBySAPCode(string SAPCode);

        long GetIDByPPSIDAndSBGID(long ppsID, int SBGID);

        int InsertSBGWiseProductPackSize(int sbgID, long PPSID);
    }
}