namespace ExtractSentences
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Start
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            var sentences = ExtractSentences(text);
     
        }

        static List<string> ExtractSentences(string text)
        {
            List<string> sentences = new List<string>();
            int indexOfNextEnd = 0;
            int indexOfLastEnd = 0;

            while (indexOfNextEnd != -1)
            {
                indexOfNextEnd = text.IndexOf(".", indexOfLastEnd + 1);
                sentences.Add(text.Substring(indexOfLastEnd + 1, indexOfNextEnd - indexOfLastEnd + 1));
                indexOfLastEnd = indexOfNextEnd;
            }

            return sentences;
        }
    }
}