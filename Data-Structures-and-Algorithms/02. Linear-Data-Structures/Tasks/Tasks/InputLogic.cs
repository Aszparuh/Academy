namespace Tasks
{
    using System;
    using System.Collections.Generic;

    public static class InputLogic
    {
        public static List<int> GetInput()
        {
            List<int> input = new List<int>();
            string inputLine;
            int inputAsInteger;

            while (true)
            {
                inputLine = Console.ReadLine();

                if (String.IsNullOrEmpty(inputLine))
                {
                    break;
                }

                if (int.TryParse(inputLine, out inputAsInteger))
                {
                    if (inputAsInteger < 0)
                    {
                        throw new ArgumentException("You must enter only possitive numbers");
                    }
                    else
                    {
                        input.Add(inputAsInteger);
                    }
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