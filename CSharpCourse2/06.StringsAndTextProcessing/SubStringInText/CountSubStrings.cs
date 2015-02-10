namespace SubStringInText
{
    using System;

    /*Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).*/

    class CountSubStrings
    {
        static int Count(string anyString, string pattern)
        {
            int position = 0;
            int count = 0;
            
            while ((position = anyString.IndexOf(pattern, position)) != -1)
            {
                position += pattern.Length;
                count++;
            }

            return count;
        }

        static void Main()
        {
            Console.Write("Enter substring to look for: ");
            string searchFor = Console.ReadLine();
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            int count = Count(input, searchFor);

            if (count == 0)
            {
                Console.WriteLine("The text does not contain the string you are looking for.");
            }
            else
            {
                Console.WriteLine(" \"{0}\" was foung {1} times in the text.", searchFor, count);
            }
        }
    }
}