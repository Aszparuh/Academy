namespace ExtractSentences
{
    using System;
    using System.Text;

    /*Write a program that extracts from a given text all sentences containing given word.*/

    class Extract
    {
        static string ExtractSent(string text, string word)
        {
            string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            word = " " + word + " ";

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(word))
                {
                    sb.Append(sentences[i]);
                    sb.Append(".");
                }
            }

            return sb.ToString();
        }

        static void Main()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            Console.Write("Enter the word to look for: ");
            string word = Console.ReadLine();
            Console.WriteLine(ExtractSent(input, word));
        }
    }
}
