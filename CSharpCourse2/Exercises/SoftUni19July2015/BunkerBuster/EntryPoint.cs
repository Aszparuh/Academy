namespace BunkerBuster
{
    //100/100 SoftUni Judge https://judge.softuni.bg/Contests/Practice/Index/92#0
    using System;
    using System.Linq;

    class EntryPoint
    {
        static void Main()
        {
            char[] separator = new char[] { ' ' };
            var dimenssions = Console.ReadLine().Split(separator).Select(n => int.Parse(n)).ToArray();
            int rows = dimenssions[0];
            int cols = dimenssions[1];
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            string bombLine = Console.ReadLine();
            while (bombLine != "cease fire!")
            {
                var bomb = bombLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int impactRow = int.Parse(bomb[0]);
                int impactCol = int.Parse(bomb[1]);
                int power = bomb[2].ToArray()[0];
                CalculateImpact(impactRow, impactCol, power, matrix);
                bombLine = Console.ReadLine();
            }

            //PrintMatrix(matrix);
            int numberOfDestroyedCells = GetNumberOfDestroyedCells(matrix);
            double percentage = Math.Round((double)numberOfDestroyedCells / (rows * cols) * 100, 1, MidpointRounding.AwayFromZero);

            Console.WriteLine("Destroyed bunkers: {0}", numberOfDestroyedCells);
            Console.WriteLine("Damage done: {0:0.0} %", percentage);
        }

        static void CalculateImpact(int row, int col, int power, int[,] matrix)
        {
            for (int i = row - 1; i <= row + 1; i++)
            {
                if (i < 0 || i > matrix.GetLength(0) - 1)
                {
                    continue;
                }
                else
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (j < 0 || j > matrix.GetLength(1) - 1)
                        {
                            continue;
                        }
                        else
                        {
                            if (i == row && j == col)
                            {
                                matrix[i, j] = matrix[i, j] - power;
                            }
                            else
                            {
                                matrix[i, j] = matrix[i, j] - (int)Math.Ceiling(power / 2f);
                            }
                        }
                    }
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static int GetNumberOfDestroyedCells(int[,] matrix)
        {
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
