using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POS.IDAL
{


    public interface IProductBatch
    {
        int Insert(BO.ProductBatch objProductBatch);

        int Update(BO.ProductBatch objProductBatch, long ProductID);

        int Delete(long ProductID);

        IList<BO.ProductBatch> GetProductBatch(int pageIndex, int pageSize, string orderBy, string sortindex);

        IList<BO.ProductBatch> GetProductBatchByObject(BO.ProductBatch objProductBatch, int pageIndex, int pageSize, string orderBy, string sortindex);

        IList<BO.ProductBatch> GetProductBatchList();
        BO.ProductBatch GetProductBatchByID(long ProductID);
        IList<BO.ProductBatch> GetProductBatchByOthersList(string columnsString);
        IList<BO.ProductBatch> GetProductIDWiseProductBactchList(int productID);

        long? GetProductBatchIDByCode(string bathcNo);
    }
}