using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using POS.BO;
using POS.COMMON;

namespace POS.DAL
{
    public class DProduct : DCommon, IDAL.IProduct
    {
        public int Insert(BO.Product objProduct)
        {
            try
            {
                int returnProductID = 0;
                int transationStatus = 0;
                using (var connection = new DCommon().CreateCon())
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = connection.CreateCommand();
                    SqlTransaction transaction = null;
                    try
                    {
                        // BeginTransaction() Requires Open Connection
                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        transaction = connection.BeginTransaction();
                        // Assign Transaction to Command
                        da.SelectCommand.Connection = connection;
                        da.SelectCommand.Transaction = transaction;
                        da.SelectCommand.CommandText = "[POS_SET_SP_INSERT_SET_Product]";
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.BigInt);
                        da.SelectCommand.Parameters["@ProductID"].Direction = ParameterDirection.Output;
                        da.SelectCommand.Parameters.Add("@GenericID", SqlDbType.Int).Value = objProduct.ProductGeneric.PGenericID;
                        da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = objProduct.Brand.BrandID;
                        da.SelectCommand.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar, 500).Value = objProduct.ProductName;
                        da.SelectCommand.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 500).Value = objProduct.Description;
                        da.SelectCommand.Parameters.Add("@ProductCategoryID", System.Data.SqlDbType.Int).Value = objProduct.ProductCategory.Id;
                        da.SelectCommand.Parameters.Add("@BatchCode", System.Data.SqlDbType.VarChar, 50).Value = objProduct.BatchNo;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Connection = connection;

