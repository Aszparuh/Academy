namespace ShortestSequence
{
    using System;
    using System.Collections.Generic;

    class FindShortestSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter number for start of the sequence N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for the end of the sequence M: ");
            int m = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            while (m / 2 >= n)
            {
                m /= 2;
                stack.Push(m);
            }

            while (m - 2 >= n)
            {
                m -= 2;
                stack.Push(m);
            }

            while (m - 1 >= n)
            {
                m -= 1;
                stack.Push(m);
            }

            Console.WriteLine(string.Join("=>", stack));
        }
    }
}