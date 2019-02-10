using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POS.BLL
{


    public class BProduct : IDAL.IProduct
    {
        private IDAL.IProduct _iProduct = null;
        public BProduct()
        {
            _iProduct = new DAL.DProduct();

        }
        public int Insert(BO.Product objProduct)
        {
            return _iProduct.Insert(objProduct);

        }
        public int Update(BO.Product objProduct)
        {
            return _iProduct.Update(objProduct);

        }
        public int DELETE(BO.Product objProduct)
        {
            return _iProduct.DELETE(objProduct);

        }
        public IList<BO.Product> GetProduct(int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return _iProduct.GetProduct(pageIndex, pageSize, orderBy, sortindex);

        }
        public IList<BO.Product> GetProductByObject(BO.Product objProduct, int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return _iProduct.GetProductByObject(objProduct, pageIndex, pageSize, orderBy, sortindex);

        }
        public IList<BO.Product> GetProductList()
        {
            return _iProduct.GetProductList();

        }
        public IList<BO.Product> GetProductByOthersList(string columnsString)
        {
            return _iProduct.GetProductByOthersList(columnsString);

        }
        public BO.Product GetProductByID(long ProductID)
        {
            return _iProduct.GetProductByID(ProductID);

        }
        
        public IList<BO.Product> GetProductWisePackSizeListDetail()
        {
            return _iProduct.GetProductWisePackSizeListDetail();

        }

        public int GetProductIDByCode(string productCode)
        {
            return _iProduct.GetProductIDByCode(productCode);

        }
        public IList<BO.Product> GetProductListWhichAreSample()
        {
            return _iProduct.GetProductListWhichAreSample();

        }
        public IList<BO.Product> GetProductListWhichAreNotSample()
        {
            return _iProduct.GetProductListWhichAreNotSample();

        }


        public IList<BO.Product> GetProductListByBrand(int ProductID)
        {
            return _iProduct.GetProductListByBrand(ProductID);
        }


        public int Insert(List<BO.Product> ProductList)
        {
            return _iProduct.Insert(ProductList);

        }


        public IList<BO.Product> GetProductByCode(string productCode)
        {
            return _iProduct.GetProductByCode(productCode);
        }

        public IList<BO.Product> getProductIDByPackSizeID(int packsizeID)
        {
            return _iProduct.getProductIDByPackSizeID(packsizeID);
        }
        public IList<BO.Product> GetProductWisePackSizeListByID(long? ProdcutID)
        {
            return _iProduct.GetProductWisePackSizeListByID(ProdcutID);
        }
        public Dictionary<string, long> GetProductIDAndCode()
        {
            return _iProduct.GetProductIDAndCode();
        }

        public int GetPackSizeIDByPackSize(string PackSize)
        {
            return _iProduct.GetPackSizeIDByPackSize(PackSize);
        }

        public IList<BO.Product> GetPackSizeIDByProductID(long ProductID)
        {
            return _iProduct.GetPackSizeIDByProductID(ProductID);
        }

        public IList<BO.Product> GetPackSizeListByProductID(long ProductID)
        {
            return _iProduct.GetPackSizeListByProductID(ProductID); 
        }

 

        public IList<BO.Product> GetPackSizeByProductID(long ProductID)
        {
            return _iProduct.GetPackSizeByProductID(ProductID);  
        }
        public IList<BO.Product> GetProductListLikeBrand(string brandName)
        {
            return _iProduct.GetProductListLikeBrand(brandName);
        }

        public void UpdateBrandID(BO.Product objProductForUpdate)
        {
            _iProduct.UpdateBrandID(objProductForUpdate);
        }


        public long GetProductIDByName(string productName)
        {
            return _iProduct.GetProductIDByName(productName);
        }

        public long GetProductPackSizeIDByProducPackSize(long productID, int packSizeID)
        {
            return _iProduct.GetProductPackSizeIDByProducPackSize(productID, packSizeID);
        }


        public int GetBrandIDBylikeProductName(string productName)
        {
            return _iProduct.GetBrandIDBylikeProductName(productName);
        }
        public IList<BO.Product> GetProductListWhichAreSampleByMIO(long MIOID)
        {
            return _iProduct.GetProductListWhichAreSampleByMIO(MIOID); 
        }
    }
}