                        transationStatus = da.SelectCommand.ExecuteNonQuery();
                        long ProductID = (long)da.SelectCommand.Parameters["@ProductID"].Value;
                        returnProductID = Convert.ToInt32(ProductID);
                        da.SelectCommand.Parameters.Clear();
                        if (transationStatus <= 0)
                        {
                            transaction.Rollback();
                            //break;
                        }
                        else
                        {
                            da.SelectCommand.CommandText = "POS_SET_SP_INSERT_SET_ProductWisePackSize";
                            da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = ProductID;
                            da.SelectCommand.Parameters.Add("@PackSizeID", System.Data.SqlDbType.Int).Value = objProduct.ProdPackSize.PackSizeID;
                            da.SelectCommand.Parameters.Add("@ProductCode", System.Data.SqlDbType.VarChar, 50).Value = objProduct.ProdPackSize.ProductCode;
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            transationStatus = da.SelectCommand.ExecuteNonQuery();
                            da.SelectCommand.Parameters.Clear();
                            if (transationStatus > 0)
                            {
                                da.SelectCommand.CommandText = "POS_SET_SP_INSERT_SET_ProductPrice";
                                da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = ProductID;
                                da.SelectCommand.Parameters.Add("@PP", System.Data.SqlDbType.Decimal, 3).Value = objProduct.ProductPrice.PurchasePrice;
                                da.SelectCommand.Parameters.Add("@MRP", System.Data.SqlDbType.Decimal, 3).Value = objProduct.ProductPrice.MRP;
                                da.SelectCommand.Parameters.Add("@Vat", System.Data.SqlDbType.Decimal, 3).Value = objProduct.ProductPrice.Vat;
                                da.SelectCommand.Parameters.Add("@TP", System.Data.SqlDbType.Decimal, 3).Value = objProduct.ProductPrice.TradePrice;
                                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                                transationStatus = da.SelectCommand.ExecuteNonQuery();
                            }
                            da.SelectCommand.Parameters.Clear();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
                return returnProductID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(List<BO.Product> objProductList)
        {
            try
            {
                int returnStatus = 0;
                int transationStatus = 0;
                using (var connection = new DCommon().CreateCon())
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = connection.CreateCommand();
                    SqlTransaction transaction = null;

                    try
                    {
                        // BeginTransaction() Requires Open Connection
                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        transaction = connection.BeginTransaction();
                        // Assign Transaction to Command
                        da.SelectCommand.Connection = connection;
                        da.SelectCommand.Transaction = transaction;
                        da.SelectCommand.CommandText = "[POS_SET_SP_INSERT_SET_Product]";
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Connection = connection;

                        foreach (var objProduct in objProductList)
                        {
                            da.SelectCommand.CommandText = "[POS_SET_SP_INSERT_SET_Product]";
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.BigInt);
                            da.SelectCommand.Parameters["@ProductID"].Direction = ParameterDirection.Output;
                            da.SelectCommand.Parameters.Add("@ProductCode", System.Data.SqlDbType.VarChar, 500).Value = objProduct.ProductCode;
                            da.SelectCommand.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar, 500).Value = objProduct.ProductName;
                            da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = objProduct.BrandID;
                            da.SelectCommand.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 500).Value = objProduct.Description;
                            da.SelectCommand.Parameters.Add("@TypeId", System.Data.SqlDbType.Int).Value = null;
                            da.SelectCommand.Parameters.Add("@Price", System.Data.SqlDbType.Decimal).Value = objProduct.Price;
                            transationStatus = da.SelectCommand.ExecuteNonQuery();
                            long ProductID = (long)da.SelectCommand.Parameters["@ProductID"].Value;
                            da.SelectCommand.Parameters.Clear();
                            if (transationStatus <= 0)
                            {
                                transaction.Rollback();
                                break;
                            }

                            else
                            {
                                foreach (var objPackSize in objProduct.ProdPackSizelist)
                                {
                                    #region OrderDetail

                                    da.SelectCommand.CommandText = "[POS_SET_SP_INSERT_SET_ProductWisePackSize]";
                                    da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.BigInt).Value = ProductID;
                                    //da.SelectCommand.Parameters.Add("@PackSizeID", System.Data.SqlDbType.Int).Value =objPackSize.PackSizeID;
                                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                                    transationStatus = da.SelectCommand.ExecuteNonQuery();
                                    da.SelectCommand.Parameters.Clear();

                                    #endregion OrderDetail
                                }
                            }
                        }
                        if (transationStatus > 0)
                        {
                            transaction.Commit();
                            returnStatus = 1;
                        }
                        else
                        {
                            returnStatus = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        returnStatus = 0;
                    }
                    finally
                    {
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
                return returnStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int Update(Product objProduct)
        //{
        //    throw new NotImplementedException();
        //}

        public int DELETE(Product objProduct)
        {
            throw new NotImplementedException();
        }

        public int Update(BO.Product objProduct, int ID)
        {
            try
            {
                int returnProductID = 0;
                int transationStatus = 0;
                using (var connection = new DCommon().CreateCon())
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = connection.CreateCommand();
                    SqlTransaction transaction = null;
                    try
                    {
                        // BeginTransaction() Requires Open Connection
                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        transaction = connection.BeginTransaction();
                        // Assign Transaction to Command
                        da.SelectCommand.Connection = connection;
                        da.SelectCommand.Transaction = transaction;
                        da.SelectCommand.CommandText = "POS_SP_Update_Product";
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@ProductID", SqlDbType.Int).Value = ID;
                        da.SelectCommand.Parameters.Add("@GenericID", SqlDbType.Int).Value = objProduct.ProductGeneric.PGenericID;
                        da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = objProduct.Brand.BrandID;
                        da.SelectCommand.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar, 200).Value = objProduct.ProductName;
                        da.SelectCommand.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 400).Value = objProduct.Description;
                        da.SelectCommand.Parameters.Add("@ProductCategoryID", System.Data.SqlDbType.TinyInt).Value = objProduct.ProductCategory.Id;
                        da.SelectCommand.Parameters.Add("@BatchCode", System.Data.SqlDbType.VarChar, 50).Value = objProduct.BatchNo;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Connection = connection;
                        transationStatus = da.SelectCommand.ExecuteNonQuery();
                        da.SelectCommand.Parameters.Clear();
                        if (transationStatus <= 0)
                        {
                            transaction.Rollback();
                            //break;
                        }
                        else
                        {
                            da.SelectCommand.CommandText = "POS_SP_Update_ProductWisePackSize";
                            da.SelectCommand.Parameters.Add("@PPSID", System.Data.SqlDbType.BigInt).Value = objProduct.ProdPackSize.PPSID;
                            da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = ID;
                            da.SelectCommand.Parameters.Add("@PackSizeID", System.Data.SqlDbType.Int).Value = objProduct.ProdPackSize.PackSizeID;
                            da.SelectCommand.Parameters.Add("@ProductCode", System.Data.SqlDbType.VarChar, 500).Value = objProduct.ProdPackSize.ProductCode;
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            transationStatus = da.SelectCommand.ExecuteNonQuery();
                            da.SelectCommand.Parameters.Clear();
                            if (transationStatus > 0)
                            {
                                da.SelectCommand.CommandText = "POS_SP_Update_SET_ProductPrice";
                                da.SelectCommand.Parameters.Add("@PPID", System.Data.SqlDbType.BigInt).Value = objProduct.ProductPrice.PPID;
                                da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = ID;
                                da.SelectCommand.Parameters.Add("@PP", System.Data.SqlDbType.Decimal, 3).Value = objProduct.ProductPrice.PurchasePrice;
                                da.SelectCommand.Parameters.Add("@MRP", System.Data.SqlDbType.Decimal, 3).Value = objProduct.ProductPrice.MRP;
                                da.SelectCommand.Parameters.Add("@Vat", System.Data.SqlDbType.Decimal, 3).Value = objProduct.ProductPrice.Vat;
                                da.SelectCommand.Parameters.Add("@TP", System.Data.SqlDbType.Decimal, 3).Value = objProduct.ProductPrice.TradePrice;
                                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                                transationStatus = da.SelectCommand.ExecuteNonQuery();
                            }
                            da.SelectCommand.Parameters.Clear();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
                return transationStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public int DELETE(BO.Product objProduct)
        //{
        //    try
        //    {
        //        int retunstatus = 0;
        //        int transationStatus = 0;
        //        using (var connection = new DCommon().CreateCon())
        //        {
        //            SqlDataAdapter da = new SqlDataAdapter();
        //            da.SelectCommand = connection.CreateCommand();
        //            SqlTransaction transaction = null;
        //            try
        //            {
        //                // BeginTransaction() Requires Open Connection
        //                if (connection.State == System.Data.ConnectionState.Closed)
        //                {
        //                    connection.Open();
        //                }
        //                transaction = connection.BeginTransaction();
        //                // Assign Transaction to Command
        //                da.SelectCommand.Connection = connection;
        //                da.SelectCommand.Transaction = transaction;
        //                da.SelectCommand.CommandText = "DCR_SP_DELETE_Product";
        //                da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //                da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.BigInt).Value = objProduct.ProductId;
        //                da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //                da.SelectCommand.Connection = connection;
        //                transationStatus = da.SelectCommand.ExecuteNonQuery();
        //                da.SelectCommand.Parameters.Clear();
        //                if (transationStatus <= 0)
        //                {
        //                    transaction.Rollback();
        //                    //break;
        //                }
        //                else
        //                {
        //                    foreach (var objPackSize in objProduct.ProdPackSizeList)
        //                    {
        //                        #region InsertProductWisePackSize

        //                        da.SelectCommand.CommandText = "DCR_SP_DELETE_ProductWisePackSize";
        //                        da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.BigInt).Value = objProduct.ProductId;
        //                        da.SelectCommand.Parameters.Add("@PackSizeID", System.Data.SqlDbType.Int).Value = objPackSize.PackSizeID;
        //                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //                        transationStatus = da.SelectCommand.ExecuteNonQuery();
        //                        da.SelectCommand.Parameters.Clear();

        //                        #endregion InsertProductWisePackSize
        //                    }
        //                }

        //                transaction.Commit();
        //            }
        //            catch (Exception ex)
        //            {
        //                transaction.Rollback();
        //            }
        //            finally
        //            {
        //                if (connection.State == System.Data.ConnectionState.Open)
        //                {
        //                    connection.Close();
        //                }
        //                if (transationStatus == 1)
        //                {
        //                    retunstatus = 1;
        //                }
        //            }
        //        }
        //        return retunstatus;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        public IList<BO.Product> GetProductList()
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "[POS_SP_GET_SET_Product]";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                DataTable dt = ds.Tables[0];
                List<POS.BO.Product> objProductList = new List<POS.BO.Product>();
                POS.BO.Product obj = null;
                long productID = 0;
                // string packSize = "";
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt64(row["ProductId"]) != productID)
                    {
                        productID = Convert.ToInt64(row["ProductId"]);
                        obj = new BO.Product();
                        obj.Sln = index++;
                        obj.ProductId = productID;
                        obj.ProductName = row["ProductName"].ToString();
                        obj.ProductCode = row["ProductCode"].ToString();
                        obj.ProdPackSize.PackSizeID = Convert.ToInt32(row["PackSizeID"]);
                        obj.PackSize = Convert.ToString(row["PackSize"]);
                        obj.Brand.BrandID = Convert.ToInt32(row["BrandID"]);
                        obj.BrandName = row["Brand"].ToString();
                        obj.ProductGeneric.PGenericID = Convert.ToInt32(row["GenericID"]);
                        obj.GenericName = row["GenericName"].ToString();
                        obj.ProductCategory.Id = Convert.ToInt32(row["ProductCategoryID"]);
                        obj.CategoryName = row["CategoryName"].ToString();
                        obj.ProductPrice.PPID = Convert.ToInt32(row["PPID"]);
                        obj.PurchesePrice = Convert.ToDecimal(row["PurchesePrice"]);
                        obj.TradePrice = Convert.ToDecimal(row["TradePrice"]);
                        obj.Vat = Convert.ToDecimal(row["Vat"]);
                        obj.MRP = Convert.ToDecimal(row["MRP"]);
                        obj.ProdPackSize.PPSID = Convert.ToInt64(row["PPSID"]);
                        //obj.ProductPrice.TradePrice = Convert.ToDecimal(row["TradePrice"]);
                        //obj.ProductPrice.Vat = Convert.ToDecimal(row["Vat"]);
                        //obj.ProductPrice.MRP = Convert.ToDecimal(row["MRP"]);
                        obj.BatchNo = row["BatchNo"].ToString();
                        obj.Description = row["Description"].ToString();


                        objProductList.Add(obj);
                        // packSize = "";
                    }
                    //if (packSize != "")
                    //{
                    //    packSize = packSize + "," + row["PackSize"].ToString();
                    //    obj.PackSize = packSize;
                    //}
                    //else
                    //{
                    //    packSize = row["PackSize"].ToString();
                    //    obj.PackSize = packSize;
                    //}
                }
                return objProductList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IList<POS.BO.Product> GetProduct(int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return new List<BO.Product>();
        }

        public IList<BO.Product> GetProductByObject(BO.Product objProduct, int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return new List<BO.Product>();
        }

        public int GetPackSizeIDByPackSize(string PackSize)
        {
            int PackSizeid = 0;
            querry = @"SELECT top 1   PackSizeID
              FROM    ProductPackSize   where PackSize = '" + PackSize + "' and ProductPackSize.IsActive = 1";
            DataTable dt = ExecuteQuerry(querry).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                PackSizeid = Convert.ToInt32(row["PackSizeID"].ToString());
            }
            return PackSizeid;
        }

