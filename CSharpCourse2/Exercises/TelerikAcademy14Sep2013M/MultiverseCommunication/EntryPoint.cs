namespace MultiverseCommunication
{
    //100/100 BgCoder
    using System;
    using System.Collections.Generic;

    class EntryPoint
    {
        static Dictionary<string, int> alphabet = new Dictionary<string, int>()
        {
            { "CHU", 0 },
            { "TEL", 1 },
            { "OFT", 2 },
            { "IVA", 3 },
            { "EMY", 4 },
            { "VNB", 5 },
            { "POQ", 6 },
            { "ERI", 7 },
            { "CAD", 8 },
            { "K-A", 9 },
            { "IIA", 10 },
            { "YLO", 11 },
            { "PLA", 12}
        };

        static long Convert(string input)
        {
            long result = 0;

            for (int i = 0; i < input.Length; i += 3)
            {
                result = alphabet[input.Substring(i, 3)] + result * 13;
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
