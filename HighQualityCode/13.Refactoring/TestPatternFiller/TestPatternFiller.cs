namespace TestPatternFiller
{
    using System;
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RotatingWalkInMatrix;

    [TestClass]
    public class Matrix
    {
        private const string ExampleInput = "6";
        private const string ExpectedOutputFormExample = "  1 16 17 18 19 20\r\n" +
                                                        " 15  2 27 28 29 21\r\n" +
                                                        " 14 31  3 26 30 22\r\n" +
                                                        " 13 32 34  4 25 23\r\n" +
                                                        " 12 33 36 35  5 24\r\n" +
                                                        " 11 10  9  8  7  6\r\n";

        // Console Unit Test

      ////http://blogs.msdn.com/b/ploeh/archive/2006/10/21/consoleunittesting.aspx

        [TestMethod]
        public void TestExampleOutput()
        {
            using (StringReader input = new StringReader(ExampleInput))
            {
                Console.SetIn(input);
                using (StringWriter output = new StringWriter())
                {
                    Console.SetOut(output);
                    EntryPoint.Main();

                    Assert.AreEqual(ExpectedOutputFormExample, output.ToString());
                }
            }
        }
    }
}