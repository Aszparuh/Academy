using System;
using System.Numerics;

/*Write methods to calculate minimum, maximum,
average, sum and product of given set of integer
numbers. Use variable number of arguments.*/

class CalculateMinMaxAvgProduct
{
    static int[] GetIntArray(params int[] array)
    {
        return array;
    }

    static decimal[] GetDecimalArray(params decimal[] array)
    {
        return array;
    }

    static int FindMax(int[] array)
    {
        Array.Sort(array);
        int max = array[array.Length - 1];
        return max;
    }

    static int FindMin(int[] array)
    {
        Array.Sort(array);
        int min = array[0];
        return min;
    }

    static BigInteger FindProduct(int[] array)
    {
        BigInteger product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }

    static decimal FindAverage(decimal[] array)
    {
        decimal sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        decimal average = sum / array.Length;
        return average;
    }

    static void Main()
    {
        Console.WriteLine("The maximal element is {0}",FindMax(GetIntArray(1, 2, 3, 4)));
        Console.WriteLine("The minimal element is {0}",FindMin(GetIntArray(1, 2, 3, 4)));
        Console.WriteLine("The product is {0}",FindProduct(GetIntArray(1, 2, 3, 4)));
        Console.WriteLine("The average is {0}",FindAverage(GetDecimalArray(1, 2, 3, 4)));

    }
}