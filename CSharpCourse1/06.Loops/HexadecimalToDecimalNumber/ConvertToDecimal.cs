using System;

/*Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

class ConvertToDecimal
{
    static string FormatString(string numberAsString)
    {
        if (numberAsString[0] == '0' && numberAsString[1] == 'x')
        {
            numberAsString = numberAsString.Substring(2);
        }

        return ReverseString(numberAsString.ToUpper());
    }

    static long ToDecimal(string formattedString)
    {
        long result = 0;
        for (int i = 0; i < formattedString.Length; i++)
        {
            int digit;
            switch (formattedString[i])
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
                default: digit = formattedString[i] - 48; // default: digit = int.Parse(Convert.ToString(formattedString[i]));
                    break;
            }

            result += digit * CalculatePower(16, i);
        }

        return result;
    }

    static long CalculatePower(int number, int power)
    {
        long result = 1;
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

    static void Main()
    {
        Console.Write("Enter number in hexadecimal: ");
        string numberHex = Console.ReadLine();
        string formatted = FormatString(numberHex);
        Console.Write("Your number in decimal is: ");
        Console.Write(ToDecimal(formatted));
        Console.WriteLine();
    }
}