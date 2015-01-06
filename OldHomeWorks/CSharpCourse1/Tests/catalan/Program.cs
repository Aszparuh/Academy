using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        string strNum;
        int n;
        int numerator;
        int i;

        do
        {
            Console.Write("Please set a value of N to calculate it's relevant\n" +
            "member of The Catalan sequence: ");
        }
        while ((!int.TryParse(strNum = Console.ReadLine(), out n)) || n <= 0);

        BigInteger nFactorial = 1;
        for (i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }

        BigInteger numeratorFact = 1;
        numerator = 2 * n;

        for (i = n + 2; i <= numerator; i++)
        {
            numeratorFact *= i;
        }
        decimal catalanNum = (decimal)numeratorFact / (decimal)nFactorial;

        Console.WriteLine("The {0}-th member of The Catalan sequence is: {1}", n, catalanNum);
    }
}