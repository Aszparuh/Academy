using System;

/*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter starting position for the first bytes: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter starting position for the second bytes: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of byte that you wish to exchange: ");
        int k = int.Parse(Console.ReadLine());

        if (p + k - 1 >= q)
        {
            Console.WriteLine("overlapping");
        }
        else if (p < 0)
        {
            Console.WriteLine("out of range");
        }
        else if (q + k - 1 > 32)
        {
            Console.WriteLine("out of range");
        }
        else
        {
            Console.WriteLine("Chosen number in binary: " + Convert.ToString(n, 2).PadLeft(32, '0'));
            int result = n;
            for (int i = 0; i < k; i++)
            {
                int bitP = (result & (result << p)) >> p;
                int bitQ = (result & (result << q)) >> q;

                if (bitP != bitQ)
                {
                    if (bitP == 1 && bitQ == 0)
                    {
                        result = result & (~(1 << p));
                        result = result | (1 << q);
                    }
                    else
                    {
                        result = result & (~(1 << q));
                        result = result | (1 << p);
                    }
                }

                p++;
                q++;
            }

            Console.WriteLine(result);
        }
    }
}