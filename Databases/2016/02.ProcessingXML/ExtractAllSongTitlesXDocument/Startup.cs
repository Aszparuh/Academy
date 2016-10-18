using System.Linq;
using System.Xml.Linq;

namespace ExtractAllSongTitlesXDocument
{
    public class Startup
    {
        public static void Main()
        {
            XDocument catalogue = XDocument.Load("../../../DocumentsXML/catalogue.xml");
            var songs = catalogue.Descendants().Where(x => x.Name == "title");

            foreach (XElement song in songs)
            {
                System.Console.WriteLine(song.Value);
            }
        }
    }
}
