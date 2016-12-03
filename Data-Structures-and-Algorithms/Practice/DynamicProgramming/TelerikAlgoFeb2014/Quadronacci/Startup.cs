using System;
using System.Collections.Generic;

namespace Quadronacci
{
    public class Startup
    {
        public static void Main()
        {
            var list = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int lastNumber = r * c;

            for (int i = 4; i < lastNumber; i++)
            {
                list.Add(list[i - 1] + list[i - 2] + list[i - 3] + list[i - 4]);
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
