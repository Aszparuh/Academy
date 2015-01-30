using System;

/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and 
 * prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.*/

class PrintMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int currentRow = 0;
        int currentCol = 0;
        string direction = "down";

        for (int i = 1; i <= N * N; i++)
        {
            matrix[currentRow, currentCol] = i;

            //fillig the matrix
            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
            else if (direction == "left")
            {
                currentCol--;
            }

            //changing direction
            if (direction == "down" && (currentRow >= N || matrix[currentRow, currentCol] != 0))
            {
                direction = "right";
                currentRow--;
                currentCol++;
            }
            else if (direction == "right" && (currentCol >= N || matrix[currentRow, currentCol] != 0))
            {
                direction = "up";
                currentRow--;
                currentCol--;
            }
            else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                direction = "left";
                currentRow++;
                currentCol--;
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                direction = "down";
                currentRow++;
                currentCol++;
            }
        }
        //print matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write("   " + matrix[row, col]);
                }
                else if (matrix[row, col] < 100)
                {
                    Console.Write("  " + matrix[row, col]);
                }
                else
                {
                    Console.Write(" " + matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }
}