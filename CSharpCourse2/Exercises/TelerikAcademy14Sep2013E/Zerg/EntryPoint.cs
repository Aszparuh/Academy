namespace Zerg
{
    using System;
    using System.Collections.Generic;

    class EntryPoint
    {
        static Dictionary<string, int> alphabet = new Dictionary<string, int>()
        {
            { "Rawr", 0 },
            { "Rrrr", 1 },
            { "Hsst", 2 },
            { "Ssst", 3 },
            { "Grrr", 4 },
            { "Rarr", 5 },
            { "Mrrr", 6 },
            { "Psst", 7 },
            { "Uaah", 8 },
            { "Uaha", 9 },
            { "Zzzz", 10 },
            { "Bauu", 11 },
            { "Djav", 12 },
            { "Myau", 13 },
            { "Gruh", 14 }
        };

        static long Convert(string input)
        {
            long result = 0;

            for (int i = 0; i < input.Length; i += 4)
            {
                result = alphabet[input.Substring(i, 4)] + result * 15;
            }

            return result;
        }

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Convert(input));
        }
    }
}
