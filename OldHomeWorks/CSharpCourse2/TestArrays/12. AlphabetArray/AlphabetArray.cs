using System;

/*Write a program that creates an array containing all
letters from the alphabet (A-Z). Read a word from
the console and print the index of each of its letters
in the array.*/

class AlphabetArray
{
    static void Main()
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        char[] wordArray = word.ToLower().ToCharArray();

        Console.WriteLine("The letters of your word are on the positions: ");
        for (int i = 0; i < wordArray.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (wordArray[i] == alphabet[j])
                {
                    if (i < wordArray.Length - 1)
                    {
                        Console.Write(j + ", ");
                    }
                    else if (i == wordArray.Length - 1)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}

