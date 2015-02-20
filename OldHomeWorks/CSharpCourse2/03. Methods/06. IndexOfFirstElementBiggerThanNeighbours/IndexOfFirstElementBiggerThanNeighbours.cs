using System;

/*Write a method that returns the index of the first element in 
array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.*/

class IndexOfFirstElementBiggerThanNeighbours
{
    static int CheckNeighbours(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (BiggerThanTheTwoNeighbours.NumberIsBiggerThanNeighbours(inputArray, i))
            {
                return i;
            }
        }

        return -1;
    }
    static void Main()
    {
        int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 8, 15};
        int result = CheckNeighbours(inputArray);
        if (result != -1)
        {
            Console.WriteLine("The firs element bigger than its two neighbours is on position {0}", result);
        }
        else
        {
            Console.WriteLine("There is no element bigger than its two neighbours");
        }
    }
}