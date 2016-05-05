namespace MaximalKSum
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var array = GetInput(n);
            Array.Sort(array);
            Array.Reverse(array);
            long sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (i == k - 1)
                {
                    break;
                }
            }

            Console.WriteLine(sum);
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
