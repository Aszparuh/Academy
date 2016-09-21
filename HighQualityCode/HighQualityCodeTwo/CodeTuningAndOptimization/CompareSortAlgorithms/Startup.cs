namespace CompareSortAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using SortingLib;

    public class Startup
    {
        private const int NumberOfTimesToTest = 10;
        private static readonly IComparer<int> Comparer = new SortIntComparer();
        private static readonly IComparer<double> DoubleComparer = new SortDoubleComparer();
        private static readonly IComparer<string> StringComparer = new SortStringComparer();
        private static readonly int[] ReversedInt = new int[] { 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        private static readonly double[] ReversedDouble = new double[] { 15.5, 14.5, 13.5, 12.5, 11.5, 10.5, 9.5, 8.5, 7.5, 6.5, 5.5, 4.5, 3.5, 2.5, 1.5 };
        private static readonly string[] ReversedString = new string[] { "P", "O", "N", "M", "L", "K", "J", "I", "H", "G", "F", "E", "D", "C", "B", "A" };
        private static readonly int[] SortedInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        private static readonly double[] SortedDouble = new double[] { 1.5, 2.5, 3.5, 4.5, 5.5, 6.5, 7.5, 8.5, 9.5, 10.5, 11.5, 12.5, 13.5, 14.5, 15.5 };
        private static readonly string[] SortedString = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };
        private static readonly int[] RandomInt = new int[] { 4, 5, 10, 6, 3, 11, 8, 13, 14, 9, 15, 2, 12, 7, 1 };
        private static readonly double[] RandomDouble = new double[] { 3.5, 5.5, 10.5, 11.5, 6.5, 4.5, 9.5, 12.5, 13.5, 7.5, 8.5, 1.5, 14.5, 15.5, 2.5, };
        private static readonly string[] RandomString = new string[] { "C", "F", "K", "L", "G", "D", "E", "B", "N", "A", "O", "H", "M", "P", "I", "J" };
        private static readonly Stopwatch Sw = new Stopwatch();

        public static void Main()
        {
            // Sorting library is from https://github.com/akshaykamath/Generic-Sort-Library-Dot-Net
            Console.WriteLine("Insertion sort----------------------------");
            Console.WriteLine();

            Console.WriteLine("Random Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])RandomInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Random Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])RandomDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Random String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])RandomString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])SortedInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])SortedDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])SortedString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])ReversedInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])ReversedDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])ReversedString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.InsertionSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Selection Sort----------------------------");
            Console.WriteLine();

            Console.WriteLine("Random Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])RandomInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Random Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])RandomDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Random String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])RandomString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])SortedInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])SortedDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])SortedString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])ReversedInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])ReversedDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])ReversedString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.SelectionSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Buble sort----------------------------");
            Console.WriteLine();

            Console.WriteLine("Random Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])RandomInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Random Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])RandomDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Random String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])RandomString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])SortedInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])SortedDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])SortedString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])ReversedInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])ReversedDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])ReversedString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.BubbleSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Heap sort----------------------------");
            Console.WriteLine();

            Console.WriteLine("Random Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])RandomInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Random Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])RandomDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Random String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])RandomString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])SortedInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])SortedDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Sorted String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])SortedString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed Int32");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                int[] sortingArray = (int[])ReversedInt.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, Comparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed Double");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                double[] sortingArray = (double[])ReversedDouble.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, DoubleComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
            Console.WriteLine("Reversed String");
            for (int i = 0; i < NumberOfTimesToTest; i++)
            {
                string[] sortingArray = (string[])ReversedString.Clone();
                Sw.Start();
                sortingArray.Sort(SortStrategy.HeapSort, StringComparer);
                Sw.Stop();
                Console.WriteLine(Sw.Elapsed);
                Sw.Reset();
            }

            Console.WriteLine();
        }
    }
}
