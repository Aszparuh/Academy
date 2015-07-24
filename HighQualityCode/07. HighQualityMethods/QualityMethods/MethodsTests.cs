namespace QualityMethods
{
    using System;
    using QualityMethods.Models;

    public class MethodsTests
    {
        public static void Main()
        {
            var someStudent = new Student("Peter", "Ivanov", DateTime.Now);
            Console.WriteLine(someStudent);

            Printer.PrintNumberAlignedRight(2000);
            Printer.PrintNumberAlignedRight(15000);
            Printer.PrintNumberAsPercentage(0.5);
            Printer.PrintNumberWithPrecision(0.4764345);
            Printer.PrintDigitAsWord(7);

            var firstPoint = new Point(25, 60);
            var secondPoint = new Point(22.5, 60);
            var distance = firstPoint.CalculateDistance(secondPoint.X, secondPoint.Y);
            Console.WriteLine(distance);

            var newLine = new Line(firstPoint, secondPoint);
            Console.WriteLine(newLine.IsVertical());
            Console.WriteLine(newLine.IsHorizontal());

            var area = TriangleAreaCalculator.Calculate(45, 27, 13); ////exception
            Console.WriteLine(area);          
        }
    }
}