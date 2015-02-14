namespace QuickSort
{
    using System;

    /*Write a program that sorts an array of integers using the Quick sort algorithm.*/

    class Sort
    {
        static void Main()
        {
            int[] array = new int[] { 1, 6, 9, 13, 67, 89, 3, 15, 43, 25, 31, 9, 54 };

            Console.WriteLine("Unsorted Array");
            Console.WriteLine(string.Join(", ", array));

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted Array");
            Console.WriteLine(string.Join(", ", array));
        }

        private static void QuickSort(int[] array, int startIndex, int endIndex)
        {
            int i = startIndex;
            int j = endIndex;
            int pivot = array[array.Length / 2];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while(array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            //Recursion
            if (startIndex < j)
            {
                QuickSort(array, startIndex, j);
            }

            if (i > endIndex)
            {
                QuickSort(array, i, endIndex);
            }
        }
    }
}