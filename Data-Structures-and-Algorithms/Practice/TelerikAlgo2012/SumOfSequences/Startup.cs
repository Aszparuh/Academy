using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfSequences
{
    public class Startup
    {
        private static List<int> list = new List<int>();

        public static void Main()
        {
            var numberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTestCases; i++)
            {
                var lenghtOfInputSequenceAndElements = Console.ReadLine().Split(' ');
                var lengthOfInput = int.Parse(lenghtOfInputSequenceAndElements[0]);
                var elementsToSubtract = int.Parse(lenghtOfInputSequenceAndElements[1]);
                var inputSequence = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var k = inputSequence.Length - elementsToSubtract;
                GenerateCombinationsNoRepetitions(inputSequence, new int[k], 0, 0, lengthOfInput, k);

                //foreach (var item in list)
                //{
                //    Console.WriteLine(string.Format($"* {item}"));
                //}

                Console.WriteLine(list.Sum());
                list = new List<int>();
            }
        }

        static void GenerateCombinationsNoRepetitions(int[] sequence, int[] arr, int index, int start, int n, int k)
        {
            if (index >= k)
            {
                foreach (var item in arr)
                {
                    list.Add(sequence[item]);
                }

            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    arr[index] = i;
                    GenerateCombinationsNoRepetitions(sequence, arr, index + 1, i + 1, n, k);
                }
            }
        }
    }
}
