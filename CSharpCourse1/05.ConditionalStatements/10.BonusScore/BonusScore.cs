using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 1: Console.WriteLine("Your score: {0}", digit * 10);
                break;
            case 2: Console.WriteLine("Your score: {0}", digit * 10);
                break;
            case 3: Console.WriteLine("Your score: {0}", digit * 10);
                break;
            case 4: Console.WriteLine("Your score: {0}", digit * 100);
                break;
            case 5: Console.WriteLine("Your score: {0}", digit * 100);
                break;
            case 6: Console.WriteLine("Your score: {0}", digit * 100);
                break;
            case 7: Console.WriteLine("Your score: {0}", digit * 1000);
                break;
            case 8: Console.WriteLine("Your score: {0}", digit * 1000);
                break;
            case 9: Console.WriteLine("Your score: {0}", digit * 1000);
                break;
            default: Console.WriteLine("Error");
                break;
        }
    }
}

