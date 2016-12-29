using System;
using System.Collections.Generic;
using System.Linq;

namespace CarryingCapacity
{
    public class Startup
    {
        public const int Inf = int.MaxValue;
        public const int Uninitialized = -1;
        public static int numberOfVertices;
        public static int[,] capacities;
        public static int[,] flowPassed;
        public static Dictionary<int, List<int>> graph;
        public static int[] parentList;
        public static int[] currentPathCapacity;

        public static void Main()
        {
            numberOfVertices = int.Parse(Console.ReadLine());
            var numberOfEdges = int.Parse(Console.ReadLine());
            var sourceAndSink = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var source = sourceAndSink[0];
            var sink = sourceAndSink[1];

            capacities = new int[numberOfVertices, numberOfVertices];
            flowPassed = new int[numberOfVertices, numberOfVertices];
            graph = new Dictionary<int, List<int>>();

            currentPathCapacity = new int[numberOfVertices];

            for (int i = 0; i < numberOfEdges; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var firstNode = input[0];
                var secondNode = input[1];
                var capacity = input[2];

                capacities[firstNode, secondNode] = capacity;

                if (!graph.ContainsKey(firstNode))
                {
                    graph[firstNode] = new List<int>();
                }

                if (!graph.ContainsKey(secondNode))
                {
                    graph[secondNode] = new List<int>();
                }

                graph[firstNode].Add(secondNode);
                graph[secondNode].Add(firstNode);
            }

            for (int i = 0; i < numberOfVertices; i++)
            {
                var max = EdmondsKarp(0, i);
                //capacities = new int[numberOfVertices, numberOfVertices];
                flowPassed = new int[numberOfVertices, numberOfVertices];
                Console.WriteLine(max);
            }
            
        }

        public static int Bfs(int startNode, int endNode)
        {
            parentList = new int[numberOfVertices];
            for (int i = 0; i < numberOfVertices; i++)
            {
                parentList[i] = Uninitialized;
            }

            currentPathCapacity = new int[numberOfVertices];

            var q = new Queue<int>();
            q.Enqueue(startNode);

            parentList[startNode] = -2;
            currentPathCapacity[startNode] = Inf;

            while (q.Count != 0)
            {
                int currentNode = q.Dequeue();

                for (int i = 0; i < graph[currentNode].Count; i++)
                {
                    var to = graph[currentNode][i];

                    if (parentList[to] == Uninitialized)
                    {
                        if (capacities[currentNode, to] - flowPassed[currentNode, to] > 0)
                        {
                            // we update the parent of the future node to be the current node
                            parentList[to] = currentNode;

                            // we check which is the minimum flow so far
                            currentPathCapacity[to] = Math.Min(currentPathCapacity[currentNode], capacities[currentNode, to] - flowPassed[currentNode, to]);

                            if (to == endNode)
                            {
                                return currentPathCapacity[endNode];
                            }

                            q.Enqueue(to);
                        }
                    }
                }
            }

            return 0;
        }

        public static int EdmondsKarp(int startNode, int endNode)
        {
            int maxFlow = 0;

            while (true)
            {
                int flow = Bfs(startNode, endNode);

                //Console.WriteLine(flow);

                if (flow == 0)
                {
                    break;
                }

                maxFlow += flow;
                int currentNode = endNode;

                while (currentNode != startNode)
                {
                    int previousNode = parentList[currentNode];
                    flowPassed[previousNode, currentNode] += flow;
                    flowPassed[currentNode, previousNode] -= flow;

                    currentNode = previousNode;
                }
            }

            return maxFlow;
        }
    }
}