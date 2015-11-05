namespace CountOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            var array = new double[]{3, 4, 4, -2.5, 3, 3, 4, 3, -2.5};
            var result = new Dictionary<double, int>();

            foreach (var number in array)
            {
                if (result.ContainsKey(number))
                {
                    result[number] += 1;
                }
                else
                {
                    result[number] = 1;
                }
            }

            var items = from pair in result
                        orderby pair.Value ascending
                        select pair;

            foreach (var item in items)
            {
                Console.WriteLine("{0} => {1} times", item.Key, item.Value);
            }
        }
    }
}