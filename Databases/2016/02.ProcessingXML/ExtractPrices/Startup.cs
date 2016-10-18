using System;
using System.Xml;

namespace ExtractPrices
{
    public class Startup
    {
        public static void Main()
        {
            var path = "../../../DocumentsXML/catalogue.xml";
            XmlDocument document = new XmlDocument();
            document.Load(path);
            var xpathQuery = "/catalogue/album[year>1997]/name";
            var names = document.SelectNodes(xpathQuery);

            foreach (XmlNode node in names)
            {
                Console.WriteLine(node.InnerText);
            }
        }
    }
}
