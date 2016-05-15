namespace AddingPolynomials
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[] separator = new char[] { ' ' };
            var firstPolynomial = Console.ReadLine()
                .Split(separator)
                .Select(num => int.Parse(num))
                .ToArray();

            var secondPolynomial = Console.ReadLine()
                .Split(separator)
                .Select(num => int.Parse(num))
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                firstPolynomial[i] += secondPolynomial[i];
            }

            Console.WriteLine(string.Join(" ", firstPolynomial));
        }
    }
}
