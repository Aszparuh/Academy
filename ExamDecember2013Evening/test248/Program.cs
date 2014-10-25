using System;
using System.Numerics;
class ThreeSixNine
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        BigInteger R = 0;
        BigInteger answerR = 0;

        if (B == 2)
        {
            R = A % C;
        }

        if (B == 4)
        {
           R = A + C;
        }

        if (B == 8)
        {
            R = (BigInteger)A * C;
        }

        if (R % 4 == 0)
        {
            answerR = R / 4;
            Console.WriteLine(answerR);
        }

        if (R % 4 != 0)
        {
            answerR = R % 4;
            Console.WriteLine(answerR);
        }

        Console.WriteLine(R);
    }
}