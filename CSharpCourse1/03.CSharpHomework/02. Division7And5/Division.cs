using System;
class Division
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());

        if((number % 5 == 0 ) && (number % 7 == 0))
        {
            Console.WriteLine("The number can be divided by 7 and 5 without remainder");
        }
        else
        {
            Console.WriteLine("The number can not be divided by both 5 and 7 without reminder");
        }
        if (number % 5 == 0)
        {
            Console.WriteLine("The number can be divided only by 5 without reminder");
        }
        if (number % 7 == 0)
        {
            Console.WriteLine("The number can be divided only by 7 without reminder");
        }
       
        
    }
}

