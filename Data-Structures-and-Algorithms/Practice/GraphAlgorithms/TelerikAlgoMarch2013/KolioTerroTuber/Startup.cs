using System;
using System.Linq;

namespace KolioTerroTuber
{
    public class Startup
    {
        public static int numberOfVertices;
        public static int connectedComponentsAfterExplosion;
        public static int[,] graph;
        public static int[] prenumerator;
        public static int[] lowest;
        public static int countDFS;

        public static void Main()
        {
            numberOfVertices = int.Parse(Console.ReadLine());
            connectedComponentsAfterExplosion = int.Parse(Console.ReadLine());
            graph = new int[numberOfVertices, numberOfVertices];
            prenumerator = new int[numberOfVertices];
            lowest = new int[numberOfVertices];

            for (int i = 0; i < numberOfVertices; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    graph[i, input[j] - 1] = 1;
                }
            }

            FindArticulationPoints();
        }

        public static void FindArticulationPoints()
        {
            var articulationPoints = new int[numberOfVertices];
            var counter = 0;

            DFS(0);

            for (int i = 0; i < numberOfVertices; i++)
            {
                if (prenumerator[i] == 0)
                {
                    Console.WriteLine(-2);
                    break;
                }
            }

            PostOrderTreeTraversal(0);

            for (int i = 0; i < numberOfVertices; i++)
            {
                if (graph[0, i] == 2)
                {
                    counter++;
                }
            }

            if (counter > 1)
            {
                articulationPoints[0] = 1;
            }

            for (int i = 1; i < numberOfVertices; i++)
            {
                int j;
                for (j = 0; j < numberOfVertices; j++)
                {
                    if (graph[i, j] == 2 && lowest[j] >= prenumerator[i])
                    {
                        break;
                    }
                }

                if (j < numberOfVertices)
                {
                    articulationPoints[i] = 1;
                }
            }

            bool noArticulationPoints = true;
            bool articulationPointNoDividedCorrectly = true;

            for (int i = 0; i < numberOfVertices; i++)
            {
                for (int j = 0; j < numberOfVertices; j++)
                {
                    if (graph[i, j] == 2)
                    {
                        graph[i, j] = 1;
                    }
                }
            }

            var backupGraph = new int[numberOfVertices, numberOfVertices];

            Array.Copy(graph, backupGraph, graph.Length);

            for (int i = 0; i < numberOfVertices; i++)
            {
                if (articulationPoints[i] == 1)
                {
                    noArticulationPoints = false;

                    Array.Copy(backupGraph, graph, graph.Length);

                    for (int j = 0; j < numberOfVertices; j++)
                    {
                        graph[i, j] = 0;
                        graph[j, i] = 0;
                    }

                    prenumerator = new int[numberOfVertices];
                    var partsCounter = 0;

                    for (int j = 0; j < numberOfVertices; j++)
                    {
                        if (prenumerator[j] == 0 && j != i)
                        {
                            DFS(j);
                            partsCounter++;
                        }
                    }

                    if (partsCounter == connectedComponentsAfterExplosion)
                    {
                        articulationPointNoDividedCorrectly = false;
                        Console.WriteLine(i + 1);
                    }
                }
            }

            if (noArticulationPoints)
            {
                Console.WriteLine(-1);
            }
            else if (articulationPointNoDividedCorrectly)
            {
                Console.WriteLine(0);
            }
        }

        public static void DFS(int node)
        {
            prenumerator[node] = ++countDFS;

            for (int edge = 0; edge < numberOfVertices; edge++)
            {
                if (graph[node, edge] != 0 && prenumerator[edge] == 0)
                {
                    graph[node, edge] = 2;
                    DFS(edge);
                }
            }
        }

        public static void PostOrderTreeTraversal(int node)
        {
            for (int edge = 0; edge < numberOfVertices; edge++)
            {
                if (graph[node, edge] == 2)
                {
                    PostOrderTreeTraversal(edge);
                }
            }

            lowest[node] = prenumerator[node];

            for (int edge = 0; edge < numberOfVertices; edge++)
            {
                if (graph[node, edge] == 1)
                {
                    lowest[node] = Min(lowest[node], prenumerator[edge]);
                }
            }

            for (int edge = 0; edge < numberOfVertices; edge++)
            {
                if (graph[node, edge] == 2)
                {
                    lowest[node] = Min(lowest[node], lowest[edge]);
                }
            }
        }

        public static int Min(int a, int b)
        {
            return (a < b) ? a : b;
        }
    }
}
