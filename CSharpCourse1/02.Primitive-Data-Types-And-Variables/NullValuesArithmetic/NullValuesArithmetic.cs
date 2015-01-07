using System;

/*Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;

        Console.WriteLine("Int is {0}, Double is {1}", intNumber, doubleNumber);
        Console.WriteLine("Int is {0}, Double is {1}", intNumber + 5, doubleNumber + 10);
    }
}