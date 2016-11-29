using System;
using System.Collections.Generic;

namespace ReversePolishNotation
{
    public class Startup
    {
        public static void Main()
        {
            var notation = Console.ReadLine().Split(' ');
            var result = new Stack<int>();

            for (int i = 0; i < notation.Length; i++)
            {
                var currentElement = notation[i];
                int number;
                if (int.TryParse(currentElement, out number))
                {
                    result.Push(number);
                }
                else
                {
                    var a = result.Pop();
                    var b = result.Pop();

                    if (notation[i] == "+")
                    {
                        result.Push(a + b);
                    }
                    else if (notation[i] == "-")
                    {
                        result.Push(b - a);
                    }
                    else if (notation[i] == "*")
                    {
                        result.Push(a * b);
                    }
                    else if (notation[i] == "/")
                    {
                        result.Push(b / a);
                    }
                    else if (notation[i] == "|")
                    {
                        result.Push(b | a);
                    }
                    else if (notation[i] == "&")
                    {
                        result.Push(a & b);
                    }
                    else if (notation[i] == "^")
                    {
                        result.Push(a ^ b);
                    }
                }
            }

            if (result.Count > 1)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(result.Pop());
            }
        }
    }
}
