using System;
using System.Numerics;

        //Write a program that calculates N!*K! / (K-N)! for
        //given N and K (1<N<K).

    class FactorialsFormula
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
            int differenceKN = k - n;

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

                Console.WriteLine("N!*K! / (K-N)! = {0}", factorialN * factorialK / factorialDifference);

            }
        }
    }

