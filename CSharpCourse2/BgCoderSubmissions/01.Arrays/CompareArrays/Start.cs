namespace CompareArrays
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var firstArray = GetInput(n);
            var secondArray = GetInput(n);
            var areEqual = Enumerable.SequenceEqual(firstArray, secondArray);

            Console.WriteLine( areEqual ? "Equal" : "Not equal");
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
