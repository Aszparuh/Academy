namespace Tasks
{
    using System;
    using System.Linq;

    class SequenceOperations
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers:");
            var inputCollection = InputLogic.GetInput();
            var sum = inputCollection.Sum();
            var average = inputCollection.Average();
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("The average is: {0}", average);
        }
    }
}