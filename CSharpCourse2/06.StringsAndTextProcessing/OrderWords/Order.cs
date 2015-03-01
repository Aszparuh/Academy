namespace OrderWords
{
    using System;

    /*Write a program that reads a list of words, separated by spaces 
     * and prints the list in an alphabetical order.*/

    class Order
    {
        static void Main()
        {
            string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order";
            Console.WriteLine("Input string: ");
            Console.WriteLine(text);
            string[] words = text.Split(' ');
            Array.Sort(words);
            Console.WriteLine();
            Console.WriteLine("Sorted words:");
            foreach (string word in words)
            {
                Console.WriteLine("{0} ", word);
            }
            Console.WriteLine();
        }
    }
}