        public IList<BO.Product> GetProductListWhichAreSample()
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GetProductListWhichAreSample";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                DataTable dt = ds.Tables[0];
                List<POS.BO.Product> objDoctorList = new List<POS.BO.Product>();
                POS.BO.Product obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Product();
                    obj.Sln = index++;
                    obj.ProductId = Convert.ToInt64(row["ProductId"]);

                    obj.ProductCode = row["ProductCode"].ToString();
                    obj.ProductName = row["ProductName"].ToString() + "(" + row["PackSize"].ToString() + ")";
                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BO.Product> GetProductListWhichAreNotSample()
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GetProductListWhichAreNotSample";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                DataTable dt = ds.Tables[0];
                List<POS.BO.Product> objDoctorList = new List<POS.BO.Product>();
                POS.BO.Product obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Product();
                    obj.Sln = index++;
                    obj.ProductId = Convert.ToInt64(row["ProductId"]);

                    obj.ProductCode = row["ProductCode"].ToString();
                    obj.ProductName = row["ProductName"].ToString() + "(" + row["PackSize"].ToString() + ")";
                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<BO.Product> GetProductListWhichAreSampleByMIO(long MIOID)
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_ProductListWhichAreSampleByMIO";
                da.SelectCommand.Parameters.Add("@EmployeeID", System.Data.SqlDbType.BigInt).Value = MIOID;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                DataTable dt = ds.Tables[0];
                List<POS.BO.Product> objDoctorList = new List<POS.BO.Product>();
                POS.BO.Product obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Product();
                    obj.Sln = index++;
                    obj.ProductId = Convert.ToInt64(row["ProductId"]);
                    obj.ProductName = row["ProductName"].ToString();
                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public IList<BO.Product> GetPackSizeIDByProductID(long ProductID)
        //{
        //    try
        //    {
        //        return GetProductWisePackSizeList(ProductID);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public IList<BO.Product> GetProductWisePackSizeListDetail()
        //{
        //    try
        //    {
        //        return GetProductWisePackSizeList(null);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public IList<BO.Product> GetProductWisePackSizeListByID(long? ProdcutID)
        //{
        //    try
        //    {
        //        return GetProductWisePackSizeList(ProdcutID);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //private IList<BO.Product> GetProductWisePackSizeList(long? ProductId, string ProductCode = null)
        //{
        //    try
        //    {
        //        SqlConnection con = CreateCon();
        //        SqlDataAdapter da = new SqlDataAdapter();
        //        da.SelectCommand = new SqlCommand();
        //        da.SelectCommand.CommandText = "DCR_SP_GET_ProductWisePackSizeList";
        //        da.SelectCommand.Parameters.Add("@ProductId", System.Data.SqlDbType.BigInt).Value = ProductId;
        //        da.SelectCommand.Parameters.Add("@ProductCode", System.Data.SqlDbType.VarChar, 50).Value = ProductCode;
        //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        da.SelectCommand.Connection = con;

        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //        DataTable dt = ds.Tables[0];
        //        List<POS.BO.Product> objDoctorList = new List<POS.BO.Product>();
        //        BO.Product objProduct = null;
        //        BO.ProductWisePackSize objProductPackSize = null;
        //        int index = 1;
        //        long productID = 0;
        //        foreach (DataRow row in dt.Rows)
        //        {

