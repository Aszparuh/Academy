namespace LargestAreaInMatrix
{
    using System;

    class Start
    {
        //right row , col + 1
        //down  row + 1, col
        //left row, col - 1
        //up row - 1, col 
        static int[] rowDirections = new int[] { 0, 1, 0, -1 };
        static int[] colDirections = new int[] { 1, 0, -1, 0 };
        static int currentAreaCount = 0;
        static int maxAreaCount = 0;

        static void Main()
        {
            string dimensions = Console.ReadLine();
            var splitedDimesions = dimensions.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(splitedDimesions[0]);
            int m = int.Parse(splitedDimesions[1]);
            var matrix = FillMatrix(n, m);
            FindLargerstArea(matrix);
            Console.WriteLine(maxAreaCount);
        }

        static int[,] FillMatrix(int n, int m)
        {

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string values = Console.ReadLine();
                var splitedValues = values.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(splitedValues[j]);
                }
            }

            return matrix;
        }

        //DFS
        static void FindLargerstArea(int[,] matrix)
        {
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentAreaCount = 0;
                    DepthFirstSearch(row, col, visited, matrix, matrix[row, col]);
                    if (currentAreaCount > maxAreaCount)
                    {
                        maxAreaCount = currentAreaCount;
                    }
                }
            }
        }

        static void DepthFirstSearch(int row, int col, bool[,] visited, int[,] matrix, int elementValue)
        {
            if (!(InRange(row, matrix.GetLength(0) - 1) && InRange(col, matrix.GetLength(1) - 1)))
            {
                return;
            }

            if (visited[row, col])
            {
                return;
            }

            if (elementValue != matrix[row, col])
            {
                return;
            }

            currentAreaCount++;
            visited[row, col] = true;

            for (int i = 0; i < 4; i++)
            {
                DepthFirstSearch(row + rowDirections[i], col + colDirections[i], visited, matrix, matrix[row, col]);
            }

        }

        private static bool InRange(int value, int max)
        {
            return 0 <= value && value <= max;
        }
    }
}