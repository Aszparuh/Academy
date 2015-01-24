using System;

/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

class ChoseVariable
{
    static void Main()
    {
        Console.Write("Enter 1 for int, 2 for double and 3 for string: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter value for int: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your value plus 1: {0}", number + 1);
        }
        if (choice == 2)
        {
            Console.Write("Enter value for double: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Your value plus 1: {0}", number + 1);
        }
        if (choice == 3)
        {
            Console.WriteLine("Enter your string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Your string plus * at the end: {0}", str + "*");
        }
    }
}