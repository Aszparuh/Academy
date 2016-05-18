namespace CalculationProblem
{
    using System;
    using System.Linq;

    class EntryPoint
    {
        static string alphabet = "abcdefghijklmnopqrstuvw";

        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            long result = 0;
            foreach (var number in input)
            {
                result += ConvertToDecimal(number);
            }

            Console.WriteLine("{0} = {1}", ConvertFromDecimal(result), result);
        }

        static long ConvertToDecimal(string input)
        {
            long result = 0;
                
            int currentValue;
                
            for (int current = 0; current < input.Length; current++)
            {
                result *= 23;                   
                currentValue = alphabet.IndexOf(input[current]);
                result += currentValue;
            }               
            
            return result;
        }

        static string ConvertFromDecimal(long number)
        {
            string result = string.Empty;

            do
            {
                int index = (int)(number % 23);
                result = alphabet[index] + result;
                number /= 23;
            } while (number != 0);

            return result;
        }
    }
}
