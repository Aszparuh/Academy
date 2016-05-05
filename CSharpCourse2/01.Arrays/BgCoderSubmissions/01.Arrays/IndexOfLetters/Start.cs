namespace IndexOfLetters
{
    using System;

    class Start
    {
        static void Main()
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string word = Console.ReadLine();
            char[] wordArray = word.ToLower().ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (char.ToLower(wordArray[i]) == alphabet[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
