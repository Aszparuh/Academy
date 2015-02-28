namespace Palindromes
{
    using System;
    using System.Collections.Generic;

    /*Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/

    class ExtractPalindromes
    {
        static bool isPalindrome(string word)
        {
            if (word.Length == 1)
            {
                return false;
            }

            int length = word.Length;
            int loopEnd = length / 2;
            length--;
            for (int i = 0; i < loopEnd; i++)
            {
                if (word[i] != word[length - i])
                {
                    return false;
                }
            }

            return true;        
        }
        static void Main()
        {
            //string text = Console.ReadLine();
            string text = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe";
            char[] punctoation = new char[]{ ',', '.', '!', '?', ' ' };
            string[] words = text.Split(punctoation, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                if (isPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            if (palindromes.Count == 0)
            {
                Console.WriteLine("There aren't palindromes in the text.");
            }
            else
            {
                Console.WriteLine("All the palindromes are:");
                for (int i = 0; i < palindromes.Count; i++)
                {
                    Console.WriteLine(palindromes[i]);
                }
            }
        }
    }
}