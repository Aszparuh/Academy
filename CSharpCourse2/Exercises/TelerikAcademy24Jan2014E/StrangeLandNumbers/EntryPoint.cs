namespace StrangeLandNumbers
{
    using System;
    using System.Collections.Generic;
    class EntryPoint
    {
        static Dictionary<string, int> alphabet = new Dictionary<string, int>()
        {
            { "F", 0 },
            { "BIN", 1 },
            { "OBJEC", 2 },
            { "MNTRAVL", 3 },
            { "LPVKNQ", 4 },
            { "PNWE", 5 },
            { "HT", 6 },
        };

        static long Convert(string input)
        {
            long result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'F')
                {
                    result = alphabet["F"] + result * 7;
                }
                else if (input[i] == 'B')
                {
                    result = alphabet["BIN"] + result * 7;
                    i += 2;
                }
                else if (input[i] == 'O')
                {
                    result = alphabet["OBJEC"] + result * 7;
                    i += 4;
                }
                else if (input[i] == 'M')
                {
                    result = alphabet["MNTRAVL"] + result * 7;
                    i += 6;
                }
                else if (input[i] == 'L')
                {
                    result = alphabet["LPVKNQ"] + result * 7;
                    i += 5;
                }
                else if (input[i] == 'P')
                {
                    result = alphabet["PNWE"] + result * 7;
                    i += 3;
                }
                else
                {
                    result = alphabet["HT"] + result * 7;
                    i += 1;
                }
            }           

            return result;
        }

        static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine(Convert(input));
        }
    }
}
