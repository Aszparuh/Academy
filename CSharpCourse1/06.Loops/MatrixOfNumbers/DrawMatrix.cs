using System;

/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and 
 prints a matrix like in the examples below. Use two nested loops.
 n = 2               n = 3         n = 4
   12                 123          1234
   23                 234          2345
                      345          3456
                                   4567
 */

class DrawMatrix
{
    static void Main()
    {
        //input
        Console.Write("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        //fill matrix
        int columns = n; // no need for two more variables just to make it readable
        int rows = n;
        int[,] matrix = new int[rows, columns];
        
        for (int col = 0; col < columns; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                matrix[row, col] = row + col + 1;
            }
        }

        //print matrix
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}