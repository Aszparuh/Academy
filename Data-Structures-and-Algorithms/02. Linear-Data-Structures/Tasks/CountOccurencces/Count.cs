namespace CountOccurencces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Count
    {
        static void Main()
        {
            var inputList = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 }; ///2 → 2 times 3 → 4 times 4 → 3 times
            var countDictionary = new Dictionary<int, int>();

            foreach (var number in inputList)
            {
                if (countDictionary.ContainsKey(number))
                {
                    countDictionary[number] += 1;
                }
                else
                {
                    countDictionary.Add(number, 1);
                }
            }

            var allNumbers = countDictionary.Keys.ToList();
            allNumbers.Sort();

            foreach (var number in allNumbers)
            {
                Console.WriteLine("{0} → {1} times", number, countDictionary[number]);
            }
        }
    }
}