using System;

class ExtractBinaryValue
{
    static void Main()
    {
        Console.Write("Enter value for i: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the bit: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int maskAndI = mask & i;
        int bit = maskAndI >> b;

        Console.WriteLine("The value of the chosen bit is: " + bit);
        Console.WriteLine();
        Console.WriteLine("    Your number in binary: " + Convert.ToString(i, 2).PadLeft(32, '0'));
        Console.WriteLine("                     Mask: " + Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(" Number and Mask binary &: " + Convert.ToString(maskAndI, 2).PadLeft(32, '0'));

    }
}

