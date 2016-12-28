using System;
using CarryingCapacity;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            var priorityQueue = new PriorityQueue<int>();

            for (int i = 20; i >= 0; i--)
            {
                priorityQueue.Enqueue(i);
            }

            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }
    }
}
