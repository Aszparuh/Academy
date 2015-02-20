using System;

/*Write a method that asks the user for his name and
prints "Hello, <name>!" for example, "Hello,
Peter!". Write a program to test this method.*/

class PrintHelloName
{
    static void AskAndPrintName() 
    {
        Console.Write("Type your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main()
    {
        AskAndPrintName();
    }
}