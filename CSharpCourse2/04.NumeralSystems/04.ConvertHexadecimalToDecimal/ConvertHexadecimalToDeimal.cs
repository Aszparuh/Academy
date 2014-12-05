using System;
using System.Collections.Generic;

/*Write a program to convert hexadecimal numbers to
their decimal representation.*/

class ConvertHexadecimalToDeimal
{
    static int ConvertToDecimal(string numberAsString)
    {
        if (numberAsString[0] == '0' && numberAsString[1] == 'x')
        {
            numberAsString = numberAsString.Substring(2);
        }
        Console.WriteLine(numberAsString);
        return 0;
    }
    static void Main()
    {
        Console.Write("Enter number in hexadecimal: ");
        string numberHex = Console.ReadLine();
        ConvertToDecimal(numberHex);

    }
}

