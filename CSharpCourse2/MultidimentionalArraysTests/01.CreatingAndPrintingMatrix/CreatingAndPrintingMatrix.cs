using System;

/*1. Write a program that fills and prints a matrix of size
(n, n) as shown below: (examples for n = 4)
1  5  9  13
2  6  10 14
3  7  11 15
4  8  12 16

7  11 14 16
4  8  12 15
2  5  9  13
1  3  6  10
 
1  8  9  16
2  7  10 15
3  6  11 14
4  5  12 13
 
1  12 11 10
2  13 16  9
3  14 15  8
4  5  6  7
 */

class CreatingAndPrintingMatrix
{
    static void Main()
    {
        //Console.WriteLine("Enter N: ");
        //int n = int.Parse(Console.ReadLine());
        int n = 8;
        int rows = n;
        int columns = n;
        int[,] matrix = new int [n,n];
        //first task
        for (int row = 0; row < rows; row++)
        {
            int currentElement = row + 1;
            for (int column = 0; column < columns; column++)
            {
                matrix[row, column] = currentElement;
                currentElement += n;
            }
        }
        //printing matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        //second task
        int element = 1;
        for (int column = 0; column < n; column++)
        {
            if (column % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, column] = element;
                    element++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, column] = element;
                    element++;
                }
            }
        }
        Console.WriteLine();
        //printing matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        //third task

    }
}

