namespace ABandCRefactored
{
    using System;
    using System.Linq;

    public class ABandC
    {
        public static void Main()
        {
            ////input
            int numberOfIntegers = 3;
            int[] numbers = new int[numberOfIntegers];
            int length = numbers.Length;

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            ////logic
            int min = numbers.Min();
            int max = numbers.Max();
            double arithmeticMean = numbers.Average();

            ////output
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F3}", arithmeticMean);
        }
    }
}