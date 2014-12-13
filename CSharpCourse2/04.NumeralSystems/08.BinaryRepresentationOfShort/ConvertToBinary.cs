using System;

/*Write a program that shows the binary
representation of given 16-bit signed integer number
(the C# type short).*/

class ConvertToBinary
{
    static byte[] NegConvertToBinary(short number)
    {
        byte[] array = new byte[16];
        short temp = (short)(short.MaxValue + number);
        for (int i = 0; temp > 0; i++)
        {
            array[i] = Convert.ToByte(temp & 1);
            temp >>= 1;
        }
        array[15] = 1;
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
        Console.WriteLine("Enter number: ");
        short number = short.Parse(Console.ReadLine());
    }
}

