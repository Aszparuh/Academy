namespace AllCombinationsWithDuplicates
{
    using System;

    class GenerateCombinationsDuplicates
    {
        static void Main()
        {
            int n = 4;
            int k = 2;
            int[] allCombinations = new int[k];
            GenerateVariations(0, 1, n, k, allCombinations);
        }

        private static void GenerateVariations(int index, int start, int n, int k, int[] allCombinations)
        {
            if (index >= k)
            {
                PrintArray(allCombinations);
            }
            else
            {
                for (int i = start; i < n + 1; i++)
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