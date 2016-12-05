using System;
using System.Linq;

namespace Dodge
{
    public class Program
    {
        private static void PrintMatrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var enemies = Console.ReadLine().Split(';');

            var rows = int.Parse(input[0]);
            var columns = int.Parse(input[1]);
            var maximumNumbaerOfMoves = int.Parse(input[2]);
            var dodgeField = new int[rows, columns];

            foreach (var enemy in enemies)
            {
                var enemyCoordinates = enemy.Split(' ');
                var enemyRow = int.Parse(enemyCoordinates[0]);
                var enemyColumn = int.Parse(enemyCoordinates[1]);

                dodgeField[enemyRow, enemyColumn] = -1;
            }

            dodgeField[0, 0] = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (dodgeField[row, col] == -1)
                    {
                        continue;
                    }

                    if (row > 0 && dodgeField[row - 1, col] != -1)
                    {
                        dodgeField[row, col] += dodgeField[row - 1, col];
                    }

                    if (col > 0 && dodgeField[row, col - 1] != -1)
                    {
                        dodgeField[row, col] += dodgeField[row, col - 1];
                    }
                }
            }

            PrintMatrix(dodgeField);
            Console.WriteLine(dodgeField[rows - 1, columns - 1]);
        }
    }
}
