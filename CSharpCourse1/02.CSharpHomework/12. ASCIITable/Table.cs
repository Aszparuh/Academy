using System;
class Table
{
    static void Main()
    {
        for (int i = 0; i <= 127; i++)
        {
        char letter = (char)i;
        Console.WriteLine("Character number {0} in ASCII table is {1}", i, letter);
        }
    }
}

