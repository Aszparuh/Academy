namespace LettersCount
{
    using System;
    using System.Collections.Generic;

    /*Write a program that reads a string from the console and prints all different letters 
     in the string along with information how many times each letter is found.*/

    class Count
    {
        static void Main()
        {
            string input = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found";
            Console.WriteLine("Input string:");
            Console.WriteLine(input);
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    if (letters.ContainsKey(input[i]))
                    {
                        letters[input[i]]++;
                    }
                    else
                    {
                        letters.Add(input[i], 1);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Letter   Count");
            foreach (KeyValuePair<char, int> element in letters)
            {
                Console.WriteLine(" '{0}' -> {1}", element.Key, element.Value);
            }
        }
    }
}