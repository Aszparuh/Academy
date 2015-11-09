namespace AllTask
{
    using System;
    using System.Linq;

    using CustomPriorityQueue;
    using Products;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var priorityQueue = new PriorityQueue<int, string>();
            var orderedBag = new OrderedBag<Product>();

            for (int i = 0; i < 20; i++)
            {
                priorityQueue.Enqueue(i, "client whith priority: " + i);
            }

            Console.WriteLine(priorityQueue.Dequeue().Value);
            Console.WriteLine(priorityQueue.Dequeue().Value);
            Console.WriteLine(priorityQueue.Dequeue().Value);

            for (int i = 0; i < 100000; i++)
            {
                var product = new Product
                {
                    Name = string.Format("Some name: {0}", i),
                    Price = i % 7
                };

                orderedBag.Add(product);
            }

            var productFrom = new Product
            {
                Price = 1,
            };

            var productTo = new Product
            {
                Price = 8,
            };

            var inRange = orderedBag.Range(productFrom, true, productTo, true).Take(20);

            foreach (var product in inRange)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine("-----------------");
            }
        }
    }
}