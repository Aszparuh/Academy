namespace DecimalToBinary
{
    using System;
    using System.Text;

    class Start
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(input));
        }

        static string DecimalToBinary(long number)
        {
            string result = string.Empty;

            while (number != 0)
            {
                long bit = number % 2;
                result = bit + result;
                number /= 2;
            }

            return result;
        }
    }
}
