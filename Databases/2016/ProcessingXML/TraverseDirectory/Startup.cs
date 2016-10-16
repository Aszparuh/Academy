using System;
using System.IO;
using System.Xml;

namespace TraverseDirectory
{
    public class Startup
    {
        public static void Main()
        {
            var outputPath = "../../../DocumentsXML/directories.xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (XmlWriter writer = XmlWriter.Create(outputPath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Desktop");
                Traverse(desktopPath, writer);
                writer.WriteEndDocument();
            }
        }

        private static void Traverse(string path, XmlWriter writer)
        {
            Console.WriteLine("Traversing {0}", path);
            foreach (var directory in Directory.GetDirectories(path))
            {
                writer.WriteStartElement("directory");
                writer.WriteAttributeString("path", directory);
                Traverse(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(path))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("extension", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}
