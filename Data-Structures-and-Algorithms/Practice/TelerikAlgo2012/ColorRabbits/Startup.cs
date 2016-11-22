using System;
using System.Collections.Generic;

namespace ColorRabbits
{
    public class Startup
    {
        public static void Main()
        {
            var dictionary = new Dictionary<int, int>();
            int numberOfAskedRabbits = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfAskedRabbits; i++)
            {
                var input = int.Parse(Console.ReadLine()) + 1;

                if (dictionary.ContainsKey(input))
                {
                    dictionary[input] += 1;
                }
                else
                {
                    dictionary.Add(input, 1);
                }
            }

            int sum = 0;
            foreach (KeyValuePair<int, int> entry in dictionary)
            {
                if (entry.Value == 1)
                {
                    sum += entry.Key;
                }
                else
                {
                    var number = Math.Ceiling((double)entry.Value / (double)entry.Key);
                    sum += (int)number * entry.Key;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
