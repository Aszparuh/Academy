namespace Exceptions_Homework.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Utils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("array", "Array cannot be null.");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new IndexOutOfRangeException("Start index must be in range [0, arr.Length).");
            }

            if (count < 0)
            {
                throw new ArgumentException("Length of subsequence cannot be negative.", "substring length");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("substring length", "The length of the subsequence is too big.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (str == null)
            {
                throw new ArgumentNullException("input string", "String cannot be null.");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("substring length", "Count cannot be greater than string length.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}