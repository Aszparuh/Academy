namespace MagicWords
{
    using System;
    using System.Collections.Generic;

    class EntryPoint
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                ReorderWord(words, i);
            }

            Console.WriteLine(string.Join(",", words));
        }

        static void ReorderWord(List<string> words, int wordPosition)
        {
            string word = words[wordPosition];
            int destinationPostion = word.Length % words.Count;
            words.Insert(destinationPostion, word);
            words.Remove(word);
        }
    }
}
