using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Enter two possitive integers");
        Console.Write("Enter a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        int b = int.Parse(Console.ReadLine());
        int aNum = a;
        int bNum = b;
        while (aNum != 0 && bNum != 0)
        {
            if (aNum > bNum)
            {
                aNum -= bNum;
            }
            else if (bNum > aNum)
            {
                bNum -= aNum;
            }
            else 
            {
                break;
            }
        }
        if (aNum == 0)
        {
            Console.WriteLine("The GCD of {0} and {1} is {2}", a, b, bNum );
        }
        else if (bNum == 0)
        {
            Console.WriteLine("The GCD of {0} and {1} is {2}", a, b, aNum );
        }
        else if (aNum == bNum)
        {
            Console.WriteLine("The GCD of {0} and {1} is {2}", a, b, aNum );
        }
        
    }
}

