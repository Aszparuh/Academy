using System;

/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());
        int positon = 3;
        int mask = 1 << positon;
        int maskAndNumber = mask & number;
        int bit = maskAndNumber >> positon;
        

        Console.WriteLine("The bit at position 3 is {0} ", bit );
        Console.WriteLine();
        Console.WriteLine("    Your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("                     Mask: " + Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(" Number and Mask binary &: " + Convert.ToString(maskAndNumber, 2).PadLeft(32, '0'));
    }
}