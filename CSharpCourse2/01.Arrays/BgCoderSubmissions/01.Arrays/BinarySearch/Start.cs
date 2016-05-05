namespace BinarySearch
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = GetInput(n);
            int elementToFind = int.Parse(Console.ReadLine());
            int result = BinarySearch(array, elementToFind);
            Console.WriteLine(result);
        }

        static int BinarySearch(int[] array, int elementToFind)
        {
            Array.Sort(array);
            int start = 0;
            int end = array.Length - 1;
            int center = (start + end) / 2;
            int positionOfEl = 0;
            bool elementNotFound = true;

            while (start <= end)
            {
                if (elementToFind > array[center])
                {
                    start = center + 1;
                    center = (start + end) / 2;
                }
                if (elementToFind < array[center])
                {
                    end = center - 1;
                    center = (start + end) / 2;
                }
                if (elementToFind == array[center])
                {
                    positionOfEl = center;
                    elementNotFound = false;
                    break;
                }
            }

            if (elementNotFound)
            {
                return -1;
            }
            else
            {
                return center;
            }
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
    }
}
