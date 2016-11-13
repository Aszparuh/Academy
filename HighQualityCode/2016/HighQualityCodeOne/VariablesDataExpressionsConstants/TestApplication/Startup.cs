using System;
using Shapes;
using Statistics.Models;

namespace TestApplication
{
    public class Startup
    {
        public static void Main()
        {
            var testRectangle = new Rectangle(25.3, 37.5);
            Console.WriteLine(testRectangle);
            var boxOfTestRectangle = testRectangle.GetBoundingBox(90);
            Console.WriteLine(boxOfTestRectangle);
            Console.WriteLine();

            double[] numbers = new double[] { 2.567, 356, 0.43234, 897 };
            var printer = new StatisticsCalculator();
            var statistic = printer.GetStatistic(numbers);
            Console.WriteLine(statistic);
        }
    }
}
