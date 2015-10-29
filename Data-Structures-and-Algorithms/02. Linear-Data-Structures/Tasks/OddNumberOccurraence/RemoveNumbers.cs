namespace OddNumberOccurraence
{
    using System;
    using System.Collections.Generic;

    class RemoveNumbers
    {
        static void Main()
        {
            var inputList = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 }; //{5, 3, 3, 5}
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

            foreach (var element in countDictionary)
            {
                if (element.Value % 2 != 0)
	            {
                    inputList.RemoveAll(e => e == element.Key);
	            }
            }

            Console.WriteLine(string.Join(" ,", inputList));
        }
    }
}