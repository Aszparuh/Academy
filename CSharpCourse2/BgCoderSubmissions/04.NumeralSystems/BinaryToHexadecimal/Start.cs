namespace BinaryToHexadecimal
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Start
    {
        public static Dictionary<string, char> BinaryToHexTable = new Dictionary<string, char>()
        {
            {"0000", '0' },
            {"0001", '1' },
            {"0010", '2' },
            {"0011", '3' },
            {"0100", '4' },
            {"0101", '5' },
            {"0110", '6' },
            {"0111", '7' },
            {"1000", '8' },
            {"1001", '9' },
            {"1010", 'A' },
            {"1011", 'B' },
            {"1100", 'C' },
            {"1101", 'D' },
            {"1110", 'E' },
            {"1111", 'F' }
        };

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(BinaryToHexadecimalDOTNET(input));
        }

        public static string BinaryToHexadecimal(string number)
        {
            var result = new StringBuilder();

            for (int i = 0; i < number.Length; i += 4)
            {
                var key = number.Substring(i, 4);
                var value = BinaryToHexTable[key];
                result.Append(value);
            }

            // Remove leading zeros and return number in hexadecimal form
            return result.ToString().TrimStart(new Char[] { '0' });
        }

        public static string BinaryToHexadecimalDOTNET(string number)
        {
            // Binary to decimal
            var numberInDecimal = Convert.ToInt64(number, 2);

            // Decimal to hex
            var numberInHex = Convert.ToString(numberInDecimal, 16);

            return numberInHex;
        }
    }
}
