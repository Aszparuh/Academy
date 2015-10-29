namespace Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class InputLogicWithNegativeNumbers
    {
        public static List<int> GetInputAsList()
        {
            Console.WriteLine("Enter numbers: ");
            List<int> input = new List<int>();
            string inputLine;
            int inputAsInteger;

            while (true)
            {
                inputLine = Console.ReadLine();

                if (string.IsNullOrEmpty(inputLine))
                {
                    break;
                }

                if (int.TryParse(inputLine, out inputAsInteger))
                {
                    input.Add(inputAsInteger);
                }
                else
                {
                    throw new ArgumentException("The program works with numbers only");
                }
            }

            return input;
        }
    }
}
