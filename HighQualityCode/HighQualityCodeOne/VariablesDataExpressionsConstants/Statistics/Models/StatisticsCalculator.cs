using System.Linq;

namespace Statistics.Models
{
    public class StatisticsCalculator
    {
        public string GetStatistic(double[] statistic)
        {
            double minimal = this.GetMin(statistic);
            double maximal = this.GetMax(statistic);
            double average = this.GetAverage(statistic);
            string statistics = string.Format("Minimal = {0}, Maximal = {1}, Average = {2}", minimal, maximal, average);

            return statistics;
        }

        private double GetMin(double[] array)
        {
            var minimal = array.Min();
            return minimal;
        }

        private double GetMax(double[] array)
        {
            var maximal = array.Max();
            return maximal;
        }

        private double GetAverage(double[] array)
        {
            var average = array.Average();
            return average;
        }
    }
}
