using System;

/*Write a program that generates and prints to the
console 10 random values in the range [100, 200].*/

class TenRandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Ten random numbers:");
        Random randomGenerator = new Random();
        for (int i = 0; i < 10; i++)
        {
            if (i == 9)
            {
                Console.Write(randomGenerator.Next(100, 200));
            }
            else
            {
                Console.Write(randomGenerator.Next(100, 200) + ", ");
            }
        }
        Console.WriteLine();
    }
}