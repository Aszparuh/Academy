using System;
using System.IO;
using System.Xml;

namespace TransoformToXML
{
    public class Startup
    {
        public static void Main()
        {
            var path = "../../../DocumentsXML/persons.txt";
            XmlDocument outputDocument = new XmlDocument();
            var declaration = outputDocument.CreateXmlDeclaration("1.0", null, null);
            XmlElement rootNode = outputDocument.CreateElement("persons");
            outputDocument.AppendChild(rootNode);
            outputDocument.InsertBefore(declaration, rootNode);

            using (StreamReader textFileReader = new StreamReader(path))
            {
                string line;
                while ((line = textFileReader.ReadLine()) != null)
                {
                    XmlElement person = outputDocument.CreateElement("person");
                    XmlElement name = outputDocument.CreateElement("name");
                    XmlElement address = outputDocument.CreateElement("address");
                    XmlElement phone = outputDocument.CreateElement("phone");
                    name.InnerText = line;
                    Console.WriteLine("Adds name {0}", line);
                    var addressText = textFileReader.ReadLine();
                    address.InnerText = addressText;
                    Console.WriteLine("Adds address {0}", addressText);
                    var phoneText = textFileReader.ReadLine();
                    phone.InnerText = phoneText;
                    Console.WriteLine("Adds phone {0}", phoneText);
                    person.AppendChild(name);
                    person.AppendChild(address);
                    person.AppendChild(phone);
                    rootNode.AppendChild(person);
                }
            }

            outputDocument.Save("../../../DocumentsXML/persons.xml");
        }
    }
}
