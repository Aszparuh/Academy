using System;
using System.Collections.Generic;

namespace Divisors
{
    public class Startup
    {
        static List<int> list = new List<int>();

        public static void Main()
        {
            int numberOfDigits = int.Parse(Console.ReadLine());
            var digits = new int[numberOfDigits];

            for (int i = 0; i < numberOfDigits; i++)
            {
                var digit = int.Parse(Console.ReadLine());
                digits[i] = digit;
            }

            PermuteRep(digits, 0, digits.Length);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
           
        }

        static int ConvertArrayToNumber(int[] arr)
        {
            int num;
            int.TryParse(string.Join("", arr), out num);
            
            return num;
        }

        static void PermuteRep(int[] arr, int start, int n)
        {
            list.Add(ConvertArrayToNumber(arr));

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

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
