using System.Collections.Generic;

namespace POS.IDAL
{
    public interface IProductCategory
    {
        int Insert(BO.ProductCategory objProductCategory);
        int Update(BO.ProductCategory objProductCategory);
        int Update(BO.ProductCategory objProductCategory, int Id);

        int Delete(int Id);

        IList<BO.ProductCategory> GetProductCategory(int pageIndex, int pageSize, string orderBy, string sortindex);

        IList<BO.ProductCategory> GetProductCategoryByObject(BO.ProductCategory objProductCategory, int pageIndex, int pageSize, string orderBy, string sortindex);

        IList<BO.ProductCategory> GetProductCategoryList();

        BO.ProductCategory GetProductCategoryByID(int Id);

        IList<BO.ProductCategory> GetProductCategoryByOthersList(string columnsString);
    }
}