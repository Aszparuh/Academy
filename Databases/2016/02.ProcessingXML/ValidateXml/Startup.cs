using System;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ValidateXml
{
    public class Startup
    {
        public static void Main()
        {
            var schema = new XmlSchemaSet();
            var schemaPath = "../../../DocumentsXML/catalogue.xsd";
            var cataloguePath = "../../../DocumentsXML/catalogue.xml";
            var invalidCataloguePath = "../../../DocumentsXML/invalid-catalogue.xml";

            schema.Add(string.Empty, schemaPath);
            XDocument document = XDocument.Load(cataloguePath);
            XDocument invalidDocument = XDocument.Load(invalidCataloguePath);

            document.Validate(schema, (obj, ev) => { Console.WriteLine("{0}", ev.Message); });
            invalidDocument.Validate(schema, (obj, ev) => { Console.WriteLine("{0}", ev.Message); });
        }
    }
}
