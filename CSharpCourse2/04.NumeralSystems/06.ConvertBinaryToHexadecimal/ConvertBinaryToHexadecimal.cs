using System;

/*Write a program to convert binary numbers to
hexadecimal numbers (directly).*/

class ConvertBinaryToHexadecimal
{
    static string AddZeroes(string binaryNumber)
    {
        while (binaryNumber.Length % 4 != 0 || binaryNumber.Length < 4)
        {
            binaryNumber.Insert(0, "0");
        }
        return binaryNumber;
    }

    static void Main()
    {
        Console.Write("Enter number in binary: ");
        string binaryNumber = Console.ReadLine();
        
    }
}