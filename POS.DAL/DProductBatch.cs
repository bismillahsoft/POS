using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using POS.COMMON;

namespace POS.DAL
{
    public class DProductBatch : DCommon, IDAL.IProductBatch
    {
        public int Insert(BO.ProductBatch objProductBatch)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "DCR_SP_INSERT_ProductBatch";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@BatchNo", System.Data.SqlDbType.VarChar, 500).Value = objProductBatch.BatchNo;
                da.SelectCommand.Parameters.Add("@ProductCode", System.Data.SqlDbType.VarChar, 5).Value = objProductBatch.ProductCode;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (da.SelectCommand.ExecuteNonQuery() == 1)
                {
                    returnStatus = 1;
                }
                else
                {
                    returnStatus = 0;
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return returnStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(BO.ProductBatch objProductBatch, long ProductID)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "DCR_SP_UPDATE_ProductBatch";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@BatchNo", System.Data.SqlDbType.VarChar, 500).Value = objProductBatch.BatchNo;
                da.SelectCommand.Parameters.Add("@BatchID", System.Data.SqlDbType.BigInt).Value = objProductBatch.BatchID;
                da.SelectCommand.Parameters.Add("@ProductCode", System.Data.SqlDbType.VarChar, 5).Value = objProductBatch.ProductCode;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (da.SelectCommand.ExecuteNonQuery() == 1)
                {
                    returnStatus = 1;
                }
                else
                {
                    returnStatus = 0;
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return returnStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(long BatchID)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "DCR_SP_DELETE_ProductBatch";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@BatchID", System.Data.SqlDbType.BigInt).Value = BatchID;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (da.SelectCommand.ExecuteNonQuery() == 1)
                {
                    returnStatus = 1;
                }
                else
                {
                    returnStatus = 0;
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return returnStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<POS.BO.ProductBatch> GetProductBatch(int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return new List<POS.BO.ProductBatch>();
        }

        public IList<BO.ProductBatch> GetProductBatchByObject(BO.ProductBatch objProductBatch, int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return new List<POS.BO.ProductBatch>();
        }

        public IList<POS.BO.ProductBatch> GetProductBatchList()
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_ProductBatch";
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
                List<POS.BO.ProductBatch> objDoctorList = new List<POS.BO.ProductBatch>();
                POS.BO.ProductBatch obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.ProductBatch();
                    obj.Sln = index++;
                    obj.BatchID = Convert.ToInt64(row["BatchID"]);
                    obj.BatchNo = row["BatchNo"].ToString();
                    obj.ProductName = row["ProductName"].ToString();
                    obj.ProductID = Convert.ToInt64(row["ProductID"].ToString());
                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BO.ProductBatch> GetProductBatchByOthersList(string columnsString)
        {
            return new List<POS.BO.ProductBatch>();
        }

        public BO.ProductBatch GetProductBatchByID(long BatchID)
        {
            try
            {
                querry = @"Select ProductBatch.BatchID,ProductBatch.BatchNo,ProductCode, ProductBatch.ProductID ,Product.ProductName
                            from ProductBatch
                            inner join dbo.Product on dbo.Product.ProductId = dbo.ProductBatch.ProductID
                            where ProductBatch.IsActive = 1 and BatchID= " + BatchID + "  ";

                DataTable dt = ExecuteQuerry(querry).Tables[0];
                List<POS.BO.ProductBatch> objList = new List<POS.BO.ProductBatch>();
                POS.BO.ProductBatch obj = null;

                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.ProductBatch();
                    obj.BatchID = Convert.ToInt64(row["BatchID"]);
                    obj.BatchNo = row["BatchNo"].ToString();
                    obj.ProductName = row["ProductName"].ToString();
                    obj.ProductCode = row["ProductCode"].ToString();
                    obj.ProductID = Convert.ToInt64(row["ProductID"].ToString());
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// used get product wise batchID
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public IList<BO.ProductBatch> GetProductIDWiseProductBactchList(int productID)
        {
            try
            {
                querry = @"Select ProductBatch.BatchID,ProductBatch.BatchNo
                            from ProductBatch
                            where dbo.ProductBatch.ProductID  = " + productID + "  and ProductBatch.IsActive = 1 ";

                DataTable dt = ExecuteQuerry(querry).Tables[0];
                List<POS.BO.ProductBatch> objList = new List<POS.BO.ProductBatch>();
                POS.BO.ProductBatch obj = null;

                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.ProductBatch();
                    obj.BatchID = Convert.ToInt64(row["BatchID"]);
                    obj.BatchNo = row["BatchNo"].ToString();
                    objList.Add(obj);
                }
                return objList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// used get product wise batchID
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public long? GetProductBatchIDByCode(string bathcNo)
        {
            try
            {
                long? batchID = null;
                querry = @"Select ProductBatch.BatchID
                            from ProductBatch
                            where dbo.ProductBatch.BatchNo  = '" + bathcNo + "'  and ProductBatch.IsActive = 1 ";

                DataTable dt = ExecuteQuerry(querry).Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    batchID = Convert.ToInt64(row["BatchID"]);
                }
                return batchID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}