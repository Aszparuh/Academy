using System;

/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/

class FindSum
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
        Console.WriteLine("Sum = {0:F5}", sum);
    }
}