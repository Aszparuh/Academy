namespace NNestedLoops
{
    using System;

    class GenerateLoops
    {
        static void Main()
        {
            int n = 4;
            var allLoops = new int[n];

            GenerateLoops(0, allLoops);
        }

        private static void GenerateLoops(int countOfLoops, int[] variationArray)
        {
            if (countOfLoops == variationArray.Length)
            {
                PrintArray(variationArray);
                return;
            }

            for (int i = 1; i <= variationArray.Length; i++)
            {
                variationArray[countOfLoops] = i;
                GenerateLoops(countOfLoops + 1, variationArray);
            }
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ,", array));
            Console.WriteLine();
        }
    }
}