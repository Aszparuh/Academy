using System;

/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold 
the value v at the position p from the binary representation of n while preserving 
all other bits in n.*/

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position from 0 to 32: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter value 1 or 0: ");
        int value = int.Parse(Console.ReadLine());
        if (value != 1 && value != 0)
        {
            Console.WriteLine("Value should be 0 or 1.");
        }
        else
        {
            if (position > 32)
            {
                Console.WriteLine("Position should be from 0 to 32");
            }
            else
            {
                if (value == 1)
                {
                    int mask = 1 << position;
                    int result = mask | number;

                    Console.WriteLine("The bit on position {0} was changed to 1", position);
                    Console.WriteLine("The result is: {0}", result);
                    Console.WriteLine();
                    Console.WriteLine("    Your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
                    Console.WriteLine("                     Mask: " + Convert.ToString(mask, 2).PadLeft(32, '0'));
                    Console.WriteLine("  Number or Mask binary &: " + Convert.ToString(result, 2).PadLeft(32, '0'));
                }
                else
                {
                    int mask = ~(1 << position);
                    int result = mask & number;

                    Console.WriteLine("The bit on position {0} was changed to 0", position);
                    Console.WriteLine("The result is: {0}", result);
                    Console.WriteLine();
                    Console.WriteLine("    Your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
                    Console.WriteLine("                     Mask: " + Convert.ToString(mask, 2).PadLeft(32, '0'));
                    Console.WriteLine("  Number or Mask binary &: " + Convert.ToString(result, 2).PadLeft(32, '0'));
                }
            }
        }
    }
}