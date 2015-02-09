namespace ReverseString
{
    /*Write a program that reads a string, reverses it and prints the result at the console.*/

    using System;
 
    class Reverse
    {
        static string ReverseString(string someInput)
        {
            char[] stringChars = someInput.ToCharArray();
            Array.Reverse(stringChars);
            return new string(stringChars);
        }

        static void Main()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));     
        }
    }
}