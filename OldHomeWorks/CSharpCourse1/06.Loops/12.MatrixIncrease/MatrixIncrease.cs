using System;

class MatrixIncrease
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j <= N + i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

