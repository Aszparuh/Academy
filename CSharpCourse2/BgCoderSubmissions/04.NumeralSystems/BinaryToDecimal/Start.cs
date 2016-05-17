namespace BinaryToDecimal
{
    using System;

    class Start
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(input));
        }

        static long BinaryToDecimal(string binaryNumber)
        {
            long sum = 0;

            foreach (var bit in binaryNumber)
            {
                sum = (bit - '0') + sum * 2;
            }

            return sum;
        }
    }
}
