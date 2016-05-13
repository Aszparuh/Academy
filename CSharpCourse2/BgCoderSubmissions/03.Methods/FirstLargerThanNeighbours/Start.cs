namespace FirstLargerThanNeighbours
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var array = input.Split(new char[] { ' ' }).Select(n => int.Parse(n)).ToArray();
            int result = FirstLargerThanNeighbours(array);
            Console.WriteLine(result);
        }

        static int FirstLargerThanNeighbours(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
