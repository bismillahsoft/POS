using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using POS.COMMON;

namespace POS.DAL
{


    public class DProductGeneric : DCommon, IDAL.IProductGeneric
    {

        public Int32 Insert(BO.ProductGeneric objProductGeneric)
        {
            try
            {
                Int32 returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Parameters.Add("@GenericName", SqlDbType.VarChar, 100).Value = objProductGeneric.GenericName;
                da.SelectCommand.Parameters.Add("@GenericDescription", SqlDbType.VarChar, 500).Value = objProductGeneric.GenericDescription;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = "[POS_SET_SP_INSERT_SET_ProductGeneric]";

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

        public Int32 Update(BO.ProductGeneric objProductGeneric, Int32 PGenericID)
        {
            try
            {
                Int32 returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Parameters.Add("@GenericID", System.Data.SqlDbType.Int).Value = objProductGeneric.PGenericID;
                da.SelectCommand.Parameters.Add("@GenericName", System.Data.SqlDbType.VarChar, 100).Value = objProductGeneric.GenericName;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = "DCR_SP_UDCRTE_ProductGeneric";

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

        public Int32 Delete(Int32 PGenericID)
        {
            try
            {
                Int32 returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Parameters.Add("@PGenericID", System.Data.SqlDbType.Int).Value = PGenericID;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = "DCR_SP_DELETE_ProductGeneric"
                ;
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
        public IList<POS.BO.ProductGeneric> GetProductGeneric(Int32 pageIndex, Int32 pageSize, String orderBy, String sortindex)
        {

            try
            {
                return new List<POS.BO.ProductGeneric>();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BO.ProductGeneric> GetProductGenericByObject(BO.ProductGeneric objProductGeneric, Int32 pageIndex, Int32 pageSize, String orderBy, String sortindex)
        {
            try
            {
                return new List<POS.BO.ProductGeneric>();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<POS.BO.ProductGeneric> GetProductGenericList()
        {

            try
            {
                return GetProductGenericList(null);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private IList<POS.BO.ProductGeneric> GetProductGenericList(Int64? PGenericID)
        {

            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
               // da.SelectCommand.Parameters.Add("@PGenericID", System.Data.SqlDbType.Int).Value = PGenericID;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = "POS_SP_GET_GETProductGeneric";

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
                List<BO.ProductGeneric> objProductGenericList = new List<BO.ProductGeneric>();
                BO.ProductGeneric objProductGeneric = null;
                Int32 index = 1;


                foreach (DataRow row in dt.Rows)
                {
                    objProductGeneric = new BO.ProductGeneric();
                    objProductGeneric.Sln = index++;
                    objProductGeneric.PGenericID = Convert.ToInt32(row["GenericID"]);
                    objProductGeneric.GenericName = Convert.ToString(row["GenericName"]);
                    objProductGeneric.GenericDescription = Convert.ToString(row["Description"]);
                    objProductGenericList.Add(objProductGeneric);
                }
                return objProductGenericList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BO.ProductGeneric> GetProductGenericByOthersList(String columnsString)
        {
            try
            {	// List<DATA.ProductGeneric>   objProductGenericList = dc.ProductGeneric.Where( columnsString).ToList();

                //   return objProductGenericList.Select(o => MAPPER.EMProductGeneric.SetTOBusinessObject(o)).ToList();

                return new List<POS.BO.ProductGeneric>();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BO.ProductGeneric GetProductGenericByID(Int32 PGenericID)
        {
            try
            {
                return GetProductGenericList(PGenericID).FirstOrDefault();


            }


            catch (Exception ex)
            {
                throw ex;
            }
        }



        public int GetGenericIDByName(string genericName)
        {
            try
            {

                int returnID = 0;
                DataTable dt = ExecuteQuerry("Select top 1 GenericID from ProductGeneric Where GenericName ='" + genericName + "'").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    returnID = row["GenericID"] == DBNull.Value ? 0 : Convert.ToInt32(row["GenericID"]);
                }
                return returnID;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}