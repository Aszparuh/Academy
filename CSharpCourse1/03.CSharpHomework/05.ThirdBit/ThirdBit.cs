using System;
class ThirdBit
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());
        int postion = 3;
        int mask = 1 << postion;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> postion;

        Console.WriteLine("The third bit is: " + bit);       
        Console.WriteLine();
        Console.WriteLine("    Your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("                     Mask: " + Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(" Number and Mask binary &: " + Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));

    }
}

