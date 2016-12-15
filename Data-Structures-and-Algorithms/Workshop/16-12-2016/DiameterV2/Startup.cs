using System;
using System.Collections.Generic;
using System.Linq;

namespace DiameterV2
{
    public class Startup
    {   
        public static void Main()
        {
            var graph = new Dictionary<int, Node>();
            var numberOfNodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var first = input[0];
                var second = input[0];
                var value = input[0];

                Node firstNode;
                Node secondNode;

                if (graph.ContainsKey(first))
                {
                    firstNode = graph[first];
                }
                else
                {
                    firstNode = new Node();
                    graph.Add(first, firstNode);
                }

                if (graph.ContainsKey(second))
                {
                    secondNode = graph[second];
                }
                else
                {
                    secondNode = new Node();
                    graph.Add(second, secondNode);
                }

                firstNode.Neighbours.Add(secondNode, value);
                secondNode.Neighbours.Add(firstNode, value);
            }
        }

        private static void Dfs()
        {
           
        }
    }

    public class Node
    {
        public Dictionary<Node, int> Neighbours { get; set; }
    }
}
