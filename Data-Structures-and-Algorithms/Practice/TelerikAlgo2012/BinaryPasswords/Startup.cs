using System;
using System.Linq;

namespace BinaryPasswords
{
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int countOfStars = input.Count(s => s == '*');

            long result = 1;

            for (int i = 0; i < countOfStars; i++)
            {
                result *= 2;
            }

            Console.WriteLine(result);
        }
    }
}
