namespace MaximalSum
{
    using System;

    class Start
    {
        static void Main()
        {
            string nAndM = Console.ReadLine();
            var separator = new char[] { ' ' };
            var splited = nAndM.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(splited[0]);
            int m = int.Parse(splited[1]);

            var matrix = FillMatrix(n, m, separator);
            var maxSum = GetMaxMatrix(matrix);
            //var maxSum = FindMaxSum(matrix);
            Console.WriteLine(maxSum);
        }

        static int[,] FillMatrix(int n, int m, char[] separator)
        {
            
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string values = Console.ReadLine();
                var splitedValues = values.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(splitedValues[j]);
                }
            }

            return matrix;
        }

        static int FindMaxSum(int[,] matrix)
        {
            int sum = 0;
            int maximalSum = int.MinValue;

            //Find maximal sequence sum
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {

                    //sum = matrix[row, column]
                    //    + matrix[row, column + 1]
                    //    + matrix[row, column + 2]
                    //    + matrix[row + 1, column]
                    //    + matrix[row + 1, column + 1]
                    //    + matrix[row + 1, column + 2]
                    //    + matrix[row + 2, column]
                    //    + matrix[row + 2, column + 1]
                    //    + matrix[row + 2, column + 2];

                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = column; j < column + 3; j++)
                        {
                            sum += matrix[i, j];
                            if (sum > maximalSum)
                            {
                                maximalSum = sum;
                            }
                        }
                    }                   
                }
            }

            return maximalSum;
        }

        public static int GetMaxMatrix(int[,] original)
        {
            int maxArea = int.MinValue;
            int rowCount = original.GetLength(0);
            int columnCount = original.GetLength(1);
            int[,] matrix = PrecomputeMatrix(original);
            for (int row1 = 0; row1 < rowCount; row1++)
            {
                for (int row2 = row1; row2 < rowCount; row2++)
                {
                    for (int col1 = 0; col1 < columnCount; col1++)
                    {
                        for (int col2 = col1; col2 < columnCount; col2++)
                        {
                            maxArea = Math.Max(maxArea, ComputeSum(matrix, row1, row2, col1, col2));
                        }
                    }
                }
            }
            return maxArea;
        }

        private static int[,] PrecomputeMatrix(int[,] matrix)
        {
            var sumMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    { // first cell
                        sumMatrix[i, j] = matrix[i, j];
                    }
                    else if (j == 0)
                    { // cell in first column
                        sumMatrix[i, j] = sumMatrix[i - 1, j] + matrix[i, j];
                    }
                    else if (i == 0)
                    { // cell in first row
                        sumMatrix[i, j] = sumMatrix[i, j - 1] + matrix[i, j];
                    }
                    else
                    {
                        sumMatrix[i, j] = sumMatrix[i - 1, j] +
                        sumMatrix[i, j - 1] - sumMatrix[i - 1, j - 1] + matrix[i, j];
                    }
                }
            }
            return sumMatrix;
        }

        private static int ComputeSum(int[,] sumMatrix, int i1, int i2, int j1, int j2)
        {
            if (i1 == 0 && j1 == 0)
            { // starts at row 0, column 0
                return sumMatrix[i2, j2];
            }
            else if (i1 == 0)
            { // start at row 0
                return sumMatrix[i2, j2] - sumMatrix[i2, j1 - 1];
            }
            else if (j1 == 0)
            { // start at column 0
                return sumMatrix[i2, j2] - sumMatrix[i1 - 1, j2];
            }
            else
            {
                return sumMatrix[i2, j2] - sumMatrix[i2, j1 - 1]
                - sumMatrix[i1 - 1, j2] + sumMatrix[i1 - 1, j1 - 1];
            }
        }
    }
}
