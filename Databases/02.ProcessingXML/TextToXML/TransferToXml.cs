namespace TextToXML
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    internal class TransferToXml
    {
        private static void Main()
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../test.txt"))
            {
                person.Name = reader.ReadLine();
                person.PhoneNumber = reader.ReadLine();
                person.City = reader.ReadLine();
            }

            XElement personElement = new XElement("person",
                new XElement("name", person.Name),
                new XElement("phoneNumber", person.PhoneNumber),
                new XElement("city", person.City));

            personElement.Save("../../output.xml");
            Console.WriteLine("Done");
        }
    }
}