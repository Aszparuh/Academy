using System;
using System.Collections.Generic;

/*Write a program to convert decimal numbers to their
binary representation.*/

class ConvertDecimalNumberToBinary
{
    static List<byte> NumberToBinary(int number)
    {
        List<byte> array = new List<byte>();
        while (number > 0)
        {
            array.Add(Convert.ToByte(number & 1));
            number >>= 1;
        }
        return array;
    }
    static void PrintBinaryRepresentation(List<byte> array)
    {
        for (int i = array.Count - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
        }
    }
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The binary representation of the chosen number is: ");
        PrintBinaryRepresentation(NumberToBinary(number));
        Console.WriteLine();
    }
}

