namespace QualityMethods
{
    using System;
    using QualityMethods.Models;

    class MethodsTests
    {
        static void Main()
        {
            var someStudent = new Student("Peter", "Ivanov", DateTime.Now);
            Console.WriteLine(someStudent);

            Printer.PrintNumberAlignedRight(2000);
            Printer.PrintNumberAlignedRight(15000);
            Printer.PrintNumberAsPercentage(0.5);
            Printer.PrintNumberWithPrecision(0.4764345);
            Printer.PrintDigitAsWord(7);

            var area = TriangleAreaCalculator.Calculate(45, 27, 13); //exception
            Console.WriteLine(area);
        }
    }
}