namespace AppearanceCount
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(n => int.Parse(n)).ToArray();
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(GetAppearanceCount(array, x));
        }

        static int GetAppearanceCount(int[] array, int x)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
