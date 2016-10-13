namespace RemoveExpensiveAlbums
{
    using System;
    using System.Xml;

    internal class Remove
    {
        private static void Main()
        {
            var document = new XmlDocument();
            document.Load("../../../catalog.xml");

            var rootNode = document.DocumentElement;
            foreach (XmlElement album in rootNode.SelectNodes("album"))
            {
                var price = double.Parse(album["price"].InnerText);
                if (price > 20)
                {
                    rootNode.RemoveChild(album);
                }
            }

            document.Save("../../cheap-albums.xml");
        }
    }
}