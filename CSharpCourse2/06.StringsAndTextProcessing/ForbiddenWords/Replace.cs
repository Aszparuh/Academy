namespace ForbiddenWords
{
    using System;
    using System.Text;

    /*We are given a string containing a list of forbidden words and a
    text containing some of these words. Write a program that replaces 
    the forbidden words with asterisks.
    Example text: Microsoft announced its next generation PHP compiler today. 
    It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
    Forbidden words: PHP, CLR, Microsoft
    The expected result: ********* announced its next generation *** compiler today. 
    It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/

    class Replace
    {
        static string ReplaceWords(string[] arr, string text)
        {
            StringBuilder sb = new StringBuilder(text);

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Replace(arr[i], new string('*', arr[i].Length));
            }

            return sb.ToString();
        }

        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter the forbidden words: ");
            string words = Console.ReadLine();
            string[] forbiddenWords = words.Split(new char[] { ' ', ',', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine();
            Console.Write(ReplaceWords(forbiddenWords, text));
            Console.WriteLine();
        }
    }
}