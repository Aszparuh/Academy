using System;
using System.IO;
using System.Xml.Linq;

namespace TraverseDirectoryXDocument
{
    public class Startup
    {
        public static void Main()
        {
            var outputPath = "../../../DocumentsXML/directoriesX.xml";
            var desktop = Traverse(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            desktop.Save(outputPath);
        }

        private static XElement Traverse(string directory)
        {
            var element = new XElement("directory", new XAttribute("path", directory));
            Console.WriteLine("Traversing {0}", directory);
            foreach (var dir in Directory.GetDirectories(directory))
            {
                element.Add(Traverse(dir));
            }

            foreach (var file in Directory.GetFiles(directory))
            {
                element.Add(new XElement(
                    "file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
