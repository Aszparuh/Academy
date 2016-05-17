namespace DecimalToHexadecimal
{
    using System;

    class Start
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHexadecimal(input));
        }

        static string DecimalToHexadecimal(long number)
        {
            string result = string.Empty;

            while (number != 0)
            {
                long decDigit = number % 16;
                if (decDigit < 10)
                {
                    result = (char)(decDigit + '0') + result;
                }
                else
                {
                    result = (char)(decDigit + 55) + result;
                }

                number = number / 16;
            }

            return result;
        }
    }
}
