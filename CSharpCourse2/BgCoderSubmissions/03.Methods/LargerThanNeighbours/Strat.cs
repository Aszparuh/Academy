namespace LargerThanNeighbours
{
    using System;
    using System.Linq;

    class Strat
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var array = input.Split(new char[] { ' ' }).Select(n => int.Parse(n)).ToArray();
            int result = CountLargerThanNeighbours(array);
            Console.WriteLine(result);
        }

        static int CountLargerThanNeighbours(int[] array)
        {
            int counter = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
