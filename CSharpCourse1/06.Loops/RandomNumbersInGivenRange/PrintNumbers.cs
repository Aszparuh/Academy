using System;

/*Write a program that enters 3 integers n, min and max (min != max) 
and prints n random numbers in the range [min...max].*/

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter value for max: ");
        int max = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(randomGenerator.Next(min, max + 1) + " ");
        }

        Console.WriteLine();
    }
}