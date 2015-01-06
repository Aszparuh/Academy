using System;

/*You are given an array of strings. Write a method
that sorts the array by the length of its elements
(the number of characters composing them).*/

class SortByTheNumberOfCharacters
{
    static void Main()
    {
        string[] inputArray = { "asdasdaf", "wrgsaf", "er", "t", "yoyoyd", "sdfdlkndfbnd" };
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = i + 1; j < inputArray.Length; j++)
            {
                if (inputArray[i].Length > inputArray[j].Length)
                {
                    string temp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write(inputArray[i] + " ");
        }
        Console.WriteLine();
    }
}

