namespace ArrayStatisticPrinter.Models
{
    using System;
    using System.Linq;

    public static class StatisticPrinter
    {
        public static void PrintStatistic(double[] statistic)
        {
            double minimal = GetMin(statistic);
            double maximal = GetMax(statistic);
            double average = GetAverage(statistic);

            Console.WriteLine("Minimal = {0}, Maximal = {1}, Average = {2}", minimal, maximal, average);
        }

        private static double GetMin(double[] array)
        {
            var minimal = array.Min();
            return minimal;
        }

        private static double GetMax(double[] array)
        {
            var maximal = array.Max();
            return maximal;
        }

        private static double GetAverage(double[] array)
        {
            var average = array.Average();
            return average;
        }
    }
}