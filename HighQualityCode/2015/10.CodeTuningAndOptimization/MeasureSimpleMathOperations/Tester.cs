namespace MeasureSimpleMathOperations
{
    using System;
    using System.Diagnostics;

    public static class Tester
    {
        private const int IntTestValue = 1;
        private const long LongTestValue = 1L;
        private const float FloatTestValue = 1.0F;
        private const double DoubleTestValue = 1.0;
        private const decimal DecimalTestValue = 1.0M;
        private const int TimesToRepeat = 1000000;
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        public static void TestOperationsOnInt()
        {
            int result = IntTestValue;
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result += IntTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Addition Int: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result -= IntTestValue;
            }


            Stopwatch.Stop();
            Console.WriteLine("Subtraction Int: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result *= IntTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Multiplication Int: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result /= IntTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Division Int: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        public static void TestOperationsOnLong()
        {
            long result = LongTestValue;
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result += LongTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Addition Long: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result -= LongTestValue;
            }


            Stopwatch.Stop();
            Console.WriteLine("Subtraction Long: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result *= LongTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Multiplication Long: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result /= LongTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Division Long: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        public static void TestOperationsOnFloat()
        {
            float result = FloatTestValue;
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result += FloatTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Addition Float: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result -= FloatTestValue;
            }


            Stopwatch.Stop();
            Console.WriteLine("Subtraction Float: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result *= FloatTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Multiplication Float: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result /= FloatTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Division Float: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        public static void TestOperationsOnDouble()
        {
            double result = DoubleTestValue;
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result += DoubleTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Addition Double: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result -= DoubleTestValue;
            }


            Stopwatch.Stop();
            Console.WriteLine("Subtraction Double: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result *= DoubleTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Multiplication Double: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result /= FloatTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Division Double: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        public static void TestOperationsOnDecimal()
        {
            decimal result = DecimalTestValue;
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result += DecimalTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Addition Decimal: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result -= DecimalTestValue;
            }


            Stopwatch.Stop();
            Console.WriteLine("Subtraction Decimal: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();

            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result *= DecimalTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Multiplication Decimal: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
            Stopwatch.Start();

            for (int i = 0; i < TimesToRepeat; i++)
            {
                result /= DecimalTestValue;
            }

            Stopwatch.Stop();
            Console.WriteLine("Division Decimal: {0}", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}