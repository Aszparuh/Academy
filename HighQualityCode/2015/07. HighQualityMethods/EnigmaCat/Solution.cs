namespace EnigmaCat
{
    using System;
    using System.Text;

    internal class Solution
    {
        private static char[] aplhabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        internal static void Main()
        {
            ////input
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] result = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                result[i] = ConvertToTwentySix(ConvertToDecimal(ReverseString(words[i])));
            }

            Console.WriteLine(string.Join(" ", result));
        }

        internal static ulong ConvertToDecimal(string formattedString)
        {
            ulong result = 0;
            for (int i = 0; i < formattedString.Length; i++)
            {
                ulong digit = 0;
                switch (formattedString[i])
                {
                    case 'a': digit = 0;
                        break;
                    case 'b': digit = 1;
                        break;
                    case 'c': digit = 2;
                        break;
                    case 'd': digit = 3;
                        break;
                    case 'e': digit = 4;
                        break;
                    case 'f': digit = 5;
                        break;
                    case 'g': digit = 6;
                        break;
                    case 'h': digit = 7;
                        break;
                    case 'i': digit = 8;
                        break;
                    case 'j': digit = 9;
                        break;
                    case 'k': digit = 10;
                        break;
                    case 'l': digit = 11;
                        break;
                    case 'm': digit = 12;
                        break;
                    case 'n': digit = 13;
                        break;
                    case 'o': digit = 14;
                        break;
                    case 'p': digit = 15;
                        break;
                    case 'q': digit = 16;
                        break;
                    case 'r': digit = 17;
                        break;
                    case 's': digit = 18;
                        break;
                    case 't': digit = 19;
                        break;
                    case 'u': digit = 20;
                        break;
                    case 'v': digit = 21;
                        break;
                    case 'w': digit = 22;
                        break;
                    case 'x': digit = 23;
                        break;
                    case 'y': digit = 24;
                        break;
                    case 'z': digit = 25;
                        break;
                    default: Console.WriteLine("Error");
                        break;
                }

                result += digit * CalculatePower(17, i);
            }

            return result;
        }

        internal static ulong CalculatePower(ulong number, int power)
        {
            ulong result = 1;
            if (power == 0)
            {
                result = 1;
            }
            else if (power == 1)
            {
                result = number;
            }
            else
            {
                for (int i = power; i > 0; i--)
                {
                    result *= number;
                }
            }

            return result;
        }

        internal static string ReverseString(string anyString)
        {
            char[] array = anyString.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        internal static string ConvertToTwentySix(ulong number)
        {
            StringBuilder sb = new StringBuilder();
            if (number == 0)
            {
                sb.Append('a');
            }

            while (number > 0)
            {
                int digit = (int)(number % 26);
                char current = aplhabet[digit];
                sb.Append(current);
                number = number / 26;
            }

            return ReverseString(sb.ToString());
        }
    }
}