using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
          
        //Extracting bit value
        int bitThree = ((1 << 3) & number) >> 3;
        int bitFour = ((1 << 4) & number) >> 4;
        int bitFive = ((1 << 5) & number) >> 5;
        int bitTwentyFour = ((1 << 24) & number) >> 24;
        int bitTwentyFive = ((1 << 25) & number) >> 25;
        int bitTwentySix = ((1 << 26) & number) >> 26;

        Console.WriteLine();
        Console.WriteLine("        The third bit is: {0}", bitThree);
        Console.WriteLine("       The fourth bit is: {0}", bitFour);
        Console.WriteLine("        The fifth bit is: {0}", bitFive);
        Console.WriteLine("The twenty-fourth bit is: {0}", bitTwentyFour);
        Console.WriteLine(" The twenty-fifth bit is: {0}", bitTwentyFive);
        Console.WriteLine(" The twenty-sixth bit is: {0}", bitTwentySix);
        Console.WriteLine();
        Console.WriteLine("   Your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));

        //exchanging bits 3 and 24


        if (bitThree == 1)
        {
            number = (1 << 24) | number;
        }
        else 
        {
            number = ~(1 << 24) & number;
        }
        if (bitTwentyFour == 1)
        {
            number = (1 << 3) | number;
        }
        else 
        {
            number = ~(1 << 3) & number;
        }

        //exchanging bit 4 with 25

        if (bitFour == 1)
        {
            number = (1 << 25) | number;
        }
        else 
        {
            number = ~(1 << 25) & number;
        }
        if (bitTwentyFive == 1)
        {
            number = (1 << 4) | number;
        }
        else 
        {
            number = ~(1 << 4) & number;
        }
        
        //exchanging bit 5 with 26

        if (bitFive == 1)
        {
            number = (1 << 26) | number;
        }
        else
        {
            number = ~(1 << 26) & number;
        }
        if (bitTwentySix == 1)
        {
            number = (1 << 5) | number;
        }
        else
        {
            number = ~(1 << 5) & number;
        }

        Console.WriteLine("Changed number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine();
        Console.WriteLine("After changing the bits your number is: {0}", number);
    }
}
