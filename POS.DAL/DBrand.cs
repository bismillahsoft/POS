using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using POS.COMMON;

namespace POS.DAL
{


    public class DBrand : DCommon, IDAL.IBrand
    {
        public int Insert(BO.Brand objBrand)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "POS_SET_SP_INSERT_SET_Brand";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@BrandName", SqlDbType.VarChar, 100).Value = objBrand.BrandName;
                da.SelectCommand.Parameters.Add("@BrandDescription", SqlDbType.VarChar, 500).Value = objBrand.BrandDescription;
                //da.SelectCommand.Parameters.Add("@GenericID", System.Data.SqlDbType.Int).Value = objBrand.GenericID;

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
        public int Update(BO.Brand objBrand, int SBG)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "DCR_SP_UPDATE_Brand";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = objBrand.BrandID;
                da.SelectCommand.Parameters.Add("@BrandName", System.Data.SqlDbType.VarChar, 100).Value = objBrand.BrandName;
                da.SelectCommand.Parameters.Add("@BrandDescription", System.Data.SqlDbType.VarChar, 100).Value = objBrand.BrandDescription;
                da.SelectCommand.Parameters.Add("@GenericID", System.Data.SqlDbType.Int).Value = objBrand.GenericID;

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
        public int Delete(int BrandID)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "DCR_SP_DELETE_Brand";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = BrandID;
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
        public IList<POS.BO.Brand> GetBrand(int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return new List<POS.BO.Brand>();

        }
        public IList<BO.Brand> GetBrandByObject(BO.Brand objBrand, int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return new List<POS.BO.Brand>();

        }
        public IList<POS.BO.Brand> GetBrandList(int? SBID, int? SBGID, int? BrandID)
        {
            try
            {
                //string SBG = "";
                //if (SBGID == 3)
                //{
                //    SBG = "1,2";
                //}
                //else
                //{
                //    SBG = SBGID.ToString();
                //}
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_BrandByParameter";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = BrandID;
                da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.VarChar, 10).Value = SBGID;
                da.SelectCommand.Parameters.Add("@SBID", System.Data.SqlDbType.Int).Value = SBID;
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
                List<POS.BO.Brand> objDoctorList = new List<POS.BO.Brand>();
                POS.BO.Brand obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Brand();
                    obj.Sln = index++;
                    obj.BrandID = Convert.ToInt32(row["BrandID"]);
                    obj.BrandName = row["BrandName"].ToString();
                    obj.BrandDescription = row["BrandDescription"].ToString();
                    //obj.SBGID = Convert.ToInt32(row["SBG"].ToString());
                    //obj.SBGName = Convert.ToString(row["SBGName"].ToString());

                    objDoctorList.Add(obj);
                }
                return objDoctorList;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public int GetBrandIDBrandName(string BrandName)
        {
            try
            {

                int returnID = 0;
                DataTable dt = ExecuteQuerry("Select top 1 BrandID    from Brand where IsActive = 1 and  BrandName ='" + BrandName + "'").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    returnID = row["BrandID"] == DBNull.Value ? 0 : Convert.ToInt32(row["BrandID"]);
                }
                return returnID;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public IList<BO.Brand> GetBrandByOthersList(string columnsString)
        {
            return new List<POS.BO.Brand>();

        }
        public BO.Brand GetBrandByID(int baradID)
        {
            try
            {
                return GetBrandList(null, null, baradID).ToList().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IList<BO.Brand> GetBrandList()
        {
            try
            {
                //string SBG = "";
                //if (SBGID == 3)
                //{
                //    SBG = "1,2";
                //}
                //else
                //{
                //    SBG = SBGID.ToString();
                //}
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_Brand";
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
                List<POS.BO.Brand> objDoctorList = new List<POS.BO.Brand>();
                POS.BO.Brand obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Brand();
                    obj.Sln = index++;
                    obj.BrandID = Convert.ToInt32(row["BrandID"]);
                    obj.BrandName = row["BrandName"].ToString();
                    obj.BrandDescription = row["BrandDescription"].ToString();


                    objDoctorList.Add(obj);
                }
                return objDoctorList;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public IList<BO.Brand> GetBrandBySBG(int sbgID)
        {
            try
            {

                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_BrandBySubBusiness";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@sbgID", System.Data.SqlDbType.Int).Value = sbgID;
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
                List<POS.BO.Brand> objDoctorList = new List<POS.BO.Brand>();
                POS.BO.Brand obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Brand();
                    obj.Sln = index++;
                    obj.BrandID = Convert.ToInt32(row["BrandID"]);
                    obj.BrandName = row["BrandName"].ToString();
                    obj.BrandDescription = row["BrandDescription"].ToString();
                    //obj.SBGID = Convert.ToInt32(row["SBG"].ToString());
                    //obj.SBGName = Convert.ToString(row["SBGName"].ToString());

                    objDoctorList.Add(obj);
                }
                return objDoctorList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertSBGWiseBrand(BO.Brand objBrand)
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
                        da.SelectCommand.CommandText = "DCR_SP_INSERT_Brand";
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int);
                        da.SelectCommand.Parameters["@BrandID"].Direction = ParameterDirection.Output;
                        da.SelectCommand.Parameters.Add("@BrandName", System.Data.SqlDbType.VarChar, 100).Value = objBrand.BrandName;
                        da.SelectCommand.Parameters.Add("@BrandDescription", System.Data.SqlDbType.VarChar, 500).Value = objBrand.BrandDescription;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Connection = connection;

                        transationStatus = da.SelectCommand.ExecuteNonQuery();
                        int BrandID = (int)da.SelectCommand.Parameters["@BrandID"].Value;

                        da.SelectCommand.Parameters.Clear();
                        if (transationStatus <= 0)
                        {
                            transaction.Rollback();
                            returnStatus = 0;
                            //break;
                        }
                        else
                        {
                            //foreach (var objSBG in objBrand.SBGBrnadList)
                            //{
                            //    #region InsertBrandWiseSBG
                            //    da.SelectCommand.CommandText = "DCR_SP_INSERT_BrandWiseSBG";
                            //    da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = BrandID;
                            //    da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = objSBG.SBGID;
                            //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            //    transationStatus = da.SelectCommand.ExecuteNonQuery();
                            //    da.SelectCommand.Parameters.Clear();
                            //    #endregion
                            //}
                        }
                        transaction.Commit();
                        if (transationStatus > 0)
                        {
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


            //try
            //{
            //    int returnStatus = 0;
            //    int transationStatus = 0;
            //    using (var connection = new DCommon().CreateCon())
            //    {
            //        SqlDataAdapter da = new SqlDataAdapter();
            //        da.SelectCommand = connection.CreateCommand();
            //        SqlTransaction transaction = null;
            //        try
            //        {
            //            // BeginTransaction() Requires Open Connection 
            //            if (connection.State == System.Data.ConnectionState.Closed)
            //            {
            //                connection.Open();
            //            }
            //            transaction = connection.BeginTransaction();
            //            // Assign Transaction to Command 
            //            da.SelectCommand.Connection = connection;
            //            da.SelectCommand.Transaction = transaction;
            //            da.SelectCommand.CommandText = "DCR_SP_INSERT_Brand";
            //            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //            da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.BigInt);
            //            da.SelectCommand.Parameters["@BrandID"].Direction = ParameterDirection.Output;
            //            da.SelectCommand.Parameters.Add("@BrandName", System.Data.SqlDbType.VarChar, 100).Value = objBrand.BrandName;
            //            da.SelectCommand.Parameters.Add("@BrandDescription", System.Data.SqlDbType.VarChar, 500).Value = objBrand.BrandDescription; da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //            transationStatus = da.SelectCommand.ExecuteNonQuery();
            //            objBrand.BrandID = (int)da.SelectCommand.Parameters["@BrandID"].Value;
            //            da.SelectCommand.Parameters.Clear();
            //            if (transationStatus <= 0)
            //            {
            //                transaction.Rollback();
            //                //break;
            //            }
            //            else
            //            {
            //                foreach (var objSBG in objBrand.SBGBrnadList)
            //                {
            //                    #region InsertBrandWiseSBG
            //                    da.SelectCommand.CommandText = "DCR_SP_INSERT_BrandWiseSBG";
            //                    da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = objBrand.BrandID;
            //                    da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = objSBG.SBGID;
            //                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //                    transationStatus = da.SelectCommand.ExecuteNonQuery();
            //                    da.SelectCommand.Parameters.Clear();
            //                    #endregion

            //                }
            //            }
            //            if (transationStatus <= 0)
            //            {
            //                transaction.Rollback();
            //                //break;
            //            }
            //            else
            //            {
            //                returnStatus = 1;
            //            }

            //            transaction.Commit();
            //        }
            //        catch (Exception ex)
            //        {
            //            transaction.Rollback();

            //        }
            //        finally
            //        {
            //            if (connection.State == System.Data.ConnectionState.Open)
            //            {
            //                connection.Close();
            //            }

            //        }

            //    }
            //    return returnStatus;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }


        public int UpdateSBGWiseBrand(BO.Brand objBrand)
        {
            try
            {
                int retunstatus = 0;
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
                        da.SelectCommand.CommandText = "DCR_SP_Update_Brand";
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.BigInt).Value = objBrand.BrandID;
                        da.SelectCommand.Parameters.Add("@BrandName", System.Data.SqlDbType.VarChar, 100).Value = objBrand.BrandName;
                        da.SelectCommand.Parameters.Add("@BrandDescription", System.Data.SqlDbType.VarChar, 500).Value = objBrand.BrandDescription;
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
                            //foreach (var objSBG in objBrand.SBGBrnadList)
                            //{
                            //    if (objSBG.IsNewData == true)
                            //    {
                            //        #region InsertBrandWiseSBG
                            //        da.SelectCommand.CommandText = "DCR_SP_INSERT_BrandWiseSBG";
                            //        da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = objBrand.BrandID;
                            //        da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = objSBG.SBGID;
                            //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            //        transationStatus = da.SelectCommand.ExecuteNonQuery();
                            //        da.SelectCommand.Parameters.Clear();
                            //        #endregion

                            //    }
                            //    if (objSBG.IsDelete == true)
                            //    {
                            //        #region DeleteBrandWiseSBG
                            //        da.SelectCommand.CommandText = "DCR_SP_DELETE_SBGWiseBrand";
                            //        da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.BigInt).Value = objBrand.BrandID;
                            //        da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = objSBG.SBGID;
                            //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            //        transationStatus = da.SelectCommand.ExecuteNonQuery();
                            //        da.SelectCommand.Parameters.Clear();
                            //        #endregion
                            //    }
                            //}
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
                        if (transationStatus == 1)
                        {
                            retunstatus = 1;
                        }

                    }

                }
                return retunstatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long GetSBGBrandIdByBrandIdSbgId(int brandID, int SBGID)
        {
            long sbgBrandID = 0;
            querry = @"select top 1 SBGBrandID From SBGWiseBrand where SBGID = " + SBGID + " and BrandID = " + brandID + " and IsActive = 1";
            DataTable dt = ExecuteQuerry(querry).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                sbgBrandID = Convert.ToInt32(row["SBGBrandID"].ToString());
            }
            return sbgBrandID;
        }


        public void InsertSBGBrand(int SBGID, int brandID)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "DCR_SP_INSERT_BrandWiseSBG";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = SBGID;
                da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = brandID;
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

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<POS.BO.Brand> GetTerritoryWiseSBGAndBrand(long EmployeeID)
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_TerritoryWiseSBGAndBrand";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@EmployeeID", System.Data.SqlDbType.BigInt).Value = EmployeeID;
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
                List<POS.BO.Brand> objBrandList = new List<POS.BO.Brand>();
                POS.BO.Brand obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Brand();
                    obj.Sln = index++;
                    obj.BrandID = Convert.ToInt32(row["BrandID"]);
                    //obj.SBGID = Convert.ToInt32(row["SBGID"]);
                    obj.BrandName = row["BrandName"].ToString();
                    obj.BrandDescription = row["BrandDescription"].ToString();
                    //obj.SBGName = row["SBGName"].ToString();
                    objBrandList.Add(obj);
                }
                return objBrandList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertDeleteTerritoryWiseSBGAndBrand(List<BO.Brand> objList)
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

