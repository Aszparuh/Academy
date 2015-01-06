/* Write a program that reads a number N and
calculates the sum of the first N members of the
sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,
Each member of the Fibonacci sequence (except the
first two) is a sum of the previous two members.*/
using System;

class FibonacciSum
{
    static void Main()
    {
        Console.WriteLine("How many members from the Fibonacci sequence do you want to sum?");
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("N must be greater than 0");
        }
        else
        {
            int startNum = 0;
            int secondNum = 1;
            int sum = startNum + secondNum;
            int nextNum;

            for (int i = 3; i <= n; i++)
            {
                nextNum = startNum + secondNum;
                sum += nextNum;
                startNum = secondNum;
                secondNum = nextNum;
            }
            Console.WriteLine(sum);
        }       
    }
}

