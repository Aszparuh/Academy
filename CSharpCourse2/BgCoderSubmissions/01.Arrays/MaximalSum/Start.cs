namespace MaximalSum
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = GetInput(n);
            Console.WriteLine(FindMaxSum(array));
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

        static int FindMaxSum(int[] array)
        {
            int currentSum = array[0];
            int maxSum = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = array[i];
                }
                else
                {
                    currentSum += array[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            return maxSum;
        }
    }
}
