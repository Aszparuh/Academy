using System;

/*Write a method that adds two polynomials.
Represent them as arrays of their coefficients as in
the example below:
x 2 + 5 = 1x 2 + 0x + 5 >> 5,0,1*/

class AddPolinomials
{
    static decimal[] GetCoefficients(int degree)
    {
        decimal[] array = new decimal[degree + 1];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter coefficient on {0} degree", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    static decimal[] AddPolinomials(decimal[] firstPolnomial, decimal[] secondPolinomial)
    {
        if (secondPolinomial.Length < firstPolnomial.Length)
        {
            return AddPolinomials(secondPolinomial, firstPolnomial);
        }
        decimal[] result = new decimal[secondPolinomial.Length];
        for (int i = 0; i < firstPolnomial.Length; i++)
        {
            result[i] = firstPolnomial[i] + secondPolinomial[i];
        }
        for (int i = firstPolnomial.Length - 1; i < secondPolinomial.Length; i++)
        {
            result[i] = secondPolinomial[i];
        }
    }
    static void Main()
    {
        Console.Write("Enter degree for first polinomial: ");
        int firstDegree = int.Parse(Console.ReadLine());
        Console.Write("Enter degree for second polinomial: ");
        int secondDegree = int.Parse(Console.ReadLine());
    }
}

