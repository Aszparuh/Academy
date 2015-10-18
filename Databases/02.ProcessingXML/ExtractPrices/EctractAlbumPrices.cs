namespace ExtractPrices
{
    using System;
    using System.Xml;

    internal class EctractAlbumPrices
    {
        private static void Main()
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../../catalog.xml");
            XmlNode rootNode = document.DocumentElement;
            string xPathYearQuery = "/catalogue/album";
            XmlNodeList albumPrices = rootNode.SelectNodes(xPathYearQuery);
            var currentYear = DateTime.Now.Year;

            foreach (XmlNode album in albumPrices)
            {
                var year = int.Parse(album.SelectSingleNode("year").InnerText);
                if (year < currentYear - 5)
                {
                    Console.WriteLine("Price: {0}", album.FirstChild.InnerText);
                }
                
            }
        }
    }
}