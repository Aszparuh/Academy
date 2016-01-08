namespace GetOddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class GetOccurrences
    {
        public static void Main()
        {
            var array = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var count = new Dictionary<string, int>();

            foreach (var element in array)
            {
                if (count.ContainsKey(element))
                {
                    count[element] += 1;
                }
                else
                {
                    count[element] = 1;
                }
            }

            foreach (var element in count)
            {
                if (element.Value % 2 != 0)
                {
                    Console.WriteLine(element.Key);
                }
            }
        }
    }
}