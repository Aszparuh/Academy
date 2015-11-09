namespace AllTask
{
    using System;
    using CustomPriorityQueue;

    public class Startup
    {
        public static void Main()
        {
            var priorityQueue = new PriorityQueue<int, string>();

            for (int i = 0; i < 20; i++)
            {
                priorityQueue.Enqueue(i, "client whith priority: " + i);
            }

            Console.WriteLine(priorityQueue.Dequeue().Value);
            Console.WriteLine(priorityQueue.Dequeue().Value);
            Console.WriteLine(priorityQueue.Dequeue().Value);
        }
    }
}