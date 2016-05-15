namespace IntegerCalculations
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(n => int.Parse(n))
                .ToArray();

            long sum = 0;
            long product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                product *= numbers[i];

            }


            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine("{0:0.00}", sum / (float)numbers.Length);
            Console.WriteLine(sum);
            Console.WriteLine(product);

            //Console.WriteLine("{0:0.00}", numbers.Average());
            //Console.WriteLine(numbers.Sum());
            //Console.WriteLine(numbers.Aggregate((acc, val) => acc * val));
        }
    }
}
