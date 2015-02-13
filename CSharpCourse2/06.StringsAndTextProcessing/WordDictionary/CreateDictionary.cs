namespace WordDictionary
{
    using System;
    using System.Collections.Generic;

    /*A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.
    Sample dictionary:

    input	     output
    .NET	    platform for applications from Microsoft
    CLR	        managed execution environment for .NET
    namespace	hierarchical organization of classes*/

    class CreateDictionary
    {
        static void Main()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add(".NET", "platform for applications from Microsoft");
            words.Add("CLR", "managed execution environment for .NET");
            words.Add("namespace", "hierarchical organization of classes");

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            foreach (var item in words)
            {
                if (word.ToUpper() == item.Key.ToUpper())
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
