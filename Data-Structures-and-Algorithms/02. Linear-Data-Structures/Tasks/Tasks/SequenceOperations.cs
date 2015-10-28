namespace Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Extesions;

    public class SequenceOperations
    {
        public static void Main()
        {
            Console.WriteLine("Enter numbers:");
            List<int> inputList = InputLogic.GetInputAsList();           
            var inputStack = new Stack<int>(inputList);
            var sum = inputList.Sum();
            var average = inputList.Average();
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("The average is: {0}", average);
            Console.WriteLine();
            Console.WriteLine("Collection reversed using Stack");
            Console.WriteLine(string.Join(" ,", inputStack));

            var listToSort = new List<int>(inputList);
            listToSort.Sort();
            Console.WriteLine("Sorted list");
            Console.WriteLine(string.Join(" ,", listToSort));

            var longestSubsequence = inputList.GetLongestSubsequence();
            Console.WriteLine("-------------");
            Console.WriteLine(string.Join(" ,", longestSubsequence));
        }
    }
}