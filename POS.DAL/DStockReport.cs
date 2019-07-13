using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BO;
using POS.COMMON;
using POS.IDAL;

namespace POS.DAL
{
    public class DStockReport : DCommon, IDAL.IStockReport
    {

        public IList<BO.DMS_AreaStock> GetProductWiseStock()
        {
            try
            {
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "[POS_SP_GET_ProductWiseMDS_Area_Stock]";
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
                List<POS.BO.DMS_AreaStock> objStockList = new List<POS.BO.DMS_AreaStock>();
                POS.BO.DMS_AreaStock obj = null;
                int index = 1;
                foreach (DataRow row in dt.Rows)
                {
                    obj = new BO.DMS_AreaStock();
                    obj.Sln = index++;
                    //obj.AsID = Convert.ToInt32(row["ID"]);
                    obj.ProductName =row["ProductName"].ToString();
                    obj.ProductCode = row["ProductCode"].ToString();

                    obj.PackSize = row["PackSizeName"].ToString();
                    obj.PP = Convert.ToDecimal(row["PP"]);
                    obj.CtnOrPkt = Convert.ToInt32(row["CtnOrPktStock"]);
                    obj.Pcs = Convert.ToInt32(row["PcsStock"]);
                    obj.Qty = Convert.ToInt32(row["Balance"]);
                    obj.StockDate = Convert.ToDateTime(row["StockDate"]);
                    objStockList.Add(obj);
                }
                return objStockList;

            }
           
            catch (Exception ex)
            {
                throw;
            }
        }
    }
     
}
