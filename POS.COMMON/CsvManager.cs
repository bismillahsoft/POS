using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Web.UI.WebControls;

namespace POS.COMMON 
{
    public class CsvManager
    {
        /// <summary>
        /// Reads a csv file and read the content in a data table
        /// </summary>
        /// <remarks>
        /// Created By: Suvashish Das
        /// Created At: December 23, 2010
        /// </remarks>
        /// <param name="fullFileName">name of the file including full path</param>
        /// <param name="tableName">name of the data table</param>
        /// <returns>a data table</returns>
        public static DataTable ReadCsv(string fullFileName, string tableName)
        {
            DataTable dataTable;
            var directory = Path.GetDirectoryName(fullFileName);
            fullFileName = Path.GetFileName(fullFileName);

            var sql = string.Format(@"SELECT * FROM [{0}]", fullFileName);

            using (var connection = new OleDbConnection(
                string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Text;HDR=Yes\"", directory)))
            {
                using (var command = new OleDbCommand(sql, connection))
                {
                    using (var adapter = new OleDbDataAdapter(command))
                    {
                        dataTable = new DataTable
                        {
                            TableName = tableName,
                            Locale = CultureInfo.CurrentCulture
                        };
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }



        public static DataTable ReadExcel(string fullFileName, string tableName)
        {

            var dataTable = new DataTable
            {
                TableName = tableName,
                Locale = CultureInfo.CurrentCulture
            };

            //const string sql =
            //    @"SELECT Convert(nvarchar(max), [S.N.]) Serial, " +
            //    @"Convert(nvarchar(max), [ZPBL]) ZPBL, Convert(nvarchar(max), [Code]) Code, " +
            //    @"Convert(nvarchar(max), [DMO]) DMO, Convert(nvarchar(max), [Class]) Class, " +
            //    @"Convert(nvarchar(max), [Name]) Name, Convert(nvarchar(max), [Desig]) Desig, " +
            //    @"Convert(nvarchar(max), [Place of  Posting]) PostingPlace, Convert(nvarchar(max), [Recently Used]) PhoneNo, " +
            //    @"Convert(nvarchar(max), [Territory Code]) Territory FROM [Sheet1$]";

            const string sql = @"SELECT * FROM [Sheet1$]";

            var connectionString =
                string.Format(
                    "Provider=Microsoft.ACE.OLEDB.12.0;;Data Source={0};Extended Properties=\"Excel 12.0;HDR=Yes\"",
                    fullFileName);

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (var command = new OleDbCommand(sql, connection))
                {
                    var adapter = new OleDbDataAdapter { SelectCommand = command };
                    adapter.Fill(dataTable);
                }
                connection.Close();
            }

            return dataTable;
        }
        /// <summary>
        /// Amin Uddin
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="filePath"></param>
        /// <param name="Sheet"></param>
        /// <returns></returns>
        public static DataTable ImportDataFromExcelToSql(string tableName, string filePath, string Sheet)
        {
            //OleDbConnection oconn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=Yes\"");
            OleDbConnection oconn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0");
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [" + Sheet + "$]", oconn);
            OleDbCommand ocmd = new OleDbCommand(@"select * from [" + Sheet + "$]", oconn);
            oconn.Open();
            OleDbDataReader odr = ocmd.ExecuteReader();
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;


        }
        public static string CheckChemistCode(string ChemistCode)
        {

            string returnChemistCode = "";
            if (ChemistCode.Length < 5)
            {
                if (ChemistCode.Length == 4)
                {
                    returnChemistCode = "0" + ChemistCode;
                }
                else if (ChemistCode.Length == 3)
                {
                    returnChemistCode = "00" + ChemistCode;

                }
                else if (ChemistCode.Length == 2)
                {
                    returnChemistCode = "000" + ChemistCode;

                }
                else if (ChemistCode.Length == 1)
                {
                    returnChemistCode = "0000" + ChemistCode;

                }
            }
            else
            {
                returnChemistCode = ChemistCode;
            }
            return returnChemistCode;


        }


        public static string CheckArTerm(string arTerm)
        {
            string returnArTerm = "";
            if (arTerm.Length < 2)
            {
                if (arTerm.Length == 1)
                {
                    returnArTerm = "0" + arTerm;
                }
            }

            else
            {
                returnArTerm = arTerm;
            }
            return returnArTerm;
        }

        public static DataSet ReadExcel(string sFilePath)
        {
            string sConnection = String.Format(
                     "Provider=Microsoft.ACE.OLEDB.12.0;;Data Source={0};Extended Properties=\"Excel 12.0;HDR=Yes\"",
                     sFilePath);

            OleDbConnection dbCon = new OleDbConnection(sConnection);

            dbCon.Open();

            // Get All Sheets Name

            DataTable dtSheetName = dbCon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            // Retrive the Data by Sheetwise

            DataSet dsOutput = new DataSet();

            for (int nCount = 0; nCount < dtSheetName.Rows.Count; nCount++)
            {
                string sSheetName = dtSheetName.Rows[nCount]["TABLE_NAME"].ToString();

                string sQuery = "Select * From [" + sSheetName + "]";

                OleDbCommand dbCmd = new OleDbCommand(sQuery, dbCon);

                OleDbDataAdapter dbDa = new OleDbDataAdapter(dbCmd);

                DataTable dtData = new DataTable
                {
                    TableName = sSheetName,
                    Locale = CultureInfo.CurrentCulture
                };

                dbDa.Fill(dtData);

                dsOutput.Tables.Add(dtData);
            }

            dbCon.Close();

            return dsOutput;
        }

        public static void ExportInExcelSheet(DataTable dt)
        {
            //using (ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook())
            //{
            //    wb.Worksheets.Add(dt);

            //    HttpContext.Current.Response.Clear();
            //    HttpContext.Current.Response.Buffer = true;
            //    HttpContext.Current.Response.Charset = "";
            //    HttpContext.Current.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //    HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=GridView.xlsx");
            //    using (MemoryStream MyMemoryStream = new MemoryStream())
            //    {
            //        wb.SaveAs(MyMemoryStream);
            //        MyMemoryStream.WriteTo(HttpContext.Current.Response.OutputStream);
            //        HttpContext.Current.Response.Flush();
            //        HttpContext.Current.Response.End();
            //    }
            //}
        }

        public static void CreateDataTableAndExport(GridView grv)
        {
            DataTable dt = new DataTable("GridView_Data");

            for (int i = 0; i < grv.HeaderRow.Cells.Count; i++)
            {
                if (((dynamic)grv.HeaderRow.Cells[i]).ContainingField.Visible)
                {
                    dt.Columns.Add(grv.HeaderRow.Cells[i].Text);
                }
            }
            foreach (GridViewRow row in grv.Rows)
            {
                dt.Rows.Add();
                int j = 0;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (((dynamic)row.Cells[i]).ContainingField.Visible)
                    {
                        LinkButton link = row.Cells[i].FindControl("Label" + i.ToString()) as LinkButton;
                        if (link != null)
                        {
                            LinkButton xyz = (LinkButton)row.Cells[i].FindControl("Label" + i.ToString());
                            dt.Rows[dt.Rows.Count - 1][j] = xyz.Text;
                        }
                        else
                        {
                            Label xyz = (Label)row.Cells[i].FindControl("Label" + i.ToString());
                            dt.Rows[dt.Rows.Count - 1][j] = xyz.Text;
                        }

                        j++;
                    }
                }
            }
            ExportInExcelSheet(dt);
        }

        public static void CreateDataTableAndExportDt(DataTable objRefListDt)
        {
            ExportInExcelSheet(objRefListDt);
        }
    }
}