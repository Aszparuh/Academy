using System;


class NightmareOnCodeStreet
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int numberOfMembers = 0;
        
        while (true)
        {
            int temp = number % 10;
            number /= 10;
            sum += temp;
            numberOfMembers++;
        }

        Console.WriteLine(numberOfMembers + " " + sum);

    }
}

