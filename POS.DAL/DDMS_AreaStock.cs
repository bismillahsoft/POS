using POS.COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace POS.DAL
{
    public class DDMS_AreaStock : DCommon, IDAL.IDMS_AreaStock
    {
     
        public int Insert(BO.DMS_AreaStock ObjDMS_AreaStock)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "POS_DMS_SP_INSERT_AreaStock";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("@AreaID", SqlDbType.Int).Value = ObjDMS_AreaStock.AreaID;
                da.SelectCommand.Parameters.Add("@ProductID", SqlDbType.Int).Value = ObjDMS_AreaStock.ProductID;
                da.SelectCommand.Parameters.Add("@CtnOrPkt", SqlDbType.Int).Value = ObjDMS_AreaStock.CtnOrPkt;
                da.SelectCommand.Parameters.Add("@Pcs", SqlDbType.Int).Value = ObjDMS_AreaStock.Pcs;
                da.SelectCommand.Parameters.Add("@Qty", SqlDbType.Int).Value = ObjDMS_AreaStock.Qty;
                da.SelectCommand.Parameters.Add("@Strip", SqlDbType.Int).Value = ObjDMS_AreaStock.Strip;
                da.SelectCommand.Parameters.Add("@PcsPerStrip", SqlDbType.Int).Value = ObjDMS_AreaStock.PcsPerStrip;

                //da.SelectCommand.Parameters.Add("@PP", SqlDbType.Decimal,2).Value = ObjDMS_AreaStock.PP;
                //da.SelectCommand.Parameters.Add("@MRP", SqlDbType.Decimal,2).Value = ObjDMS_AreaStock.MRP;
                //da.SelectCommand.Parameters.Add("@Vat", SqlDbType.Decimal,2).Value = ObjDMS_AreaStock.Vat;
                //da.SelectCommand.Parameters.Add("@TP", SqlDbType.Decimal,2).Value = ObjDMS_AreaStock.TP;
                //da.SelectCommand.Parameters.Add("@StockDate", SqlDbType.DateTime).Value = ObjDMS_AreaStock.StockDate;
                da.SelectCommand.Parameters.Add("@TransactionDate", SqlDbType.Date).Value = ObjDMS_AreaStock.StockTransantionDate;

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
        public int Update(BO.DMS_AreaStock ObjDMS_AreaStock)
        {
            return 0;
        }
        public int Delete(BO.DMS_AreaStock ObjDMS_AreaStock)
        {
            return 0;
        }
    }
}
