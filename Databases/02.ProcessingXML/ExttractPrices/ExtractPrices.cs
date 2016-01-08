namespace ExtractPrices
{
    using System;
    using System.Xml.Linq;
    using System.Linq;

    class ExtractPrices
    {
        static void Main()
        {
            var document = XDocument.Load("../../../catalog.xml");
            var albums =
                from album in document.Descendants("album")
                where album.Element("year").Value.Contains("198")
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            foreach (var album in albums)
            {
                Console.WriteLine("{0}: {1}", album.Name, album.Price);
            }
        }
    }
}