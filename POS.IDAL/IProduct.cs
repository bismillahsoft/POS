using System.Collections.Generic;

namespace POS.IDAL
{
    public interface IProduct
    {
        int Insert(BO.Product objProduct);

        int Update(BO.Product objProduct,int id);

        int DELETE(BO.Product objProduct);

        IList<BO.Product> GetProduct(int pageIndex, int pageSize, string orderBy, string sortindex);

        IList<BO.Product> GetProductByObject(BO.Product objProduct, int pageIndex, int pageSize, string orderBy, string sortindex);

        IList<BO.Product> GetProductList();
        IList<BO.Product> GetProductListByName();
        IList<BO.Product> GetProductListByCode();

        //BO.Product GetProductByID(long ProductID);

        IList<BO.Product> GetProductByOthersList(string columnsString);


        IList<BO.Product> GetProductWisePackSizeListDetail();

        int GetProductIDByCode(string productCode);

        IList<BO.Product> GetProductListWhichAreSample();

        IList<BO.Product> GetProductListWhichAreNotSample();

        IList<BO.Product> GetProductListByBrand(int ProductID);

        int Insert(List<BO.Product> ProductList);

        IList<BO.Product> GetProductByCode(string productCode);

        Dictionary<string, long> GetProductIDAndCode();

        IList<BO.Product> getProductIDByPackSizeID(int packsizeID);

        IList<BO.Product> GetProductWisePackSizeListByID(long? ProdcutID);

        int GetPackSizeIDByPackSize(string PackSize);

        IList<BO.Product> GetPackSizeIDByProductID(long ProductID);

        IList<BO.Product> GetPackSizeListByProductID(long ProductID);



        IList<BO.Product> GetProductListLikeBrand(string brandName);

        void UpdateBrandID(BO.Product objProductForUpdate);

        long GetProductIDByName(string p);




        long GetProductPackSizeIDByProducPackSize(long p, int p_2);

        IList<BO.Product> GetPackSizeByProductID(long ProductID);

        int GetBrandIDBylikeProductName(string p);
        IList<BO.Product> GetProductListWhichAreSampleByMIO(long MIOID);
    }
}