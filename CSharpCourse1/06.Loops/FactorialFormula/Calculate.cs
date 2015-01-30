using System;
using System.Numerics;

/*In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 * (also known as the number of combinations) is calculated by the following formula: formula For example, 
 * there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
 * Try to use only two loops.*/

class Calculate
{
    static void Main()
    {
        Console.Write("Enter N - (1<N<K): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K - (1<N<K): ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialDifference = 1;
        int differenceKN = n - k;

        if (k < n && n < 1)
        {
            Console.WriteLine("K must be bigger than N and N must be bigger than 1.");
        }
        else
        {
            do
            {
                factorialN *= n;
                n--;
            } while (n > 0);
            do
            {
                factorialK *= k;
                k--;
            } while (k > 0);
            do
            {
                factorialDifference *= differenceKN;
                differenceKN--;
            } while (differenceKN > 0);

            Console.WriteLine("N! / (K! * (N-K)!) = {0}", factorialN / (factorialK * factorialDifference));
        }
    }
}