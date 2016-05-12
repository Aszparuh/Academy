namespace TargetPractice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        static char[,] matrix;

        public static void Main()
        {
            string input = Console.ReadLine();
            var splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(splitedInput[0]);
            int cols = int.Parse(splitedInput[1]);
            matrix = new char[rows, cols];

            string snake = Console.ReadLine();
            var shotParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int impactRow = int.Parse(shotParameters[0]);
            int impactCol = int.Parse(shotParameters[1]);
            int impactRadius = int.Parse(shotParameters[2]);
            FillMatrix(rows, cols, snake);
            Shoot(impactRow, impactCol, impactRadius);
            PrintMatrix();

            
        }

        static void FillMatrix(int rows, int cols, string snake)
        {
            bool isOnLeft = true;
            int indexOnSnake = 0;

            for (int row = rows - 1; row >= 0; row--)
            {
                
                if (isOnLeft)
                {
                    int col = cols - 1;
                    while (col >= 0)
                    {
                        matrix[row, col] = snake[indexOnSnake];
                        indexOnSnake++;
                        if (indexOnSnake > snake.Length - 1)
                        {
                            indexOnSnake = 0;
                        }

                        col--;
                        isOnLeft = false;
                    }
                }
                else
                {
                    int col = 0;
                    while (col < cols)
                    {
                        matrix[row, col] = snake[indexOnSnake];
                        indexOnSnake++;
                        if (indexOnSnake > snake.Length - 1)
                        {
                            indexOnSnake = 0;
                        }

                        col++;
                        isOnLeft = true;
                    }
                }              
            }
        }

        static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void Shoot(int impactRow, int impactCol, int Radius)
        {
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int x = row - impactRow;
                    int y = col - impactCol;

                    if ((x * x) + (y * y) <= Radius * Radius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }
    }
}
