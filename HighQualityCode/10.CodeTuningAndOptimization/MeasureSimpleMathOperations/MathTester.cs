namespace MeasureSimpleMathOperations
{
    using System;
    using System.Diagnostics;

    public static class MathTester
    {
        private const float FloatTestValue = 1000.0F;
        private const double DoubleTestValue = 1000.0;
        private const decimal DecimalTestValue = 1000.0M;
        private const int TimesRepeat = 1000000;
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        public static void TestMathOnFloat()
        {
            float result = 0;
            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = (float)Math.Sqrt(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Sqrt float: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = (float)Math.Sin(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Sin float: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = (float)Math.Log(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Log float: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        public static void TestMathOnDouble()
        {
            double result = 0;
            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = Math.Sqrt(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Sqrt double: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = Math.Sin(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Sin double: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = Math.Log(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Log double: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        public static void TestMathOnDecimal()
        {
            decimal result = 0;
            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = (decimal)Math.Sqrt(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Sqrt decimal: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = (decimal)Math.Sin(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Sin decimal: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesRepeat; i++)
            {
                result = (decimal)Math.Log(FloatTestValue);
            }

            Stopwatch.Stop();
            Console.WriteLine("Math.Log decimal: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}