using System;
using System.Collections.Generic;
using System.Xml;

namespace ExtractAllArtistXPath
{
    public class Startup
    {
        public static void Main()
        {
            var path = "../../../DocumentsXML/catalogue.xml";
            XmlDocument document = new XmlDocument();
            document.Load(path);
            var xpath = "catalogue/album/artist";
            XmlNodeList artists = document.SelectNodes(xpath);
            var hashTable = new Dictionary<string, int>();

            foreach (XmlNode artist in artists)
            {
                var artistName = artist.InnerText;
                if (hashTable.ContainsKey(artistName))
                {
                    hashTable[artistName]++;
                }
                else
                {
                    hashTable.Add(artistName, 1);
                }
            }

            foreach (var artist in hashTable)
            {
                Console.WriteLine("{0} - {1} Albums", artist.Key, artist.Value);
            }
        }
    }
}
