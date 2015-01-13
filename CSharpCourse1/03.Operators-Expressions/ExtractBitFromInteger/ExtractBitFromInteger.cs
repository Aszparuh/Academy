using System;

/*Write an expression that extracts from given integer n the value of given bit at index p.*/

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int maskAndI = mask & n;
        int bit = maskAndI >> b;

        Console.WriteLine("The value of the chosen bit is: " + bit);
        Console.WriteLine();
        Console.WriteLine("    Your number in binary: " + Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("                     Mask: " + Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(" Number and Mask binary &: " + Convert.ToString(maskAndI, 2).PadLeft(32, '0'));
    }
}