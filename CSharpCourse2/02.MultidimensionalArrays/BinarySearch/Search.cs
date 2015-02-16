namespace BinarySearch
{
    using System;

    /*Write a program, that reads from the console an array of N integers and an integer K, 
     * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

    class Search
    {
        static void Main()
        {
            Console.Write("Enter the number of elements in the array: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            int[] inputArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter element on position {0}: ", i);
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(inputArray);
            Console.WriteLine("Sorted array");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }

            Console.WriteLine();
            int result = Array.BinarySearch(inputArray, K);

            if (result > 0)
            {
                Console.WriteLine("There is an element in the array equal to K");
                Console.WriteLine("on position " + result);
            }
            else if (result < 0)
            {
                int index = ~result;
                Console.WriteLine("There is no element equal to K in the array");
                Console.WriteLine("The greatest element smaller than K is {0}", inputArray[index - 1]);
                Console.WriteLine("It is on position {0}", index - 1);
            }
        }
    }
}