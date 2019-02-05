using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace POS.COMMON
{
    public class DCommon
    {
        protected bool flag = false;
        protected string querry = string.Empty;
        private string returnString = string.Empty;
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter da = null;
        private SqlDataReader dr = null;

        public SqlConnection CreateCon()
        {
            string conString1 = ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
            conString1 = "Data Source=" + ConfigurationManager.AppSettings["ip"] + ";" + new Sha1().GetDecryptString(conString1);
            return new SqlConnection(conString1);
        }
        /// <summary>
        /// used to execute all Querry statement.
        /// </summary>
        /// param name="data"
        /// <returns>dataset</returns>
        public DataSet ExecuteQuerry(string data)
        {

            con = CreateCon();
            da = new SqlDataAdapter(data, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        /// <summary>
        /// used to execute all non querry statement.
        /// </summary>
        /// param name="data"
        /// <returns>dataset</returns>
        public bool ExecuteNonQuerry(string data)
        {
            con = CreateCon();
            cmd = new SqlCommand(data, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (cmd.ExecuteNonQuery() > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            return flag;

        }
        public bool IsValueExits(string data)
        {
            con = CreateCon();
            cmd = new SqlCommand();
            cmd.CommandText = data;
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            return flag;

        }

    }


}
