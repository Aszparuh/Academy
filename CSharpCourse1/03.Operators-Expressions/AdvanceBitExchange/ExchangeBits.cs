using System;

/*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("Enter starting position for the first bytes: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter starting position for the second bytes: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of byte that you wish to exchange: ");
        int k = int.Parse(Console.ReadLine());
        bool isOverlapping = false;

        // Check overlapping
        if (q > p)
        {
            if (p + k - 1 >= q)
            {
                isOverlapping = true;
            }
        }
        if (q < p)
        {
            if (q + k - 1 >= p)
            {
                isOverlapping = true;
            }
        }
        // Check if it is out of range
        if (q < 0 || q + k - 1 > 32)
        {
            Console.WriteLine("out of range");
        }
        else if (p < 0 || p + k - 1 > 32)
        {
            Console.WriteLine("out of range");
        }
        else if (isOverlapping)
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            long result = n;
            for (int i = 0; i < k; i++)
            {
                long bitP = (result >> p) & 1;
                long bitQ = (result >> q) & 1;

                if (bitP != bitQ)
                {
                    if (bitP == 1 && bitQ == 0)
                    {
                        result = result & (~(1 << p));
                        result = result | ((long)1 << q);
                    }
                    else
                    {
                        result = result & (~(1 << q));
                        result = result | ((long)1 << p);
                    }
                }

                p++;
                q++;
            }
            Console.WriteLine();
            Console.WriteLine("Number before the exchange in binary: ");
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine();
            Console.WriteLine("Number after the exchange in binary:  ");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine();
            Console.Write("The result is: ");
            Console.WriteLine(result);
        }
    }
}