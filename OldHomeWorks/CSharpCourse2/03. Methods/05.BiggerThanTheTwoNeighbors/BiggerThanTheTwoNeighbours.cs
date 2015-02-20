using System;

/*Write a method that checks if the element at given
position in given array of integers is bigger than its
two neighbors (when such exist).*/

public class BiggerThanTheTwoNeighbours
{
    public static bool NumberIsBiggerThanNeighbours(int[] array, int position)
    {
        if (position == 0 || position == array.Length - 1)
        {
            return false;
        }
        else if (array[position] < array[position - 1] || array[position] < array[position + 1])
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static void Main()
    {
        int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 3, 12, 4, 15, 7, 13 };
        int inputPosition = 10;
        bool isItBigger = NumberIsBiggerThanNeighbours(inputArray,inputPosition);
        if (isItBigger)
        {
            Console.WriteLine("The number on position {0} is bigger than its two neighbours", inputPosition);
        }
        else
        {
            Console.WriteLine("The number on positon {0} is smaller than one or both of its neighbours", inputPosition);
        }
    }
}