using System;
using System.Numerics;

/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/

class Divide
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        if (n < k)
        {
            Console.WriteLine("N should be greater than K.");
        }
        else
        {
            do
            {
                factorialN *= n;
                n--;
            } while (n > k);

            Console.WriteLine("N!/K! = {0}", factorialN);
        }
    }
}