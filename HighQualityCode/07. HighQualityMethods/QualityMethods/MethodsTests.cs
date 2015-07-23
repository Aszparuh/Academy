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

            var area = TriangleAreaCalculator.Calculate(45, 27, 13);
            Console.WriteLine(area);
        }
    }
}