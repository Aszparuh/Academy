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
    static void Main()
    {
        int[] input = { 1, 22, 54, 2, 5, 76, 2, 178, 3, 4, 7, 8, 9, 23, 6, 3, 89, 3, 4, 67, 23, };
        int startIndex = 8;
        int positionMaxElement = MaximalElement(input, startIndex);
        Console.WriteLine(" The element on position {0} has the maximal value strating from position {1}", positionMaxElement, startIndex);
        Console.WriteLine("The maximal value is {0}", input[positionMaxElement]);
    }
}

