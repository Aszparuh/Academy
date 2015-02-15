namespace PermutationsOfSet
{
    using System;

    /*Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
        Example:

        N	result
        3	
        {1, 2, 3} 
        {1, 3, 2} 
        {2, 1, 3} 
        {2, 3, 1} 
        {3, 1, 2} 
        {3, 2, 1}*/
        
    class Permutations
    {
        static void Print<T>(T[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

        static void GeneratePermutations<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
            {
                Print(arr);
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

        static void Main()
        {
            int[] arr = { 1, 2, 3 };
            GeneratePermutations(arr, 0);
        }
    }
}