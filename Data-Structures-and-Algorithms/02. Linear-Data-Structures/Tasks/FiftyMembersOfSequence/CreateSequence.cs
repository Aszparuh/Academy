namespace FiftyMembersOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CreateSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            var resultQueue = new Queue<int>();

            resultQueue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                resultQueue.Enqueue(resultQueue.First() + 1);
                resultQueue.Enqueue(resultQueue.First() * 2 + 1);
                resultQueue.Enqueue(resultQueue.First() + 2);
                Console.WriteLine(resultQueue.Dequeue());
            }
        }
    }
}