using System;

/*Write an if-statement that takes two double variables a and b and exchanges their values 
 * if the first one is greater than the second one. As a result print the values a and b, separated by a space.*/

class Exchange
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("a = {0} is greater than the second b = {1}", a, b);
            Console.WriteLine("The values will be exchanged ");
            double assist = a;
            a = b;
            b = assist;
            Console.WriteLine("Now a = {0} and b = {1}", a, b);
        }
        else
        {
            Console.WriteLine("The numbers are equal or the second is greater than the first a = {0} , b = {1}.",a, b);
        }
    }
}