        //            if (productID != Convert.ToInt64(row["ProductId"]))
        //            {
        //                objProduct = new BO.Product();
        //                objProduct.Sln = index++;
        //                objProduct.ProductId = Convert.ToInt64(row["ProductId"]);
        //                objProduct.ProductCode = row["ProductCode"].ToString();
        //                objProduct.ProductName = row["ProductName"].ToString();
        //                objProduct.BrandID = Convert.ToInt32(row["BrandID"].ToString());
        //                objProduct.Description = row["Description"].ToString();
        //                //objProduct.SBGID = Convert.ToInt32(row["SBGID"].ToString());
        //                //objProduct.SBID = Convert.ToInt32(row["SBID"].ToString());
        //                //objProduct.SBGName = row["SBGName"].ToString();
        //                //objProduct.SBName = row["SBName"].ToString();
        //                objProduct.Price = row["Price"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Price"].ToString());
        //                objProduct.BrandName = row["BrandName"].ToString();
        //                objProduct.ProductShortName = row["ProductShortName"].ToString();
        //                objProduct.PackSize = row["PackSize"].ToString();
        //                productID = Convert.ToInt64(row["ProductId"]);
        //                objDoctorList.Add(objProduct);
        //            }
        //            {
        //                objProductPackSize = new BO.ProductWisePackSize();
        //                objProductPackSize.PPSID = Convert.ToInt64(row["PPSID"]);
        //                objProductPackSize.PackSizeID = row["PackSizeID"] == DBNull.Value ? 0 : Convert.ToInt32(row["PackSizeID"]);
        //                objProductPackSize.PackSize = row["PackSize"].ToString();
        //                objProductPackSize.ProductID = objProduct.ProductId;
        //                objProduct.ProdPackSizeList.Add(objProductPackSize);
        //            }
        //        }
        //        return objDoctorList;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        public IList<BO.Product> GetProductByOthersList(string columnsString)
        {
            return new List<BO.Product>();
        }
        //public BO.Product GetProductByID(long ProductId)
        //{
        //    try
        //    {
        //        return GetProductWisePackSizeList(ProductId).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public IList<BO.Product> GetProductByCode(string productCode)
        //{
        //    try
        //    {
        //        return GetProductWisePackSizeList(ProductId: null, ProductCode: productCode);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public int GetProductIDByCode(string productCode)
        {
            SqlConnection con = CreateCon();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "DCR_SP_GET_ProductIDByProductCode";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@ProductCode", System.Data.SqlDbType.VarChar, 500).Value = productCode;

            da.SelectCommand.Connection = con;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            int ProductId = 0;
            DataTable dt = ds.Tables[0];
            List<POS.BO.Product> objDoctorList = new List<POS.BO.Product>();
            POS.BO.Product obj = null;
            int index = 1;
            foreach (DataRow row in dt.Rows)
            {
                ProductId = Convert.ToInt32(row["ProductID"]);
            }
            return ProductId;
        }

