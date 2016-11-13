namespace MeasureSimpleMathOperations
{
    using System;

    public class OperationsTests
    {
        static void Main()
        {
            Console.WriteLine("Operations");
            Console.WriteLine();
            Tester.TestOperationsOnInt();
            Tester.TestOperationsOnLong();
            Tester.TestOperationsOnFloat();
            Tester.TestOperationsOnDouble();
            Tester.TestOperationsOnDecimal();

            Console.WriteLine();
            Console.WriteLine("Math Functions");
            Console.WriteLine();

            MathTester.TestMathOnFloat();
            MathTester.TestMathOnDouble();
            MathTester.TestMathOnDecimal();
        }
    }
}