                        foreach (var obj in objList)
                        {
                            //if (obj.IsNewData == true)
                            //{
                            //    da.SelectCommand.CommandText = "DCR_SP_INSERT_TerritoryWiseSBGAndBrand";
                            //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            //    da.SelectCommand.Connection = connection;
                            //    da.SelectCommand.Parameters.Add("@TerritoryID", System.Data.SqlDbType.BigInt).Value = obj.TerritoryID;
                            //    da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = obj.BrandID;
                            //    da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = obj.SBGID;
                            //    transationStatus = da.SelectCommand.ExecuteNonQuery();
                            //}
                            //if (obj.IsDelete == true)
                            //{
                            //    da.SelectCommand.CommandText = "DCR_SP_DELETE_TerritoryWiseSBGAndBrand";
                            //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            //    da.SelectCommand.Connection = connection;
                            //    da.SelectCommand.Parameters.Add("@TerritoryID", System.Data.SqlDbType.BigInt).Value = obj.TerritoryID;
                            //    da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = obj.BrandID;
                            //    da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = obj.SBGID;
                            //    transationStatus = da.SelectCommand.ExecuteNonQuery();
                            //}
                            //if (transationStatus <= 0)
                            //{
                            //    transaction.Rollback();
                            //    break;

                            //}

                            da.SelectCommand.Parameters.Clear();
                        }
                        transaction.Commit();
                        returnStatus = 1;

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

