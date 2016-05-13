namespace SortingArray
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            string length = Console.ReadLine();
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(n => int.Parse(n)).ToArray();
            Console.WriteLine(string.Join(" ", SortAscending(array)));
        }

        static int MaximalElement(int[] array, int startIndex)
        {
            int maxElementPosition = startIndex;
            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i] > array[maxElementPosition])
                {
                    maxElementPosition = i;
                }
            }

            return maxElementPosition;
        }

        static int[] SortAscending(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[i] = array[MaximalElement(array, 0)];
                array[MaximalElement(array, 0)] = int.MinValue;
            }

            return sortedArray;
        }
    }
}
