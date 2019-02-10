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
            return 0;
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

        public IList<POS.BO.ProductCategory> GetProductCategoryList()
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "DCR_SP_GET_ProductCategory";
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
                    obj.Id = Convert.ToInt32(row["Id"]);
                    obj.Name = row["Name"].ToString();
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