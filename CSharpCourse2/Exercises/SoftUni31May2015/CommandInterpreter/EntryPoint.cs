namespace CommandInterpreter
{
    //75/100 https://judge.softuni.bg/Contests/Practice/Index/91#0
    using System;
    
    public class EntryPoint
    {
        public static void Main()
        {
            //ReadInput
            string input = Console.ReadLine();
            var splittedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                var splittedComandLine = commandLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = splittedComandLine[0];

                if (command == "reverse")
                {
                    var start = int.Parse(splittedComandLine[2]);
                    var count = int.Parse(splittedComandLine[4]);

                    if (start < 0 || start > splittedInput.Length - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else if (count < 0 || count > splittedInput.Length - start)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        Array.Reverse(splittedInput, start, count);
                    }
                }

                if (command == "sort")
                {
                    var start = int.Parse(splittedComandLine[2]);
                    var count = int.Parse(splittedComandLine[4]);

                    if (start < 0 || start > splittedInput.Length - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else if (count < 0 || count > splittedInput.Length - start)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        Array.Sort(splittedInput, start, count);
                    }
                }

                if (command == "rollRight")
                {
                    var count = int.Parse(splittedComandLine[1]);
                    var destinationArray = new string[splittedInput.Length];
                    for (int i = 0; i < count; i++)
                    {
                        var lastValue = splittedInput[splittedInput.Length - 1];
                        Array.Copy(splittedInput, 0, destinationArray, 1, splittedInput.Length - 1);
                        destinationArray[0] = lastValue;
                        splittedInput = destinationArray;
                    }
                }

                if (command == "rollLeft")
                {
                    var count = int.Parse(splittedComandLine[1]);
                    var destinationArray = new string[splittedInput.Length];
                    for (int i = 0; i < count; i++)
                    {
                        var firstValue = splittedInput[0];
                        Array.Copy(splittedInput, 1, destinationArray, 0, splittedInput.Length - 1);
                        destinationArray[destinationArray.Length - 1] = firstValue;
                        splittedInput = destinationArray;
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", splittedInput));
            Console.WriteLine("]");
        }
    }
}
