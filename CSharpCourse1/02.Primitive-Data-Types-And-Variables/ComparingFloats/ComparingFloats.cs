using System;

/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature 
of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely 
to each other than a fixed constant eps.*/

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        float precision = 0.0000009f;
        float difference = firstNumber - secondNumber;

        if (difference < 0)
        {
            difference = difference * (-1);
        }
        if (difference > precision)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }

        //if (firstNumber - precision < secondNumber && firstNumber + precision > secondNumber)
        //{
        //    Console.WriteLine("Numbers are equal with precision 0,000001");   
        //}
        //else
        //{
        //    Console.WriteLine("Numbers are not equal with precision 0,000001");
        //}
    }
}