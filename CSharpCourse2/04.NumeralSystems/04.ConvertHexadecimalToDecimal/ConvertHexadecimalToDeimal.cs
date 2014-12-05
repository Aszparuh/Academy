using System;
using System.Collections.Generic;

/*Write a program to convert hexadecimal numbers to
their decimal representation.*/

class ConvertHexadecimalToDeimal
{
    static string FormatString(string numberAsString)
    {
        if (numberAsString[0] == '0' && numberAsString[1] == 'x')
        {
            numberAsString = numberAsString.Substring(2);
        }
        numberAsString.ToUpper();
        ReverseString(numberAsString);
        return numberAsString;
    }
    static int ConvertToDecimal(string formatedString)
    {

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
    static void Main()
    {
        Console.Write("Enter number in hexadecimal: ");
        string numberHex = Console.ReadLine();
        

    }
}

