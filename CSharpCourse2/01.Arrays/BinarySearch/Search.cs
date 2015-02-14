namespace BinarySearch
{
    using System;

    /*Write a program that finds the index of given element 
     * in a sorted array of integers by using the Binary search algorithm.*/

    class Search
    {
        static void Main()
        {
            //Console.Write("Enter the length of the array: ");
            //int length = int.Parse(Console.ReadLine());
            //int[] array = new int[length];

            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write("Enter element on position {0}: ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Enter elemet to search for: ");
            //int elementToFind = int.Parse(Console.ReadLine());

            //test
            int[] array = new int[] { 5, 7, 9, 1, 13, 73, 10 };
            int elementToFind = 9;
            //test

            Array.Sort(array);
            int start = 0;
            int end = array.Length - 1;
            int center = (start + end) / 2;
            int positionOfEl = 0;
            bool elementNotFound = true;

            while (start <= end)
            {
                if (elementToFind > array[center])
                {
                    start = center + 1;
                    center = (start + end) / 2;
                }
                if (elementToFind < array[center])
                {
                    end = center - 1;
                    center = (start + end) / 2;
                }
                if (elementToFind == array[center])
                {
                    positionOfEl = center;
                    elementNotFound = false;
                    break;
                }
            }

            if (elementNotFound)
            {
                Console.WriteLine("{0} was not found in the array", elementToFind);
            }
            else
            {
                Console.WriteLine("{0} is on position {1} in the array.", elementToFind, center);
            }
        }
    }
}