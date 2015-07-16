namespace ArrayStatisticPrinter
{
    using ArrayStatisticPrinter.Models;

    class TestStatisticPrinter
    {
        static void Main()
        {
            double[] testArray = new double[] { 2.567, 356, 0.43234, 897 };
            StatisticPrinter.PrintStatistic(testArray);
        }
    }
}