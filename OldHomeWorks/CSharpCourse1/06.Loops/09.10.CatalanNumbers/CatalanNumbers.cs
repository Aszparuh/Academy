using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialDoubleN = 1;
        BigInteger factorialNPlusOne = 1;

        for (BigInteger i = N; i > 0; i--)
        {
            factorialN *= i;
        }
        Console.WriteLine(factorialN);

        for (BigInteger i = N * 2; i > 0; i--)
        {
            factorialDoubleN *= i;
        }
        Console.WriteLine(factorialDoubleN);
        for (BigInteger i = N + 1; i > 0; i--)
        {
            factorialNPlusOne *= i;
        }
        Console.WriteLine(factorialNPlusOne);
        BigInteger result = factorialDoubleN / factorialN * factorialNPlusOne;
        Console.WriteLine(result);
    }
}

