using System.Xml;

namespace ExtractAlbumInfo
{
    public class Startup
    {
        public static void Main()
        {
            var path = "../../../DocumentsXML/catalogue.xml";
            var outputPath = "../../../DocumentsXML/albums.xml";

            using (XmlReader reader = XmlReader.Create(path))
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "\t";
                using (XmlWriter writer = XmlWriter.Create(outputPath, settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                reader.Read();
                                writer.WriteElementString("name", reader.Value);
                            }
                            else if (reader.Name == "artist")
                            {
                                reader.Read();
                                writer.WriteElementString("artist", reader.Value);
                                writer.WriteEndElement();
                            }
                        }
                    }

                    writer.WriteEndDocument();
                }
            }

            System.Console.WriteLine("All done");
        }
    }
}
