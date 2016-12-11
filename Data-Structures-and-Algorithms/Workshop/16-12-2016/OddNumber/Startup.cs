using System;

namespace OddNumber
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfValues = int.Parse(Console.ReadLine());
            long num = 0;

            for (int i = 0; i < numberOfValues; i++)
            {
                num ^= long.Parse(Console.ReadLine());
            }

            Console.WriteLine(num);
        }
    }
}
