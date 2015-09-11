namespace ArrayStatisticPrinter
{
    using ArrayStatisticPrinter.Models;

    public class TestStatisticPrinter
    {
        public static void Main()
        {
            double[] testArray = new double[] { 2.567, 356, 0.43234, 897 };
            StatisticPrinter.PrintStatistic(testArray);
        }
    }
}