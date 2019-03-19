using System.Collections.Generic;

namespace POS.BLL
{
    public class BProductCategory : IDAL.IProductCategory
    {
        private IDAL.IProductCategory _iProductCategory = null;

        public BProductCategory()
        {
            _iProductCategory = new DAL.DProductCategory();
        }

        public int Insert(BO.ProductCategory objProductCategory)
        {
            return _iProductCategory.Insert(objProductCategory);
        }
        public int Update(BO.ProductCategory objProductCategory)
        {
            return _iProductCategory.Update(objProductCategory);
        }
        public int Update(BO.ProductCategory objProductCategory, int Id)
        {
            return _iProductCategory.Update(objProductCategory, Id);
        }

        public int Delete(int Id)
        {
            return _iProductCategory.Delete(Id);
        }

        public IList<BO.ProductCategory> GetProductCategory(int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return _iProductCategory.GetProductCategory(pageIndex, pageSize, orderBy, sortindex);
        }

        public IList<BO.ProductCategory> GetProductCategoryByObject(BO.ProductCategory objProductCategory, int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return _iProductCategory.GetProductCategoryByObject(objProductCategory, pageIndex, pageSize, orderBy, sortindex);
        }

        public IList<BO.ProductCategory> GetProductCategoryList()
        {
            return _iProductCategory.GetProductCategoryList();
        }

        public IList<BO.ProductCategory> GetProductCategoryByOthersList(string columnsString)
        {
            return _iProductCategory.GetProductCategoryByOthersList(columnsString);
        }

        public BO.ProductCategory GetProductCategoryByID(int Id)
        {
            return _iProductCategory.GetProductCategoryByID(Id);
        }
    }
}