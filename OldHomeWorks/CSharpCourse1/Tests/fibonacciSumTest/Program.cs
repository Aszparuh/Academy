using System;
using System.Numerics;
using System.Text;

class FibonacciMembers
{
    static void Main()
    {
        Console.Write("N = ");
        int inputN = int.Parse(Console.ReadLine());

        if (inputN > 0)
        {

            BigInteger firstNum = 0;
            BigInteger secondNum = 1;
            BigInteger nextNum;
            BigInteger sum;

            sum = firstNum + secondNum;
            for (int i = 2; i < inputN; i++)
            {
                nextNum = firstNum + secondNum;
                sum += nextNum;
                firstNum = secondNum;
                secondNum = nextNum;
            }

            Console.WriteLine("The sum of the first {0} members of the Fibonacci sequence is: {1} ", inputN, sum);
        }
        else
        {
            Console.WriteLine("Please enter a valid input value. It must be a positive number!");
            Main();
        }
    }
}