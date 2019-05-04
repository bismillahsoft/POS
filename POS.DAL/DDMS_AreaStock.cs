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
    public class DDMS_AreaStock : DCommon, IDAL.IMDS_AreaStock
    {
     
        public int Insert(BO.DMS_AreaStock ObjDMS_AreaStock)
        {
            try
            {
                int returnStatus = 0;
                SqlConnection con = CreateCon();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();

                da.SelectCommand.CommandText = "[POS_SET_SP_INSERT_SET_ProductBatch]";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = con;
                da.SelectCommand.Parameters.Add("AreaID", SqlDbType.Int).Value = ObjDMS_AreaStock.AreaID;
             
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
