using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using POS.COMMON;

namespace POS.DAL
{
    public class DProductCategory : DCommon, IDAL.IProductCategory
    {
        public int Insert(BO.ProductCategory objProductCategory)
        {
            try
            {
                 int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "[POS_SET_SP_INSERT_SET_ProductCategory]";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@CategoryName", SqlDbType.VarChar, 100).Value = objProductCategory.Name;
                da.SelectCommand.Parameters.Add("@Description", SqlDbType.VarChar, 200).Value = objProductCategory.Description;
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
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int Update(BO.ProductCategory objProductCategory, int Id)
        {
            return 0;
        }

        public int Delete(int Id)
        {
            return 0;
        }

        public IList<POS.BO.ProductCategory> GetProductCategory(int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return new List<POS.BO.ProductCategory>();
        }

        public IList<BO.ProductCategory> GetProductCategoryByObject(BO.ProductCategory objProductCategory, int pageIndex, int pageSize, string orderBy, string sortindex)
        {
            return new List<POS.BO.ProductCategory>();
        }

        public IList<BO.ProductCategory> GetProductCategoryList()
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "[POS_SP_GET_SET_ProductCategory]";
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
                List<POS.BO.ProductCategory> objDoctorList = new List<POS.BO.ProductCategory>();
                POS.BO.ProductCategory obj = null;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.ProductCategory();
                    obj.Id = Convert.ToInt32(row["ProductCategoryID"]);
                    obj.Name = row["CategoryName"].ToString();
                    obj.Description = row["Description"].ToString();
                    objDoctorList.Add(obj);
                }
                return objDoctorList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<BO.ProductCategory> GetProductCategoryByOthersList(string columnsString)
        {
            return new List<POS.BO.ProductCategory>();
        }

        public BO.ProductCategory GetProductCategoryByID(int Id)
        {
            return new POS.BO.ProductCategory();
        }
    }
}