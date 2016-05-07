namespace SelectionSort
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = GetInput(n);
            SelectionSort(array);
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

        static void SelectionSort(int[] inputArray)
        {
            int min;
            int temp;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[min])
                    {
                        min = j;
                    }
                }

                temp = inputArray[i];
                inputArray[i] = inputArray[min];
                inputArray[min] = temp;
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
