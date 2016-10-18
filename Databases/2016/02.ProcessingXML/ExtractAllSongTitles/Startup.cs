using System;
using System.Xml;

namespace ExtractAllSongTitles
{
    public class Startup
    {
        public static void Main()
        {
            var path = "../../../DocumentsXML/catalogue.xml";
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if (reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
