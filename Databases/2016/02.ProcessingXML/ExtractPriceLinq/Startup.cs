using System;
using System.Linq;
using System.Xml.Linq;

namespace ExtractPriceLinq
{
    public class Startup
    {
        public static void Main()
        {
            var path = "../../../DocumentsXML/catalogue.xml";
            var doc = XDocument.Load(path);
            var albumNames = from album in doc.Descendants("album")
                             where int.Parse(album.Element("year").Value) > 2010
                             select album.Element("name").Value;

            Console.WriteLine(string.Join(Environment.NewLine, albumNames));
        }
    }
}
