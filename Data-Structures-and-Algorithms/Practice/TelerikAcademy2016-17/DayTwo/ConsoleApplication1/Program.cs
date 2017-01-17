using System;
using System.Linq;

namespace ConsoleApplication1
{
    public class Program
    {
        const int n = 5;
        const int k = 3;
        static string[] objects = new string[n]
        {
        "banana", "apple", "orange", "strawberry", "raspberry"
        };
        static int[] arr = new int[k];

        static void Main()
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numberOfDevelopers = line[0];
            var m = line[1];

            var arr = new int[numberOfDevelopers];

            for (int i = 0; i < m; i++)
            {

            }
        }

        static void GenerateCombinationsNoRepetitions(int index, int start)
        {
            if (index >= k)
            {
                PrintVariations();
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    arr[index] = i;
                    GenerateCombinationsNoRepetitions(index + 1, i + 1);
                }
            }
        }

    }
}
