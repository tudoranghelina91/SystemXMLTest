using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDataDocumentCreateElement
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();

            // create a xmldocument object with a book and a title
            xmlDocument.LoadXml("<books><book><title>UnTitlu</title></book></books>");

            // create a xml element
            XmlElement xmlElement = xmlDocument.CreateElement("book");

            // set value to author node
            xmlElement.InnerXml = "<title>Baltagul</title>";
            xmlDocument.DocumentElement.AppendChild(xmlElement);

            Console.WriteLine(xmlDocument.InnerXml);
        }
    }
}
