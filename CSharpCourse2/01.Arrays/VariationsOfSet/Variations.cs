namespace VariationsOfSet
{
    using System;

    /*Write a program that reads two numbers N and K and generates all 
     * the variations of K elements from the set [1..N].
       Example:
       
       N	K	result
       3	2	{1, 1} 
                {1, 2} 
                {1, 3} 
                {2, 1} 
                {2, 2} 
                {2, 3} 
                {3, 1} 
                {3, 2} 
                {3, 3}*/

    class Variations
    {
        const int n = 3;
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
            GenerateVariationsWithRepetitions(0);
        }

        static void GenerateVariationsWithRepetitions(int index)
        {
            if (index >= k)
            {
                PrintVariations();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    arr[index] = i;
                    GenerateVariationsWithRepetitions(index + 1);
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