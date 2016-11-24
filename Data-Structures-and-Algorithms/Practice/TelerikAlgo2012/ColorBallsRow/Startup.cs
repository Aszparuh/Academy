using System;
using System.Collections.Generic;
using System.Numerics;

namespace ColorBallsRow
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var numberOfBalls = input.Length;
            var numberOfBallsFactorial = CalculateFactorial(numberOfBalls);
            var dictionary = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (dictionary.ContainsKey(character))
                {
                    dictionary[character] += 1;
                }
                else
                {
                    dictionary.Add(character, 1);
                }
            }

            BigInteger result = numberOfBallsFactorial;
            foreach (KeyValuePair<char, int> entry in dictionary)
            {
                result /= CalculateFactorial(entry.Value);
            }

            Console.WriteLine(result);
        }

        private static BigInteger CalculateFactorial(int number)
        {
            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
