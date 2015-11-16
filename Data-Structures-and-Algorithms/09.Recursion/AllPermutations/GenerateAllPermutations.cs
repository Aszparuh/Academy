namespace AllPermutations
{
    using System;

    class GenerateAllPermutations
    {
        static void Main()
        {
            int n = 3;
            var array = GenerateArray(n);
            GeneratePermutations(array, 0);
        }

        static void GeneratePermutations(int[] arr, int k)
        {
            if (k >= arr.Length)
            {
                PrintArray(arr);
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static int[] GenerateArray(int n)
        {
            var result = new int[n];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = i + 1;
            }

            return result;
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ,", array));
            Console.WriteLine();
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}