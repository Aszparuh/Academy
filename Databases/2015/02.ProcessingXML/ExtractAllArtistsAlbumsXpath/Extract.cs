namespace ExtractAllArtistsAlbumsXpath
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml;

    class Extract
    {
        static void Main()
        {
            string xPathQuery = "/catalogue/album";
            var document = new XmlDocument();
            document.Load("../../../catalog.xml");
            var allAlbums = document.SelectNodes(xPathQuery);
            var allArtists = GetArtistsFromCatalog(allAlbums);

            foreach (var pair in allArtists)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }

        private static Dictionary<string, int> GetArtistsFromCatalog(IEnumerable albumsList)
        {
            var resultCollection = new Dictionary<string, int>();
            foreach (XmlNode album in albumsList)
            {
                var artistName = album.SelectSingleNode("artist").InnerText;
                if (!resultCollection.ContainsKey(artistName))
                {
                    resultCollection[artistName] = 0;
                }

                resultCollection[artistName]++;
            }

            return resultCollection;
        }
    }
}