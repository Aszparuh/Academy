namespace BinaryFloatingPoint
{
    using System;
    using System.Text;

    /*Write a program that shows the internal binary representation of given 32-bit signed floating-point 
      number in IEEE 754 format (the C# type float).
        Example:
        
        number	sign	exponent	mantissa
        -27,25	1	10000011	10110100000000000000000*/

    class ShowBinaryRep
    {
        static void Main()
        {
            float input;
            StringBuilder result = new StringBuilder();
            while (true)
            {
                Console.Write("Enter some folating point number: ");
                bool isFloat = float.TryParse(Console.ReadLine(), out input);
                if (!isFloat)
                {
                    Console.WriteLine("Invalid float format");
                    continue;
                }

                byte[] digits = BitConverter.GetBytes(input);
                result.Clear();
                for (int i = 3; i >= 0; i--)
                {
                    result.Append(Convert.ToString(digits[i], 2).PadLeft(8, '0'));
                }

                Console.WriteLine(result);
                Console.WriteLine("Sign: {0}, exponent: {1}, mantissa: {2}", result[0], result.ToString(1, 8), result.ToString(9, result.Length - 9));
            }
        }
    }
}
