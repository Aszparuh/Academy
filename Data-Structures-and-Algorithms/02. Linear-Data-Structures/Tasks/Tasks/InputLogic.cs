﻿namespace Tasks
{
    using System;
    using System.Collections.Generic;

    public static class InputLogic
    {
        public static List<int> GetInputAsList()
        {
            Console.WriteLine("Enter numbers:");
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