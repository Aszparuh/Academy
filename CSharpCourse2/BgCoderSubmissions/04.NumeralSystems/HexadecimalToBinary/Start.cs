namespace HexadecimalToBinary
{
    using System;
    using System.Collections.Generic;

    class Start
    {
        static Dictionary<char, string> HexBin = new Dictionary<char, string>()
        {
            {'0', "0000"},
            {'1', "0001"},
            {'2', "0010"},
            {'3', "0011"},
            {'4', "0100"},
            {'5', "0101"},
            {'6', "0110"},
            {'7', "0111"},
            {'8', "1000"},
            {'9', "1001"},
            {'A', "1010"},
            {'B', "1011"},
            {'C', "1100"},
            {'D', "1101"},
            {'E', "1110"},
            {'F', "1111"}
        };

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(HexadecimalToBinary(input).TrimStart(new Char[] { '0' }));
        }

        static string HexadecimalToBinary(string hexNumber)
        {
            string[] result = new string[hexNumber.Length];

            for (int i = 0; i < hexNumber.Length; i++)
            {
                result[i] = HexBin[hexNumber[i]];
            }

            return string.Join(string.Empty, result);
        }
    }
}
