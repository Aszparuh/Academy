namespace OneSystemToAnyOther
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    class Start
    {
        static Dictionary<int, char> intToHex = new Dictionary<int, char>()
        {
            {0 , '0'},
            {1 , '1'},
            {2 , '2'},
            {3 , '3'},
            {4 , '4'},
            {5 , '5'},
            {6 , '6'},
            {7 , '7'},
            {8 , '8'},
            {9 , '9'},
            {10 , 'A'},
            {11 , 'B'},
            {12 , 'C'},
            {13 , 'D'},
            {14 , 'E'},
            {15 , 'F'},
        };

        static Dictionary<char, int> hexValues = new Dictionary<char, int>()
        {
            {'0', 0  },
            {'1', 1  },
            {'2', 2  },
            {'3', 3  },
            {'4', 4  },
            {'5', 5  },
            {'6', 6  },
            {'7', 7  },
            {'8', 8  },
            {'9', 9  },
            {'A', 10 },
            {'B', 11 },
            {'C', 12 },
            {'D', 13 },
            {'E', 14 },
            {'F', 15 },
        };

        static void Main()
        {
            int inputSystem = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int outputSystem = int.Parse(Console.ReadLine());
            Console.WriteLine(DecToAnything(ToDecimal(input, inputSystem), outputSystem));
        }

        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            BigInteger sum = 0;
            foreach (char item in input)
            {
                sum = hexValues[item] + sum * inputNumSystem;
            }
            return sum;
        }

        static string DecToAnything(BigInteger decValue, int outputBase)
        {
            string result = "";

            do
            {
                BigInteger reminder = decValue % outputBase;
                result = intToHex[(int)reminder] + result;
                decValue /= outputBase;
            } while (decValue > 0);

            return result;
        }

    }
}
