namespace SequenceNMatrix
{
    using System;

    /*We are given a matrix of strings of size N x M. Sequences in the matrix we 
     * define as sets of several neighbour elements located on the same line, column or diagonal.
     * Write a program that finds the longest sequence of equal strings in the matrix.*/

    class FindLongest
    {
        static void Main()
        {
            string[,] matrix = 
        {
            {"s", "qq", "s"},
            {"pp", "pp", "s"},
            {"pp", "qq", "s"},
        };
            int numberOfElements = 1;
            string elementValue = string.Empty;
            int maximalElement = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    //check columns
                    for (int colCheck = col; colCheck < matrix.GetLength(1) - 1; colCheck++)
                    {
                        if (matrix[row, colCheck] == matrix[row, colCheck + 1])
                        {
                            numberOfElements++;
                            if (numberOfElements > maximalElement)
                            {
                                maximalElement = numberOfElements;
                                elementValue = matrix[row, colCheck];
                            }
                        }
                    }

                    numberOfElements = 1;
                    //check rows
                    for (int rowCheck = row; rowCheck < matrix.GetLength(0) - 1; rowCheck++)
                    {
                        if (matrix[rowCheck, col] == matrix[rowCheck + 1, col])
                        {
                            numberOfElements++;
                            if (numberOfElements > maximalElement)
                            {
                                maximalElement = numberOfElements;
                                elementValue = matrix[rowCheck, col];
                            }
                        }
                    }

                    numberOfElements = 1;
                    //check diagonal 
                    for (int rowCheck = row, colCheck = col; rowCheck < matrix.GetLength(0) - 1 && colCheck < matrix.GetLength(1) - 1; rowCheck++, colCheck++)
                    {
                        if (matrix[rowCheck, colCheck] == matrix[rowCheck + 1, colCheck + 1])
                        {
                            numberOfElements++;
                            if (numberOfElements > maximalElement)
                            {
                                maximalElement = numberOfElements;
                                elementValue = matrix[rowCheck, colCheck];
                            }
                        }
                    }
                    numberOfElements = 1;
                }
            }

            //printing the maximal sequence of equal elements
            for (int i = 0; i <= maximalElement; i++)
            {
                if (i < maximalElement)
                {
                    Console.Write(elementValue + ", ");
                }
                else
                {
                    Console.Write(elementValue);
                }
            }

            Console.WriteLine();
        }
    }
}