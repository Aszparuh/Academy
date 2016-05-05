namespace QuickSort
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = GetInput(n);
            Quicksort(array, 0, array.Length - 1);
            PrintArray(array);
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

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
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
