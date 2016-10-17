using System;
using System.Xml.Xsl;

namespace TrasformToHtml
{
    public class Startup
    {
        public static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            var cataloguePath = "../../../DocumentsXML/catalogue.xml";
            var xsltPath = "../../../DocumentsXML/style-catalogue.xslt";
            var htmlOutput = "../../../DocumentsXML/catalogue.html";
            xslt.Load(xsltPath);
            xslt.Transform(cataloguePath, htmlOutput);
            Console.WriteLine("File trasformed");
        }
    }
}
