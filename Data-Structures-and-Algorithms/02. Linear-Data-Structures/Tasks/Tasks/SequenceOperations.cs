namespace Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SequenceOperations
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers:");
            var inputList = InputLogic.GetInputAsList();           
            var inputStack = new Stack<int>(inputList);
            var sum = inputList.Sum();
            var average = inputList.Average();
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("The average is: {0}", average);
            Console.WriteLine();
            Console.WriteLine("Collection reversed using Stack");
            Console.WriteLine(string.Join(" ,", inputStack));

            inputList.Sort();
            Console.WriteLine("Sorted list");
            Console.WriteLine(string.Join(" ,", inputList));

        }
    }
}