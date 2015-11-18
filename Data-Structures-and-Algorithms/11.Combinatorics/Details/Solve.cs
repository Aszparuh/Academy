namespace Details
{
    using System;
    using System.Collections.Generic;

    public class Solve
    {
        private static int numberOfFactors;
        private static int result;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            numberOfFactors = TurnToNumber(array);
            PermuteRep(array, 0, array.Length);

            Console.WriteLine(result);
        }

        static void PermuteRep(int[] arr, int start, int n)
        {
            Print(arr);
            int currentNumberOfFactors = FindFactors(arr);
            if (currentNumberOfFactors < numberOfFactors)
            {
                numberOfFactors = currentNumberOfFactors;
                result = TurnToNumber(arr);
            }

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                }

                // Undo all modifications done by the
                // previous recursive calls and swaps
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = firstElement;
            }
        }

        private static int FindFactors(int[] arr)
        {
            int number = TurnToNumber(arr);
            int numberOfFactors = 0;
            int squareOfNumber = (int)Math.Sqrt(number);

            for (int i = 1; i < squareOfNumber; i++)
            {
                if (number % i == 0)
                {
                    ++numberOfFactors;
                }
            }

            return numberOfFactors;
        }

        private static int TurnToNumber(int[] arr)
        {
            int finalScore = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                finalScore += arr[i] * (int)(Math.Pow(10, arr.Length - i - 1));
            }

            return finalScore;
        }

        static void Print<T>(T[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}