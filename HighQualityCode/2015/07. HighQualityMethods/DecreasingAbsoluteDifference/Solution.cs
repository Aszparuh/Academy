namespace DecreasingAbsoluteDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Solution
    {
        internal static void Main()
        {
            int inputLineLenght = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLineLenght; i++)
            {
                List<int> result = new List<int>();
                string input = Console.ReadLine();
                var numbers = input.Split(' ').Select(int.Parse).ToList();

                for (int j = 1; j < numbers.Count; j++)
                {
                    int abs = 0;
                    if (numbers[j] > numbers[j - 1])
                    {
                        abs = numbers[j] - numbers[j - 1];
                    }
                    else if (numbers[j - 1] > numbers[j])
                    {
                        abs = numbers[j - 1] - numbers[j];
                    }
                    else
                    {
                        abs = 0;
                    }

                    result.Add(abs);
                }

                CheckIsIncreasing(result);
                result.Clear();
            }
        }

        private static void CheckIsIncreasing(List<int> result)
        {
            bool isIncreasing = true;
            for (int i = 0; i < result.Count - 1; i++)
            {
                if ((result[i] - result[i + 1]) != 1 && (result[i] - result[i + 1]) != 0)
                {
                    Console.WriteLine("False");
                    isIncreasing = false;
                    break;
                }

                if (result[i] < result[i + 1])
                {
                    Console.WriteLine("False");
                    isIncreasing = false;
                }
            }

            if (isIncreasing)
            {
                Console.WriteLine("True");
            }
        }
    }
}