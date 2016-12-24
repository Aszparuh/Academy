using System;
using System.Collections.Generic;
using System.Linq;

namespace SafeFlights
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfIslands = int.Parse(Console.ReadLine());
            var islands = new Dictionary<int, int>();

            var line = Console.ReadLine();
            while (line != "-1 -1")
            {
                var input = line.Split(' ').Select(x => int.Parse(x)).ToArray();
                var id = input[0] + input[1];

                if (islands.ContainsKey(id))
                {
                    islands[id]++;
                }
                else
                {
                    islands.Add(id, 1);
                }

                line = Console.ReadLine();
            }

            int counter = 0;
            foreach (KeyValuePair<int, int> item in islands)
            {
                if (item.Value == 1)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
