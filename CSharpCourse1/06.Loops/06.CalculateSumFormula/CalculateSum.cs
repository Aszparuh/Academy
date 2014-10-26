using System;
    /* Write a program that, for a given two integer
    numbers N and X, calculates the sum
    S = 1 + 1!/X + 2!/X^2 + … + N!/X^N  */

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());
        decimal factorial = 1M;
        decimal power = 1M;
        decimal sum = 1M;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum += factorial / power;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}

