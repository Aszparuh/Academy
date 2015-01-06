using System;

class SumMore
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int sum = n;
        int number = 0;
        int count = 1;

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter new number to be added: ");
            number = int.Parse(Console.ReadLine());
            sum = sum + number;
            count++;
            Console.WriteLine("The new sum is {0}", sum);
            
        }
        
    }
}

