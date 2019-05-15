using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using POS.COMMON;

namespace POS.DAL
{
    public class DProductPackSize : DCommon, IDAL.IProductPackSize
    {
        public int Insert(BO.ProductPackSize objProductPackSize)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "[POS_SET_SP_INSERT_SET_ProductPackSize]";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@PackSizeName", SqlDbType.VarChar, 100).Value = objProductPackSize.PackSize;
                da.SelectCommand.Parameters.Add("@Strip", SqlDbType.Int).Value = objProductPackSize.Strip;
                da.SelectCommand.Parameters.Add("@PcsPerStrip", SqlDbType.Int).Value = objProductPackSize.PcsPerStrip;
                da.SelectCommand.Parameters.Add("@PackSizeDescription", SqlDbType.VarChar, 500).Value = objProductPackSize.PackSizeDescription;
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

        public int Update(BO.ProductPackSize objProductPackSize)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "[POS_SP_Update_SET_ProductPackSize]";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@PackSizeID", System.Data.SqlDbType.Int).Value = objProductPackSize.PackSizeID;
                da.SelectCommand.Parameters.Add("@PackSizeName", SqlDbType.VarChar, 100).Value = objProductPackSize.PackSize;
                da.SelectCommand.Parameters.Add("@Strip", SqlDbType.Int).Value = objProductPackSize.Strip;
                da.SelectCommand.Parameters.Add("@PackSizeName", System.Data.SqlDbType.VarChar, 100).Value = objProductPackSize.PackSize;
                da.SelectCommand.Parameters.Add("@PackSizeDescription", System.Data.SqlDbType.VarChar, 500).Value = objProductPackSize.PackSizeDescription;
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

        public int Delete(Int32 PackSizeId)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "POS_SP_DELETE_ProductPackSize";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@PackSizeID", System.Data.SqlDbType.Int).Value = PackSizeId;
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

        public IList<BO.ProductPackSize> GetProductPackSizeList()
        {
            return GetProductPackSizeList(null);
        }

        private IList<BO.ProductPackSize> GetProductPackSizeList(Int32? PackSizeID)
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "[POS_SP_GET_GETProductPackSize]";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
             //   da.SelectCommand.Parameters.Add("@PackSizeID", System.Data.SqlDbType.Int).Value = PackSizeID;
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
                List<POS.BO.ProductPackSize> objDoctorList = new List<POS.BO.ProductPackSize>();
                POS.BO.ProductPackSize obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.ProductPackSize();
                    obj.Sln = index++;
                    obj.PackSizeID = Convert.ToInt32(row["PackSizeID"]);
                    obj.Strip = Convert.ToInt32(row["Strip"]);
                    obj.PcsPerStrip = Convert.ToInt32(row["PcsPerStrip"]);
                    obj.PackSize = row["PackSizeName"].ToString();
                    obj.PackSizeDescription = row["Description"].ToString();
                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BO.ProductPackSize GetProductPackSizeByID(Int32 PackSizeID)
        {
            try
            {
                return GetProductPackSizeList(PackSizeID).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetPackSizeIdByName(string packSize)
        {
            try
            {
                int ID = 0;
                querry = "select top 1 PackSizeID from ProductPackSize where PackSize = '" + packSize + "'";
                DataTable dt = ExecuteQuerry(querry).Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    ID = Convert.ToInt32(row["PackSizeID"]);
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long GetPPSIdByProductIdPackSizeId(long productID, int packSizeID)
        {
            try
            {
                long ID = 0;
                querry = "select top 1 PPSID from productwisepacksize where PackSizeID = " + packSizeID + " and ProductID = " + productID + " and  IsActive = 1";
                DataTable dt = ExecuteQuerry(querry).Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    ID = Convert.ToInt32(row["PPSID"]);
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BO.ProductPackSize> GetProductPackSizeByProductID(long productID)
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_ProductPackSizeByProductID";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.BigInt).Value = productID;
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
                List<POS.BO.ProductPackSize> objDoctorList = new List<POS.BO.ProductPackSize>();
                POS.BO.ProductPackSize obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.ProductPackSize();
                    obj.Sln = index++;
                    obj.PackSizeID = Convert.ToInt32(row["PackSizeID"]);
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


        public long InsertProductPackSize(long productID, int packSizeID)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_INSERT_ProductWisePackSize";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.BigInt).Value = productID;
                da.SelectCommand.Parameters.Add("@PackSizeID", System.Data.SqlDbType.Int).Value = packSizeID;
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

        public long GetPPSIDBySAPCode(string SAPCode)
        {
            try
            {
                long PPSID = 0;
                querry = "select top 1 PPSID from ProductWisePackSize where SAPCode= '" + SAPCode + "' and IsActive = 1";
                DataTable dt = ExecuteQuerry(querry).Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    PPSID = row["PPSID"] == DBNull.Value ? 0 : Convert.ToInt64(row["PPSID"]);
                }
                return PPSID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long GetIDByPPSIDAndSBGID(long ppsID, int SBGID)
        {
            try
            {
                long ID = 0;
                querry = "select top 1 ID from SBGWiseProductPackSize where SBGID= " + SBGID + " and PPSID=" + ppsID + "and IsActive = 1";
                DataTable dt = ExecuteQuerry(querry).Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    ID = row["ID"] == DBNull.Value ? 0 : Convert.ToInt64(row["ID"]);
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertSBGWiseProductPackSize(int sbgID, long PPSID)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "DCR_SP_INSERT_SBGWiseProductPackSize";
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@PPSID", System.Data.SqlDbType.BigInt).Value = PPSID;
                da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = sbgID;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
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
    }
}