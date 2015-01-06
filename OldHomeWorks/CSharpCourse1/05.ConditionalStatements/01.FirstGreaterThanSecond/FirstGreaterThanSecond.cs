using System;

class FirstGreaterThanSecond
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            Console.WriteLine("The first number {0} is greater than the second {1}", firstNum, secondNum);
            Console.WriteLine("The values will be exchanged ");           
            int assist = firstNum;
            firstNum = secondNum;
            secondNum = assist;
            Console.WriteLine("Now the first number is {0} and second is {1}", firstNum, secondNum);
        }
        else
        {
            Console.WriteLine("The numbers are equal or the second is greater than the first. ");
        }

    }
}
