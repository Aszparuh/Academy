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
            var maxSum = FindMaxSum(matrix);
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
            int sum;
            int maximalSum = int.MinValue;

            //Find maximal sequence sum
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {
                    sum = matrix[row, column]
                        + matrix[row, column + 1]
                        + matrix[row, column + 2]
                        + matrix[row + 1, column]
                        + matrix[row + 1, column + 1]
                        + matrix[row + 1, column + 2]
                        + matrix[row + 2, column]
                        + matrix[row + 2, column + 1]
                        + matrix[row + 2, column + 2];
                    if (sum > maximalSum)
                    {
                        maximalSum = sum;
                    }
                }
            }

            return maximalSum;
        }
    }
}
