namespace MaximalSequence
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = GetInput(n);
            Console.WriteLine(FindLongestSequence(array));
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

        static int FindLongestSequence(int[] array)
        {
            int counter = 1;
            int maxSequence = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    if (maxSequence < counter)
                    {
                        maxSequence = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            return maxSequence;
        }
    }
}
