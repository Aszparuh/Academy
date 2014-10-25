using System;

class IntDouble
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;

        Console.WriteLine("Int is {0}, Double is {1}", intNumber, doubleNumber);
        Console.WriteLine("Int is {0}, Double is {1}", intNumber + 5, doubleNumber + 10);

    }
}

