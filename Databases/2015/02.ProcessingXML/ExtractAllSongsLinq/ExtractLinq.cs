namespace ExtractAllSongsLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class ExtractLinq
    {
        private static void Main()
        {
            var document = XDocument.Load("../../../catalog.xml");
            var songs =
                from song in document.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };

         
            foreach (var song in songs)
            {
                Console.WriteLine(song.Title);
            }
        }
    }
}