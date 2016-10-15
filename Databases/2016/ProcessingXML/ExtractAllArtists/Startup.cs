using System;
using System.Xml;

namespace ExtractAllArtists
{
    public class Startup
    {
        public static void Main()
        {
            var path = "../../../DocumentsXML/catalogue.xml";
            XmlDocument document = new XmlDocument();
            document.Load(path);

            Console.WriteLine(document.OuterXml);
        }
    }
}
