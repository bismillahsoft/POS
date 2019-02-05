using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Xml.Linq;
using System.Web;
using System.Xml;
using System.Collections;
using System.Web.UI;

namespace POS.COMMON 
{
    public static class HandleException
    {

        public static string InsertError(Exception ex)
        {
          string userID = Convert.ToString( HttpContext.Current.Session[MySession.UserId.ToString()]);

            XDocument xdoc = new XDocument();
            Error anError = new Error();
            anError.ID = 1;
            anError.UserID = userID;
            anError.Message = ex.Message;
            anError.Trace = ex.StackTrace.ToString();
            anError.Date = DateTime.Now.ToShortDateString();
            //Get Page Name
            string sPath = HttpContext.Current.Request.Url.AbsolutePath;
            FileInfo fileInfo = new FileInfo(sPath);
            anError.PageName = fileInfo.Name;

            //Get Current Method
            //StackFrame stackFrame = new StackFrame();
            //MethodBase methodBase = stackFrame.GetMethod();
            //anError.MethodName = methodBase.Name;
            return StoreErrors(xdoc, anError);
        }



        private static string StoreErrors(XDocument xdoc, Error anError)
        {
            if (!File.Exists(HttpContext.Current.Server.MapPath("Error.xml")))
            {
                xdoc = new XDocument(
            new XDeclaration("1.0", null, null),
            new XComment("This sample data represent an XML Document"),
            new XElement("Errors"));

            }
            else
            {

                xdoc = XDocument.Load(HttpContext.Current.Server.MapPath("Error.xml"));
                int maxid = 0;
                //Get maxid from xml

                maxid = xdoc.Descendants("Error").Max(id => (int)id.Attribute("ID"));
                maxid += 1;

                anError.ID = maxid;

            }
            InsertNewError(anError, xdoc);
            return "Error Code:" + anError.ID + ",Please Contact To Admin. ";

        }

        private static void InsertNewError(Error anError, XDocument xdoc)
        {
            //Insert new Error
            XElement newElement = new XElement("Error",
                            new XAttribute("ID", anError.ID),
                            new XElement("Message", anError.Message),
                            new XElement("Trace", anError.Trace),
                            new XElement("User", anError.UserID),
                            new XElement("Page", anError.PageName),
                            new XElement("Date", anError.Date)
                );

            xdoc.Element("Errors").Add(newElement);
            xdoc.Save(HttpContext.Current.Server.MapPath("Error.xml"));

        }



        public static IEnumerable<Error> GetErrors(int id, string pageName, string userid, string dateFrom, string dateTo)
        {
            try
            {
                IEnumerable<Error> errors = null;
                XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath("Error.xml"));
                //ClassLibrary1.SearchParam objSearch = new ClassLibrary1.SearchParam();
                if (id > 0 && pageName != "" && dateFrom != "" && dateTo != "")
                {
                    errors = from obj in xDoc.Descendants("Error")

                             where Convert.ToInt32(obj.Attribute("ID").Value) == id & obj.Element("Page").Value == pageName
                             && Convert.ToDateTime(obj.Element("Date").Value) >= Convert.ToDateTime(dateFrom) && Convert.ToDateTime(obj.Element("Date").Value) <= Convert.ToDateTime(dateTo)
                             select new Error
                             {
                                 ID = Int32.Parse(obj.Attribute("ID").Value),
                                 Message = obj.Element("Message").Value.ToString(),
                                 Trace = obj.Element("Trace").Value.ToString(),
                                 UserID = obj.Element("User").Value.ToString(),
                                 PageName = obj.Element("Page").Value.ToString(),
                                 Date = obj.Element("Date").Value.ToString()
                             };
                }
                else if (id > 0 && pageName != "")
                {
                    errors = from obj in xDoc.Descendants("Error")

                             where Convert.ToInt32(obj.Attribute("ID").Value) == id & obj.Element("Page").Value == pageName
                             select new Error
                             {
                                 ID = Int32.Parse(obj.Attribute("ID").Value),
                                 Message = obj.Element("Message").Value.ToString(),
                                 Trace = obj.Element("Trace").Value.ToString(),
                                 UserID = obj.Element("User").Value.ToString(),
                                 PageName = obj.Element("Page").Value.ToString(),
                                 Date = obj.Element("Date").Value.ToString()
                             };
                }
                else if (id > 0 && dateFrom != "" && dateTo != "")
                {
                    errors = from obj in xDoc.Descendants("Error")

                             where Convert.ToInt32(obj.Attribute("ID").Value) == id
                             && Convert.ToDateTime(obj.Element("Date").Value) >= Convert.ToDateTime(dateFrom) && Convert.ToDateTime(obj.Element("Date").Value) <= Convert.ToDateTime(dateTo)

                             select new Error
                             {
                                 ID = Int32.Parse(obj.Attribute("ID").Value),
                                 Message = obj.Element("Message").Value.ToString(),
                                 Trace = obj.Element("Trace").Value.ToString(),
                                 UserID = obj.Element("User").Value.ToString(),
                                 PageName = obj.Element("Page").Value.ToString(),
                                 Date = obj.Element("Date").Value.ToString()
                             };
                }
                else if (pageName != "" && dateFrom != "" && dateTo != "")
                {
                    errors = from obj in xDoc.Descendants("Error")

                             where obj.Element("Page").Value.ToLower() == pageName.ToLower()
                             && Convert.ToDateTime(obj.Element("Date").Value) >= Convert.ToDateTime(dateFrom) && Convert.ToDateTime(obj.Element("Date").Value) <= Convert.ToDateTime(dateTo)

                             select new Error
                             {
                                 ID = Int32.Parse(obj.Attribute("ID").Value),
                                 Message = obj.Element("Message").Value.ToString(),
                                 Trace = obj.Element("Trace").Value.ToString(),
                                 UserID = obj.Element("User").Value.ToString(),
                                 PageName = obj.Element("Page").Value.ToString(),
                                 Date = obj.Element("Date").Value.ToString()
                             };
                }
                else
                {
                    errors = from obj in xDoc.Descendants("Error")

                             where Convert.ToDateTime(obj.Element("Date").Value) >= Convert.ToDateTime(dateFrom) && Convert.ToDateTime(obj.Element("Date").Value) <= Convert.ToDateTime(dateTo)

                             select new Error
                             {
                                 ID = Int32.Parse(obj.Attribute("ID").Value),
                                 Message = obj.Element("Message").Value.ToString(),
                                 Trace = obj.Element("Trace").Value.ToString(),
                                 UserID = obj.Element("User").Value.ToString(),
                                 PageName = obj.Element("Page").Value.ToString(),
                                 Date = obj.Element("Date").Value.ToString()
                             };
                }
                return errors;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


    }
}
