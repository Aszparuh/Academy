namespace SumIntegers
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();

            Console.WriteLine(input.Sum());
        }
    }
}
