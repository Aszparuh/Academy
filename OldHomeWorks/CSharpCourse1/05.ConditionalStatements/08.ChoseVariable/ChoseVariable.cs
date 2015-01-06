using System;

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
            Console.WriteLine("Your value plus 1: {0}",number + 1);
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

