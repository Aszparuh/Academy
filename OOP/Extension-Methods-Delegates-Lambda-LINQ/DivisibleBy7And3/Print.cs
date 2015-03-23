namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Print
    {
        static void Main()
        {
            int length = 100;
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i;
            }

            //Using built-in and lambda
            var numbersDivisible = numbers.Where(nm => nm % 3 == 0 && nm % 7 == 0);
            Console.WriteLine(string.Join(", ", numbersDivisible));

            //Using Linq
            var numbersDivisibleQuery =
                from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine(string.Join(", ", numbersDivisibleQuery));
        }
    }
}