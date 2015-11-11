﻿namespace AllCombinationsWithDuplicates
{
    using System;

    class Startup
    {
        static void Main()
        {
            int n = 3;
            int k = 2;
            int[] allCombinations = new int[k];
            GenerateVariations(0, 0, n, k, allCombinations);
        }

        private static void GenerateVariations(int index, int start, int n, int k, int[] allCombinations)
        {
            if (index >= k)
            {
                PrintArray(allCombinations);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    allCombinations[index] = i;
                    GenerateVariations(index + 1, i + 1, n, k, allCombinations);
                }
            }
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ,", array));
            Console.WriteLine();
        }
    }
}