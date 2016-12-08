using System;

namespace AvlTrees.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            var tree = new BinarySearchTree<int>();
            Console.WriteLine(tree.Contains(17));
            tree.Add(13);
            tree.Add(17);
            Console.WriteLine(tree.Contains(17));

            var items = new int[] { 25, 34, -3456, 2222, 678, -500, 0, 14 };

            foreach (var item in items)
            {
                tree.Add(item);
            }

            tree.Remove(14);

            foreach (var item in tree)
            {
                Console.WriteLine("Item: {0}", item);
            }
        }
    }
}
