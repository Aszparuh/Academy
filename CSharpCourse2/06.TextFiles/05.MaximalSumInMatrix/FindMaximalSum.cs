using System;
using System.IO;

/*Write a program that reads a text file containing a
square matrix of numbers and finds in the matrix an
area of size 2 x 2 with a maximal sum of its
elements. The first line in the input file contains the
size of matrix N. Each of the next N lines contain N
numbers separated by space. The output should be a
single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4  17
3 7 1 2
4 3 3 2*/

class FindMaximalSum
{
    static int[,] GetMatrixFromTextFile(string matrixPath)
    {
        StreamReader reader = new StreamReader(matrixPath);
        using (reader)
        {
            int N = int.Parse(reader.ReadLine());
            int[,] matrix = new int[N, N];
            for (int row = 0; row < N; row++)
            {
                string currentRow = reader.ReadLine();
                string[] numbersAsStrings = currentRow.Split(' ');
                for (int col = 0; col < numbersAsStrings.Length; col++)
                {
                    matrix[row, col] = int.Parse(numbersAsStrings[col]);
                }
            }

            return matrix;
        }
    }

    static int FindMaxSum(int[,] matrix)
    {
        int maximalSum = int.MinValue;
        int tempSum = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)- 1; col++)
            {
                tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (tempSum > maximalSum)
                {
                    maximalSum = tempSum;
                }
            }
        }
        return maximalSum;
    }

    static void WriteResultToFile(int result, string filePath)
    {
        StreamWriter writer = new StreamWriter(filePath);
        using (writer)
        {
            writer.WriteLine(result);
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

    static void Main()
    {
        string matrixPath = @"../../TextFiles/matrix.txt";
        string resultPath = @"../../TextFiles/result.txt";
        int[,] matrix = GetMatrixFromTextFile(matrixPath);
        Console.WriteLine("The matrix in the text file is: ");
        PrintMatrix(matrix);
        WriteResultToFile((FindMaxSum(matrix)), resultPath);
        Console.WriteLine("The maximal sum in area 2x2 is written to result.txt");
    }
}