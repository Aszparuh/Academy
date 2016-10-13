namespace ExtractAllSongsXmlReader
{
    using System;
    using System.Xml;

    internal class Extract
    {
        private static void Main()
        {
            var reader = XmlReader.Create("../../../catalog.xml");

            using (reader)
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}