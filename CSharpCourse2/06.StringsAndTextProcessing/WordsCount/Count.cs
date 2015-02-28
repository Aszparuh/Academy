namespace WordsCount
{
    using System;
    using System.Collections.Generic;

    /*Write a program that reads a string from the console and lists all different words in 
     the string along with information how many times each word is found.*/

    class Count
    {
        static void Main()
        {
            //string text = Console.ReadLine();
            string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
            var punctoation = new char[]{ ',', '.', '!', '?', ' ', '-' };
            string[] words = text.Split(punctoation, StringSplitOptions.RemoveEmptyEntries);
            var wordsDict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (wordsDict.ContainsKey(words[i]))
                {
                    wordsDict[words[i]]++;
                }
                else
                {
                    wordsDict.Add(words[i], 1);
                }
            }

            foreach (KeyValuePair<string, int> element in wordsDict)
            {
                Console.WriteLine("{0,-12} ==> {1}", element.Key, element.Value);
            }
        }
    }
}