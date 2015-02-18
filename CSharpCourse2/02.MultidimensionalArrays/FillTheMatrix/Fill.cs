namespace FillTheMatrix
{
    using System;

    /*Write a program that fills and prints a matrix of size (n, n) as shown below:
     Example for n=4:
     * A
     * 1	5	9	13
       2	6	10	14
       3	7	11	15
       4	8	12	16
     * B
       1	8	9	16
       2	7	10	15
       3	6	11	14
       4	5	12	13
     * C
       7	11	14	16
       4	8	12	15
       2	5	9	13
       1	3	6	10
     */

    class Fill
    {
        static void Main()
        {
            //Console.WriteLine("Enter N: ");
            //int n = int.Parse(Console.ReadLine());
            int n = 4;
            int rows = n;
            int columns = n;
            int[,] matrix = new int[n, n];
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
            Console.WriteLine();
            int currentRow = n - 1;
            int currentCol = 0;
            for (int currentValue = 1; currentValue <= n * n; currentValue++)
            {
                matrix[currentRow, currentCol] = currentValue;
                currentRow++;
                currentCol++;
                if (currentRow == n || currentCol == n)
                {
                    currentRow--;
                    if (currentCol == n)
                    {
                        currentRow--;
                        currentCol--;
                    }
                    while (currentRow - 1 >= 0 && currentCol - 1 >= 0)
                    {
                        currentRow--;
                        currentCol--;
                    }
                }
            }

            //printing
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
}