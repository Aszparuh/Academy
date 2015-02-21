namespace OneSystemToAnyOther
{
    using System;

    /*Write a program to convert from any numeral system of given base s to any other numeral 
     system of base d (2 ≤ s, d ≤ 16).*/

    class ConvertSystemToSystem
    {
        static string ConvertFormDecimalToAny(int number, int baseForm)
        {
            string result = string.Empty;
            for (int i = 0; number > 0; i++)
            {
                int temp = number % baseForm;
                switch (temp)
                {
                    case 0: result += "0";
                        break;
                    case 1: result += "1";
                        break;
                    case 2: result += "2";
                        break;
                    case 3: result += "3";
                        break;
                    case 4: result += "4";
                        break;
                    case 5: result += "5";
                        break;
                    case 6: result += "6";
                        break;
                    case 7: result += "7";
                        break;
                    case 8: result += "8";
                        break;
                    case 9: result += "9";
                        break;
                    case 10: result += "A";
                        break;
                    case 11: result += "B";
                        break;
                    case 12: result += "C";
                        break;
                    case 13: result += "D";
                        break;
                    case 14: result += "E";
                        break;
                    case 15: result += "F";
                        break;
                    default: Console.WriteLine("Error");
                        break;
                }
                number /= baseForm;
            }
            return ReverseString(result);
        }

        static int ConvertFromAnyToDecimal(string numberAsString, int baseFrom)
        {
            int result = 0;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                int digit;
                switch (numberAsString[i])
                {
                    case 'A': digit = 10;
                        break;
                    case 'B': digit = 11;
                        break;
                    case 'C': digit = 12;
                        break;
                    case 'D': digit = 13;
                        break;
                    case 'E': digit = 14;
                        break;
                    case 'F': digit = 15;
                        break;
                    default: digit = numberAsString[i] - 48; // default: digit = int.Parse(Convert.ToString(formattedString[i]));
                        break;
                }

                result += digit * CalculatePower(baseFrom, i);
            }

            return result;
        }

        static int CalculatePower(int number, int power)
        {
            int result = 1;
            if (power == 0)
            {
                result = 1;
            }
            else if (power == 1)
            {
                result = number;
            }
            else
            {
                for (int i = power; i > 0; i--)
                {
                    result *= number;
                }
            }

            return result;
        }

        static string ReverseString(string anyString)
        {
            char[] array = anyString.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static bool ValidateInput(string numberAsString, int startBase)
        {
            bool isValid = true;
            int digit = 0;
            foreach (var item in numberAsString)
            {
                digit = item - 48;
                if (digit < 0 || digit >= startBase)
                {
                    isValid = false;
                }
            }
            if (!isValid)
            {
                Console.WriteLine("The number is not valid in the current numeral system");
            }

            return isValid;
        }

        static void Main()
        {
            Console.Write("Enter the numeral system to convert from: ");
            int startBase = int.Parse(Console.ReadLine());
            Console.Write("Enter the numeral system to convert to: ");
            int endBase = int.Parse(Console.ReadLine());
            Console.Write("Enter the number: ");
            string inputString = ReverseString(Console.ReadLine());
            string numberAsString = inputString.ToUpper();
            if (ValidateInput(numberAsString, startBase))
            {
                int asDecimal = ConvertFromAnyToDecimal(numberAsString, startBase);
                Console.Write("The converted number is: ");
                Console.Write(ConvertFormDecimalToAny(asDecimal, endBase));
                Console.WriteLine();
            }
        }
    }
}