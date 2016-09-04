using System;

namespace BoolVariable.Models
{
    public class BoolVariablePrinter
    {
        private const int MaxNumberOfCalls = 6;

        public void PrintVariable(bool variable)
        {
            string result = variable.ToString();

            Console.WriteLine(result);
        }
    }
}