        public Dictionary<string, long> GetProductIDAndCode()
        {
            Dictionary<string, long> _dic = new Dictionary<string, long>();
            int ProductID = 0;
            string productCode = "0";
            querry = @"SELECT   ProductID,ProductCode FROM    product where  product.IsActive = 1";
            DataTable dt = ExecuteQuerry(querry).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                ProductID = Convert.ToInt32(row["ProductID"].ToString());
                productCode = Convert.ToString(row["ProductCode"].ToString());
                _dic.Add(productCode, ProductID);
            }
            return _dic;
        }

        public IList<BO.Product> GetProductListByBrand(int BrandID)
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GetProductListByBrand";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = BrandID;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                DataTable dt = ds.Tables[0];
                List<POS.BO.Product> objDoctorList = new List<POS.BO.Product>();
                POS.BO.Product obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Product();
                    obj.Sln = index++;
                    obj.ProductId = Convert.ToInt64(row["ProductId"]);
                    obj.ProductCode = row["ProductCode"].ToString();
                    obj.ProductName = row["ProductName"].ToString() + "(" + row["PackSize"].ToString() + ")";
                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BO.Product> getProductIDByPackSizeID(int packsizeID)
        {
            List<BO.Product> objProductID = new List<BO.Product>();
            POS.BO.Product obj = null;
            querry = @"SELECT ProductID FROM ProductWisePackSize where
            ProductWisePackSize.PackSizeID = '" + packsizeID + "' and ProductWisePackSize.IsActive = 1";
            DataTable dt = ExecuteQuerry(querry).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                obj = new BO.Product();
                obj.ProductId = Convert.ToInt64(row["ProductID"].ToString());
                objProductID.Add(obj);
            }
            return objProductID;
        }

        //public IList<BO.Product> GetPackSizeListByProductID(long ProductID)
        //{
        //    List<BO.Product> objProduct = new List<BO.Product>();
        //    BO.Product obj = new BO.Product();
        //    BO.ProductWisePackSize objPackSize = null;
        //    querry = @"select ProductPackSize.PackSize,ProductPackSize.PackSizeID from ProductPackSize
        //         inner join ProductWisePackSize on ProductWisePackSize.PackSizeID = ProductPackSize.PackSizeID
        //         where ProductWisePackSize.ProductID= '" + ProductID + "' and ProductWisePackSize.IsActive = 1";
        //    DataTable dt = ExecuteQuerry(querry).Tables[0];
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        objPackSize = new BO.ProductWisePackSize();
        //        objPackSize.PackSizeID = Convert.ToInt32(row["PackSizeID"].ToString());
        //        objPackSize.PackSize = row["PackSize"].ToString();
        //        obj.ProdPackSizeList.Add(objPackSize);
        //        objProduct.Add(obj);
        //    }
        //    return objProduct;
        //}

        public IList<BO.Product> GetPackSizeByProductID(long ProductID)
        {
            List<BO.Product> objProductID = new List<BO.Product>();
            POS.BO.Product obj = null;
            querry = @"select ProductPackSize.PackSize,ProductPackSize.PackSizeID from ProductPackSize
	                inner join ProductWisePackSize on ProductWisePackSize.PackSizeID = ProductPackSize.PackSizeID
	                where ProductWisePackSize.PPSID= '" + ProductID + "' and ProductWisePackSize.IsActive = 1";
            DataTable dt = ExecuteQuerry(querry).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                obj = new BO.Product();
                obj.PackSizeID = Convert.ToInt32(row["PackSizeID"].ToString());
                obj.PackSize = row["PackSize"].ToString();
                objProductID.Add(obj);
            }
            return objProductID;
        }

        public IList<BO.ProductWisePackSize> GetProductWisePackSizeShortList()
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_ProductWisePackSizeShortList";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                DataTable dt = ds.Tables[0];
                List<POS.BO.ProductWisePackSize> objDoctorList = new List<POS.BO.ProductWisePackSize>();
                POS.BO.ProductWisePackSize obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.ProductWisePackSize();
                    obj.Sln = index++;
                    obj.PPSID = Convert.ToInt64(row["PPSID"]);
                    obj.ProductID = Convert.ToInt64(row["ProductId"]);
                    obj.ProductCode = row["ProductCode"].ToString();
                    obj.ProductName = row["ProductName"].ToString();
                    obj.PackSize = row["PackSize"].ToString();

                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<BO.Product> GetProductListLikeBrand(string brandName)
        {
            List<BO.Product> objProductList = new List<BO.Product>();
            POS.BO.Product obj = null;
            querry = @"select ProductID,BrandID from product where ProductName Like '" + brandName + "%'";
            DataTable dt = ExecuteQuerry(querry).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                obj = new BO.Product();
                obj.ProductId = Convert.ToInt64(row["ProductID"].ToString());
                obj.BrandID = Convert.ToInt32(row["BrandID"].ToString());
                objProductList.Add(obj);
            }
            return objProductList;
        }

        public void UpdateBrandID(BO.Product objProductForUpdate)
        {
            querry = @"Update Product set BrandID = " + objProductForUpdate.BrandID + " where ProductID = " + objProductForUpdate.ProductId;
            ExecuteNonQuerry(querry);
        }

        public long GetProductIDByName(string productName)
        {
            try
            {
                long ID = 0;
                querry = "select top 1 ProductID from product where ProductName = '" + productName + "' and IsActive = 1";
                DataTable dt = ExecuteQuerry(querry).Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    ID = Convert.ToInt64(row["ProductID"]);
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long GetProductPackSizeIDByProducPackSize(long productID, int packSizeId)
        {
            long PPSID = 0;
            querry = @"select top 1 PPSID from ProductWisePackSize where ProductID = " + productID + "  and PackSizeID = " + packSizeId + " and ProductWisePackSize.IsActive = 1";
            DataTable dt = ExecuteQuerry(querry).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                PPSID = Convert.ToInt32(row["PPSID"].ToString());
            }
            return PPSID;
        }

        public int DeleteRawData(List<long> deletedDocList)
        {
            try
            {
                int returnStatus = 0;
                int transationStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlTransaction transaction = null;
                try
                {
                    da.SelectCommand = new SqlCommand();
                    da.SelectCommand.CommandTimeout = 500;
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    transaction = con.BeginTransaction();
                    // Assign Transaction to Command
                    da.SelectCommand.Connection = con;
                    da.SelectCommand.Transaction = transaction;
                    foreach (var id in deletedDocList)
                    {
                        da.SelectCommand.CommandText = "DCR_SP_DELETE_ProductRawData";
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@ID", System.Data.SqlDbType.BigInt).Value = id;

                        transationStatus = da.SelectCommand.ExecuteNonQuery();
                        da.SelectCommand.Parameters.Clear();

                        if (transationStatus <= 0)
                        {
                            transaction.Rollback();
                            break;
                        }
                    }

                    if (transationStatus > 0)
                    {
                        transaction.Commit();
                        returnStatus = 1;
                    }

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    returnStatus = 0;
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                return returnStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetBrandIDBylikeProductName(string productName)
        {
            int brandID = 0;

            querry = @"select top 1 BrandID from Product where Productname Like '" + productName + "%'";
            DataTable dt = ExecuteQuerry(querry).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                brandID = Convert.ToInt32(row["BrandID"].ToString());
            }
            return brandID;
        }



        public IList<Product> GetProductWisePackSizeListDetail()
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductByCode(string productCode)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductWisePackSizeListByID(long? ProdcutID)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetPackSizeIDByProductID(long ProductID)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetPackSizeListByProductID(long ProductID)
        {
            throw new NotImplementedException();
        }
    }
}