namespace HexadecimalToDecimal
{
    using System;

    class Start
    {
        static void Main()
        {
            string inputNumber = Console.ReadLine();
            Console.WriteLine(HexadecimalToDecimal(inputNumber));
        }

        static long HexadecimalToDecimal(string hex)
        {
            long result = 0;
            byte currentValue;
            hex = hex.ToUpper();

            for (int current = 0; current < hex.Length; current++)
            {
                result *= 16;
                if (Char.IsLetter(hex[current]))
                {
                    currentValue = (byte)(hex[current] - 55);
                }
                else
                {
                    currentValue = (byte)(hex[current] - '0');
                }                   

                result += currentValue;
            }

            return result;
        }
    }
}
