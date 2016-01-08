namespace RemoveOddNumbers
{
    using System;
    using System.Collections.Generic;
    using Tasks;

    class RemoveOdd
    {
        static void Main()
        {
            var inputList = InputLogicWithNegativeNumbers.GetInputAsList();
            var resultList = new List<int>();

            foreach (var number in inputList)
            {
                if (number < 0)
                {
                    resultList.Add(number);
                }
            }

            Console.WriteLine("The positive numbers are:");
            Console.WriteLine(string.Join(" ,",resultList));
        }
    }
}