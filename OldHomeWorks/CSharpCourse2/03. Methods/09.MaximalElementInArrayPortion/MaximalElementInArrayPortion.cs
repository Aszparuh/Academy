using System;

/*Write a method that return the maximal element in
a portion of array of integers starting at given index.
Using it write another method that sorts an array in
ascending / descending order.*/

class MaximalElementInArrayPortion
{
    static int MaximalElement(int[] array, int startIndex)
    {
        int maxElementPosition = startIndex;
        for (int i = startIndex + 1; i < array.Length; i++)
        {
            if (array[i] > array[maxElementPosition])
            {
                maxElementPosition = i;
            }
        }
        return maxElementPosition;
    }

    static int[] SortAscending(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        for (int i = array.Length - 1; i >= 0; i--)
        {
            sortedArray[i] = array[MaximalElement(array, 0)];
            array[MaximalElement(array, 0)] = int.MinValue;
        }
        return sortedArray;
    }

    static int[] SortDescending(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            sortedArray[i] = array[MaximalElement(array, 0)];
            array[MaximalElement(array, 0)] = int.MinValue;
        }
        return sortedArray;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] input = { 1, 22, 54, 2, 5, 76, 2, 178, 3, 4, 7, 8, 9, 23, 6, 3, 89, 3, 4, 67, 23 };
        int[] inputCloned =(int[])input.Clone();
        int startIndex = 8;
        int positionMaxElement = MaximalElement(input, startIndex);
        Console.WriteLine(" The element on position {0} has the maximal value strating from position {1}", positionMaxElement, startIndex);
        Console.WriteLine("The maximal value is {0}", input[positionMaxElement]);
        Console.WriteLine();
        Console.WriteLine("The array sorted by the same method ascending: ");
        PrintArray(SortAscending(input));
        Console.WriteLine();
        Console.WriteLine("The array sorted by the same method descending: ");
        PrintArray(SortDescending(inputCloned));
        Console.WriteLine();
    }
}