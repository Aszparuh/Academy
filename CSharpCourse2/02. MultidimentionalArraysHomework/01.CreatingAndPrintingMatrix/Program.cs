using System;

/*Write a program that fills and prints a matrix of size
(n, n) as shown below: (examples for n = 4)*/
class Program
{
    static void Main()
    {
        int cols = 4;
        int rows = 4;
        int[,] matrix = new int[rows, cols];

        for (cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (rows = cols + 1; rows < matrix.GetLength(0); rows++)
            {
                matrix[rows, cols] = rows;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

