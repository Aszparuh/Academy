using System;


/*Write a program to convert decimal numbers to their
binary representation.*/

class ConvertDecimalNumberToBinary
{
    static byte[] PosNumberToBinary(int number)
    {
        byte[] array = new byte[32];
        for (int i = 0; number > 0; i++)
        {

            array[i] = Convert.ToByte(number & 1);
            number >>= 1;
        }
        return array;
    }
    static void PrintBinaryRepresentation(byte[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
        }
    }
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of the chosen number is: ");
        PrintBinaryRepresentation(PosNumberToBinary(number));
        Console.WriteLine();
    }
}

