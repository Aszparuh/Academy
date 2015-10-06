namespace ExtractAllArtists
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml;

    internal class Extract
    {
        private static void Main()
        {
            var document = new XmlDocument();
            document.Load("../../../catalog.xml");
            var root = document.DocumentElement;

            var artists = GetAllArtists(root);
            foreach (var artist in artists)
            {
                Console.WriteLine(artist);
            }

            var albums = GetNumberOfAlbumsForEachArtist(root);
            foreach (var pair in albums)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
            
        }

        private static IEnumerable<string> GetAllArtists(XmlElement rootElement)
        {
            var result = new HashSet<string>();
            var artistsCollection = rootElement.GetElementsByTagName("artist");

            foreach (XmlElement element in artistsCollection)
            {
                result.Add(element.InnerText);
            }

            return result;
        }

        private static IDictionary<string, int> GetNumberOfAlbumsForEachArtist(XmlElement rootNode)
        {
            var result = new Dictionary<string, int>();
            var albums = rootNode.GetElementsByTagName("album");

            foreach (XmlNode album in albums)
            {
                var artist = album["artist"].InnerText;
                if (!result.ContainsKey(artist))
                {
                    result[artist] = 0;
                }

                result[artist]++;
            }

            return result;
        }
    }
}