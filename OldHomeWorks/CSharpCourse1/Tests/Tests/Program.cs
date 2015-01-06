using System;

class DevidingFactoriels
{
    static void Main()
    {
        //Write a program that calculates N!/K! for given N and K (1<K<N).

        Console.Write("Insert N (where N>K): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Insert K(where K<N): ");
        int k = int.Parse(Console.ReadLine());
        int product = 1;
        if (k < n)
        {
            for (int i = n; i > k; i--)
            {
                product *= i;
            }
            Console.WriteLine("N!/K! = {0}", product);
        }
        else
        {
            Console.WriteLine("You have enter invalid valuabels! N should be bigged than K!");
        }

    }
}