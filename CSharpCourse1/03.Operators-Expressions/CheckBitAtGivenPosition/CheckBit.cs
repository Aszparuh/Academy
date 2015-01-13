using System;

/* Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in
 * given integer number n, has value of 1.*/

class CheckBit
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
        bool isOne = false;

        if (bit == 1)
        {
            isOne = true;
        }

        Console.WriteLine(isOne);
    }
}