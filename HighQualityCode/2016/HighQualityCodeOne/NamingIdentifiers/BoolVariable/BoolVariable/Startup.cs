using BoolVariable.Models;

namespace BoolVariable
{
    public class Startup
    {
        public static void Main()
        {
            var printer = new BoolVariablePrinter();
            var parameter = true;

            printer.PrintVariable(parameter);
        }
    }
}
