namespace CombinationsOfSet
{
    using System;

    /*Write a program that reads two numbers N and K and generates all the 
     * combinations of K distinct elements from the set [1..N].
     Example:

            N	K	result
            5	2	{1, 2} 
                    {1, 3} 
                    {1, 4} 
                    {1, 5} 
                    {2, 3} 
                    {2, 4} 
                    {2, 5} 
                    {3, 4} 
                    {3, 5} 
                    {4, 5}
     */

    class Combinations
    {
        const int n = 5;
        const int k = 2;
        static int[] objects = new int[n]; 
        static int[] arr = new int[k];

        static void FillArray(int length)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = i + 1;
            }
        }

        static void Main()
        {
            FillArray(n);
            GenerateCombinationsNoRepetitions(0, 0);
        }

        static void GenerateCombinationsNoRepetitions(int index, int start)
        {
            if (index >= k)
            {
                PrintVariations();
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    arr[index] = i;
                    GenerateCombinationsNoRepetitions(index + 1, i + 1);
                }
            }
        }

        static void PrintVariations()
        {
            Console.Write("(" + String.Join(", ", arr) + ") --> ( ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(objects[arr[i]] + " ");
            }
            Console.WriteLine(")");
        }
    }
}