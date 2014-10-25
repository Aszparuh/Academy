using System;

class BitPosition
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit postion: ");
        int positon = int.Parse(Console.ReadLine());
        int mask = 1 << positon;
        int maskAndNumber = mask & number;
        int bit = maskAndNumber >> positon;
        bool? isItOne = null;
        
        if (bit == 1)
        {
           isItOne = true;
        }
        else
        {
            isItOne = false;
        }

        Console.WriteLine("The bit at the chosen position is 1: " + isItOne);
        Console.WriteLine();
        Console.WriteLine("    Your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("                     Mask: " + Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(" Number and Mask binary &: " + Convert.ToString(maskAndNumber, 2).PadLeft(32, '0'));
    }
}