        public int UpdateTerritoryWiseSBGAndBrand(List<BO.Brand> objList)
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

                        foreach (var obj in objList)
                        {
                            da.SelectCommand.CommandText = "DCR_SP_DELETE_TerritoryWiseSBGAndBrand";
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            da.SelectCommand.Connection = connection;
                            da.SelectCommand.Parameters.Add("@TerritoryID", System.Data.SqlDbType.BigInt).Value = obj.TerritoryID;
                            da.SelectCommand.Parameters.Add("@BrandID", System.Data.SqlDbType.Int).Value = obj.BrandID;
                            //da.SelectCommand.Parameters.Add("@SBGID", System.Data.SqlDbType.Int).Value = obj.SBGID;
                            transationStatus = da.SelectCommand.ExecuteNonQuery();
                            if (transationStatus <= 0)
                            {
                                transaction.Rollback();
                                break;
                            }

                            da.SelectCommand.Parameters.Clear();
                        }
                        transaction.Commit();
                        returnStatus = 1;

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

        public IList<BO.Brand> GetSBGIDBrandIDByTerritoryID(long TerritoryID)
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_SBGIDBrandIDByTerritoryID";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@TerritoryID", System.Data.SqlDbType.BigInt).Value = TerritoryID;
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
                List<POS.BO.Brand> objDoctorList = new List<POS.BO.Brand>();
                POS.BO.Brand obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.Brand();
                    obj.Sln = index++;
                    obj.BrandID = Convert.ToInt32(row["BrandID"]);
                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}