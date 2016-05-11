namespace RemoveElementsFromArray
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = GetInput(n);
            int maxLength = FindLongestNonConsequtiveSequenceLenght(array);
            //Console.WriteLine(maxLength);
            Console.WriteLine(array.Length - maxLength);
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

        static int FindLongestNonConsequtiveSequenceLenght(int[] array)
        {
            int[] helperArray = new int[array.Length];

            for (int i = 0; i < helperArray.Length; i++)
            {
                helperArray[i] = 1;
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] >= array[j])
                    {
                        if (helperArray[j] + 1 > helperArray[i])
                        {
                            helperArray[i] = helperArray[j] + 1;
                        }
                    }
                }
            }

            int max = FindMax(helperArray);
            return max;
        }

        static int FindMax(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
