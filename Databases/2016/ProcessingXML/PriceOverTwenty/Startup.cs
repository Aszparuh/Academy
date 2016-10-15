using System;
using System.Collections.Generic;
using System.Xml;

namespace PriceOverTwenty
{
    public class Startup
    {
        public static void Main()
        {
            var path = "../../../DocumentsXML/catalogue.xml";
            XmlDocument document = new XmlDocument();
            document.Load(path);
            XmlNode rootNode = document.DocumentElement;
            List<XmlNode> nodesToBeDeleted = new List<XmlNode>();

            foreach (XmlNode node in rootNode)
            {
                var priceNode = node["price"];
                int price;
                int.TryParse(priceNode.InnerText, out price);

                if (price > 20)
                {
                    var albumToDelete = priceNode.ParentNode;
                    nodesToBeDeleted.Add(albumToDelete);
                }
            }

            foreach (XmlNode node in nodesToBeDeleted)
            {
                rootNode.RemoveChild(node);
            }

            Console.WriteLine("All albums with price higher than 20 are deleted");
            var savePath = "../../../DocumentsXML/cheap-catalogue.xml";
            document.Save(savePath);
        }
    }
}
