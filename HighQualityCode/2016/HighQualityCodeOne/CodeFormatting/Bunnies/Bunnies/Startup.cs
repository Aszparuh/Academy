namespace High.Quality.Code.BadExample
{
    using System.Collections.Generic;
    using System.IO;
    using Bunnies.Contracts;
    using Bunnies.Models;

    public class Startup
    {
        private const string BunniesFilePath = @"..\..\bunnies.txt";

        public static void Main()
        {
            var bunnies = CreateBunnies();

            var consoleWriter = new ConsoleWriter();
            IntroduceBunnies(consoleWriter, bunnies);

            SaveBunniesToFile(bunnies);
        }

        public static IEnumerable<IBunny> CreateBunnies()
        {
            var bunnies = new List<IBunny>
            {
                new Bunny("Leonid", 1, FurType.NotFluffy),
                new Bunny("Rasputin", 2, FurType.ALittleFluffy),
                new Bunny("Tiberii", 3, FurType.ALittleFluffy),
                new Bunny("Neron", 1, FurType.ALittleFluffy),
                new Bunny("Klavdii", 3, FurType.Fluffy),
                new Bunny("Vespasian", 3, FurType.Fluffy),
                new Bunny("Domician", 4, FurType.FluffyToTheLimit),
                new Bunny("Tit", 2, FurType.FluffyToTheLimit)
            };

            return bunnies;
        }

        public static void IntroduceBunnies(IWriter writer, IEnumerable<IBunny> bunnies)
        {
            foreach (var bunny in bunnies)
            {
                bunny.Introduce(writer);
            }
        }

        public static void SaveBunniesToFile(IEnumerable<IBunny> bunnies)
        {
            using (var streamWriter = new StreamWriter(BunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}