using System;
using System.Collections.Generic;
using System.Linq;

namespace Diameter
{
    public class Startup
    {
        public static void Main()
        {
            //input
            var numberOfNodes = int.Parse(Console.ReadLine());
            var tree = new Dictionary<int, Node>();

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var firstNodeId = input[0];
                var secondNodeId = input[1];
                var pathLenght = input[2];
                Node first;
                Node second;

                if (tree.ContainsKey(firstNodeId))
                {
                    first = tree[firstNodeId];
                }
                else
                {
                    first = new Node(0);
                    tree.Add(firstNodeId, first);
                }

                if (tree.ContainsKey(secondNodeId))
                {
                    second = tree[secondNodeId];
                }
                else
                {
                    second = new Node(pathLenght);
                    tree.Add(secondNodeId, second);
                }

                if (first.Left == null)
                {
                    first.Left = second;
                }
                else
                {
                    first.Right = second;
                }
            }

            int maxPath = 0;

            foreach (var node in tree)
            {
                var path = Diameter(node.Value);
                if (path > maxPath)
                {
                    maxPath = path;
                }
            }

            Console.WriteLine(maxPath);
        }

        private static int Diameter(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftHeight = Height(root.Left);
            var rightHeight = Height(root.Right);

            var leftDiameter = Diameter(root.Left);
            var rightDiameter = Diameter(root.Right);

            var maxDiameter = Math.Max(leftDiameter, rightDiameter);
            var totalHeight = leftHeight + rightHeight + root.pathToParent;

            var maxBoth = Math.Max(maxDiameter, totalHeight);

            return maxBoth;
        }

        private static int Height(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            var leftHeight = Height(node.Left);
            var rightHeight = Height(node.Right);
            int height = node.pathToParent + Math.Max(leftHeight, rightHeight);

            return height;
        }
    }

    public class Node
    {
        public Node(int pathToParent)
        {
            this.pathToParent = pathToParent;
        }

        public int pathToParent { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }
    }
}
