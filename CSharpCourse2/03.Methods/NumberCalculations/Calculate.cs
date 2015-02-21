namespace NumberCalculations
{
    using System;

    /*14. Integer calculations

     Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
     Use variable number of arguments.
     
      Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
      Use generic method (read in Internet about generic methods in C#).
     */

    class Calculate
    {
        static T FindMax<T>(params T[] array)
        {
            Array.Sort(array);
            T max = array[array.Length - 1];
            return max;
        }

        static T FindMin<T>(params T[] array)
        {
            Array.Sort(array);
            T min = array[0];
            return min;
        }

        static T FindProduct<T>(params T[] array)
        {
            dynamic product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            return product;
        }

        static float FindAverage<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return (float)sum / (float)array.Length;
        }

        static void Main()
        {
            Console.WriteLine("The maximal element is {0}", FindMax(1, 2, 3, 4));
            Console.WriteLine("The minimal element is {0}", FindMin(1, 2, 3, 4));
            Console.WriteLine("The product is {0}", FindProduct(1, 2, 3, 4));
            Console.WriteLine("The average is {0}", FindAverage(1, 2, 3, 4));
        }
    }
}