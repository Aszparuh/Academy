namespace BinaryShort
{
    using System;

    class Start
    {
        static void Main()
        {
            int decValue = int.Parse(Console.ReadLine());
            string result = string.Empty;
            if (decValue < 0)
            {
                result += "1";
                int temp = decValue + 1;
                result += DecimaToBinary(short.MaxValue + temp).PadLeft(15, '0');
            }
            else
            {
                result += "0";
                result += DecimaToBinary(decValue).PadLeft(15, '0');
            }

            Console.WriteLine(result);
        }

        static string DecimaToBinary(int decValue)
        {
            string result = "";

            do
            {
                int reminder = decValue % 2;
                result = reminder + result;
                decValue /= 2;
            } while (decValue > 0);
            return result;
        }
    }
}
