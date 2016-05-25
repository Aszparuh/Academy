namespace MagicWords
{
    // 100/100 BgCoder http://bgcoder.com/Contests/Practice/Index/94#1
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

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

            //Console.WriteLine(string.Join(",", words));
            Print(words);
        }

        static void ReorderWord(List<string> words, int wordPosition)
        {
            string word = words[wordPosition];
            words[wordPosition] = null;
            int destinationPostion = word.Length % (words.Count + 1);
            words.Insert(destinationPostion, word);
            words.Remove(null);
        }

        static void Print(List<string> words)
        {
            StringBuilder sb = new StringBuilder();
            int biggestLength = GetBiggestLength(words);
            int elementToPrint = 0;

            while (elementToPrint <= biggestLength)
            {
                foreach (var word in words)
                {
                    if (word.Length > elementToPrint)
                    {
                        sb.Append(word[elementToPrint]);
                    }
                }

                elementToPrint++;
            }

            Console.WriteLine(sb.ToString());
        }

        static int GetBiggestLength(List<string> words)
        {
            return words.OrderByDescending(w => w.Length).FirstOrDefault().Length;
        }
    }
}
