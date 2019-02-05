using System;
using System.Data;
using System.Security;
using System.Web;
using System.Xml;

namespace POS.COMMON
{
    public static class XmlWriterUT
    {

        public static void WriteXmlInFile(string layer, string msg)
        {
            try
            {
                //XmlDataDocument sourceXML = new XmlDataDocument();
                string xmlFile = HttpContext.Current.Server.MapPath("/log/Exception.xml");
                //create a XML file is not exist
                System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(xmlFile, null);
                //starts a new document
                writer.WriteStartDocument();
                //write comments
                writer.WriteComment("Commentss: XmlWriter Test Program");
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("MessageList");
                writer.WriteStartElement("Exception");
                writer.WriteAttributeString("Layer", layer);
                //write some simple elements
                writer.WriteElementString("Message", msg);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Close();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
