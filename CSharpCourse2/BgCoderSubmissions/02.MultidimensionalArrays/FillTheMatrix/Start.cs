namespace FillTheMatrix
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char type = (char)Console.Read();

            //Console.WriteLine("TypeA");
            //Print(FillTypeA(n));
            //Console.WriteLine("TypeB");
            //Print(FillTypeB(n));
            //Console.WriteLine("TypeC");
            //Print(FillTypeC(n));

            switch (type)
            {
                case 'a':
                    Print(FillTypeA(n));
                    break;
                case 'b':
                    Print(FillTypeB(n));
                    break;
                case 'c':
                    Print(FillTypeC(n));
                    break;
                case 'd':
                    Print(FillTypeD(n));
                    break;
                default:
                    break;
            }
        }

        static int[,] FillTypeA(int n)
        {
            int[,] matrix = new int[n,n];
            int rows = n;
            int columns = n;

            for (int row = 0; row < rows; row++)
            {
                int currentElement = row + 1;
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = currentElement;
                    currentElement += n;
                }
            }

            return matrix;
        }

        static int[,] FillTypeB(int n)
        {
            int[,] matrix = new int[n, n];
            int element = 1;
            int rows = n;
            int columns = n;

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

            return matrix;
        }

        static int[,] FillTypeC(int n)
        {
            int[,] matrix = new int[n, n];
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

            return matrix;
        }

        static int[,] FillTypeD(int n)
        {
            int[,] matrix = new int[n, n];
            int currentRow = 0;
            int currentCol = 0;
            string direction = "down";

            for (int i = 1; i <= n * n; i++)
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
                if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0))
                {
                    direction = "right";
                    currentRow--;
                    currentCol++;
                }
                else if (direction == "right" && (currentCol >= n || matrix[currentRow, currentCol] != 0))
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

            return matrix;
        }

        static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        Console.Write("{0}", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }                  
                }

                Console.WriteLine();
            }
        }
    }
}
