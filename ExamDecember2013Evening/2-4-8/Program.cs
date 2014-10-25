using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        BigInteger R = 0;

        if (B == 2)
        {
            R = A % C;
        }
        else if (B == 4)
        {
            R = A + C;
        }
        else if (B == 8)            
        {
            R = A * C;
        }
        if (R % 4 == 0)
        {
            Console.WriteLine(R / 4);
        }
        else
        {
            Console.WriteLine(R % 4);
        }
        Console.WriteLine(R);
    }
}

