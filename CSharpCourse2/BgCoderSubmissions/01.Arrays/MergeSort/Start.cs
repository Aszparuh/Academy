namespace MergeSort
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = GetInput(n);
            var sortedArray = MergeSort(array);
            PrintArray(sortedArray);
        }

        static int[] GetInput(int n)
        {
            int[] resultArr = new int[n];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = int.Parse(Console.ReadLine());
            }

            return resultArr;
        }

        private static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr;
            }

            int middle = arr.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    left[i] = arr[i];
                }
                else
                {
                    right[i - middle] = arr[i];
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return MergeSort(left, right);
        }

        private static int[] MergeSort(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i;
            int j;
            for (i = 0, j = 0; i < left.Length && j < right.Length;)
            {
                if (left[i] < right[j])
                {
                    result[i + j] = left[i];
                    i++;
                }
                else
                {
                    result[i + j] = right[j];
                    j++;
                }
            }

            for (; i < left.Length; i++)
            {
                result[i + j] = left[i];
            }

            for (; j < right.Length; j++)
            {
                result[i + j] = right[j];
            }

            return result;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
