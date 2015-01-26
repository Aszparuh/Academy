using System;

/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

class Program
{
    static void Main()
    {
        Console.Write("Enter how many numbers you wish to calculate: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int min = 0;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter next number: ");
            int nextNumber = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                min = nextNumber;
                max = nextNumber;
                sum = nextNumber;
            }
            else
            {
                if (nextNumber < min)
                {
                    min = nextNumber;
                }
                if (nextNumber > max)
                {
                    max = nextNumber;
                }

                sum += nextNumber;
            }
        }

        Console.WriteLine("The minimal is {0}", min);
        Console.WriteLine("The maximal is {0}", max);
        Console.WriteLine("The sum is {0}", sum);
        Console.WriteLine("The average is {0:F2}", (double)sum / n);
    }
}