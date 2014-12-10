using System;

/*Write a program to convert from any numeral system
of given base s to any other numeral system of base
d (2 ≤ s, d ≤ 16).*/

class BaseXToBaseY
{ 
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

    static void Main()
    {
        Console.Write("Enter the numeral system to convert from: ");
        int startBase = int.Parse(Console.ReadLine());
        Console.Write("Enter the numeral system to convert to: ");
        int endBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number: ");
        string numberAsString = Console.ReadLine();
    }
}

