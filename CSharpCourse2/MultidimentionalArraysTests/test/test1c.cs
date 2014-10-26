using System;

class test
{
    static void Main()
    {

        int n = 4;
        int currentRow = n - 1;
        int currentCol = 0;
        int[,] matrix = new int[n, n];
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
        
        
        
        
        //printing
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

