using System;

/*Write a program that finds all prime numbers in the
range [1...10 000 000]. Use the sieve of Eratosthenes
algorithm (find it in Wikipedia).*/

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] array = new bool[10000000];
        int counter = 0;
        int maximal = (int)Math.Sqrt(array.Length);
        
        for (int i = 2; i < maximal; i++)
        {
            if (array[i] == false)
            {
                for (int j = i * i; j < array.Length; j += i)
                {
                    array[j] = true;
                }
            }
        }
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == false)
            {
                Console.WriteLine(i);
                counter++;
            }
        }
        Console.WriteLine("There are {0} prime numbers ", counter);
    }
}
