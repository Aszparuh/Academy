namespace GetLargestNumber
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }).Select(n => int.Parse(n)).ToArray();
            var largestNumber = GetMax(GetMax(numbers[0], numbers[1]), numbers[2]);
            Console.WriteLine(largestNumber);
        }

        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
