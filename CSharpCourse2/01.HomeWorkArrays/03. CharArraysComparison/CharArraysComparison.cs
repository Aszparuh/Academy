using System;

/*Write a program that compares two char arrays
lexicographically (letter by letter)*/

class CharArraysComparison
{
    static void Main()
    {
        Console.WriteLine("Enter two words");
        Console.Write("The first word: ");
        string firstWord = Console.ReadLine();
        Console.Write("The second word: ");
        string seconWord = Console.ReadLine();

        char[] firstArray = firstWord.ToUpper().ToCharArray();
        char[] secondArray = seconWord.ToUpper().ToCharArray();
        int length = firstArray.Length;
        bool PrintFirstArray = true;

        if (firstArray.Length > secondArray.Length)
        {
            length = secondArray.Length;
        }

        for (int i = 0; i < length; i++)
        {
            if (secondArray[i] < firstArray[i])
            {
                PrintFirstArray = false;
            }
        }
        if (PrintFirstArray)
        {
            Console.WriteLine("{0} is lexicografically before {1}",firstWord ,seconWord);
        }
        else
        {
            Console.WriteLine("{0} is lexicografically before {1}", seconWord, firstWord);
        }
    }
}

