using System.Collections.Generic;

namespace POS.BLL
{
    public class BProductBatch : IDAL.IProductBatch
    {
        private IDAL.IProductBatch _iProductBatch = null;

        public BProductBatch()
        {
            _iProductBatch = new DAL.DProductBatch();
        }

        public int Insert(BO.ProductBatch objProductBatch)
        {
            return _iProductBatch.Insert(objProductBatch);
        }

        public int Update(BO.ProductBatch objProductBatch, long ProductID)
        {
            return _iProductBatch.Update(objProductBatch, ProductID);
        }

        public int Delete(long ProductID)
        {
            return _iProductBatch.Delete(ProductID);
        }

        public IList<BO.ProductBatch> GetProductBatch(int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return _iProductBatch.GetProductBatch(pageIndex, pageSize, orderBy, sortindex);
        }

        public IList<BO.ProductBatch> GetProductBatchByObject(BO.ProductBatch objProductBatch, int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return _iProductBatch.GetProductBatchByObject(objProductBatch, pageIndex, pageSize, orderBy, sortindex);
        }

        public IList<BO.ProductBatch> GetProductBatchList()
        {
            return _iProductBatch.GetProductBatchList();
        }

        public IList<BO.ProductBatch> GetProductIDWiseProductBactchList(int productID)
        {
            return _iProductBatch.GetProductIDWiseProductBactchList(productID);
        }

        public IList<BO.ProductBatch> GetProductBatchByOthersList(string columnsString)
        {
            return _iProductBatch.GetProductBatchByOthersList(columnsString);
        }

        public BO.ProductBatch GetProductBatchByID(long ProductID)
        {
            return _iProductBatch.GetProductBatchByID(ProductID);
        }

        public long? GetProductBatchIDByCode(string bathcNo)
        {
            return _iProductBatch.GetProductBatchIDByCode(bathcNo);
        }
    }
}