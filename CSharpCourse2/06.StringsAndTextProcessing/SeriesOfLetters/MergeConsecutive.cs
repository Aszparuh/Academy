namespace SeriesOfLetters
{
    using System;

    /*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
     Example:
     
     input	output
     aaaaabbbbbcdddeeeedssaa	abcdedsa*/

    class MergeConsecutive
    {
        static void Main()
        {
            string text = "ttttttaaaaabbbbcdddeedssaaaaabbbbbceeeedssaaggggg";
            Console.WriteLine("Input string is: {0}", text);
            char lastUsedChar = text[0];
            Console.WriteLine();
            Console.Write("Result is: ");
            Console.Write(lastUsedChar);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != lastUsedChar)
                {
                    lastUsedChar = text[i];
                    Console.Write(lastUsedChar);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}