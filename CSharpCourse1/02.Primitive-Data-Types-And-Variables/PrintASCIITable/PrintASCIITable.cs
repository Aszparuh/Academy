using System;

/*Find online more information about ASCII (American Standard Code for Information Interchange) 
 and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

Note: You may need to use for-loops (learn in Internet how).*/

class PrintASCIITable
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            char letter = (char)i;
            Console.WriteLine("Character number {0} in ASCII table is {1}", i, letter);
        }
    }
}