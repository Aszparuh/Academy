using System;
using System.Collections.Generic;
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
            XmlNode rootNode = document.DocumentElement;
            var hashTable = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode)
            {
                foreach (XmlElement childNode in node)
                {
                    // Console.WriteLine(childNode.Name);
                    if (childNode.Name == "artist")
                    {
                        var artistName = childNode.InnerText;
                        if (hashTable.ContainsKey(artistName))
                        {
                            hashTable[artistName]++;
                        }
                        else
                        {
                            hashTable.Add(artistName, 1);
                        }
                    }
                }
            }

            foreach (var artist in hashTable)
            {
                Console.WriteLine("{0} - {1} Albums", artist.Key, artist.Value);
            }
        }
    }
}
