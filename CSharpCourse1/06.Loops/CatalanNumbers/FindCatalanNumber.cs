using System;
using System.Numerics;

/*In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
 2N! / (N! * (1+ N)!)
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).*/

class FindCatalanNumber
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        int N = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialDoubleN = 1;
        BigInteger factorialNPlusOne = 1;

        for (int i = N; i > 0; i--)
        {
            factorialN *= i;
        }
        Console.WriteLine("N! = {0}", factorialN);

        for (int i = N * 2; i > 0; i--)
        {
            factorialDoubleN *= i;
        }
        Console.WriteLine("2N! = {0}", factorialDoubleN);
        for (int i = N + 1; i > 0; i--)
        {
            factorialNPlusOne *= i;
        }
        Console.WriteLine("(N + 1)! = {0}", factorialNPlusOne);
        BigInteger result = factorialDoubleN / (factorialN * factorialNPlusOne);
        Console.WriteLine(@"{0} Catalan Number ""2N! / (N! * (1+ N)!)"" = {1}",N , result);
    }
}