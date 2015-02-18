namespace SayHello
{
    using System;

    /*Write a method that asks the user for his name and prints “Hello, <name>”
      Write a program to test this method.
       Example:
       
       input	output
       Peter	Hello, Peter!*/

    class PrintHelloName
    {
        static void AskAndPrintName()
        {
            Console.Write("Type your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            AskAndPrintName();
        }
    }
}