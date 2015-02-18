namespace MaximalSum
{
    using System;

    /*Write a program that reads a rectangular matrix of size N x M and finds in it the 
     * square 3 x 3 that has maximal sum of its elements.*/

    class FindMaxSum
    {
        static void Main()
        {
            //Console.Write("Enter N: ");
            //int N = int.Parse(Console.ReadLine());
            //Console.Write("Enter M: ");
            //int M = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[N, M];
            //for (int row = 0; row < N; row++)
            //{
            //    string currentRow = Console.ReadLine();
            //    string[] numbersAsStrings = currentRow.Split(' ');
            //    for (int col = 0; col < numbersAsStrings.Length; col++)
            //    {
            //        if (col < M)
            //        {
            //            matrix[row, col] = int.Parse(numbersAsStrings[col]);
            //        }
            //    }
            //}
            int[,] matrix = 
        {   {  0,  6, 12,  7,  6},
            { -5,  9,  6,  4,  1},
            { -8,  15, -8,  4,  9},
            {  9,  5,  11,  4,  3}     };

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

            //print the elements
            Console.WriteLine("The maximal sum in 3x3");
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {
                    if (maximalSum == matrix[row, column]
                        + matrix[row, column + 1]
                        + matrix[row, column + 2]
                        + matrix[row + 1, column]
                        + matrix[row + 1, column + 1]
                        + matrix[row + 1, column + 2]
                        + matrix[row + 2, column]
                        + matrix[row + 2, column + 1]
                        + matrix[row + 2, column + 2])
                    {
                        Console.WriteLine(matrix[row, column] + " " + matrix[row, column + 1] + " " + matrix[row, column + 2]);
                        Console.WriteLine(+matrix[row + 1, column] + " " + matrix[row + 1, column + 1] + " " + matrix[row + 1, column + 2]);
                        Console.WriteLine(+matrix[row + 2, column] + " " + matrix[row + 2, column + 1] + " " + matrix[row + 2, column + 2]);
                    }
                }
            }
        }
    }
}