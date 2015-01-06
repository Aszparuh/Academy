using System;

/*Write a program that finds the sequence of maximal
sum in given array. Example:
{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}   {2, -1, 6, 4}
Can you do it with only one loop (with single scan
through the elements of the array)?*/

class MaximalSubsetSum
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter the element on position {0}",i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int maxSum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = array[i];
                tempStartIndex = i;
            }
            else
            {
                currentSum += array[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tempStartIndex;
                endIndex = i;
            }
        }
        Console.WriteLine("The maximal sum is: " + maxSum);
        Console.Write("The sequence is: {");
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i < endIndex)
            {
                Console.Write(array[i] + ", ");
            }
            else
            {
                Console.Write(array[i]);
            }
        }
        Console.WriteLine("}");
    }
}

