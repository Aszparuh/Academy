using System;
using System.Collections.Generic;

namespace DiameterV3
{
    public class Startup
    {
        private static int[,] graph;
        private static int V;
        private static int Inf = int.MinValue;

        public static void Main()
        {
            graph = new int[,]{
                            { 0, 0, 0, 0, 0},
                            { 0, 0, 0, 0, 0 },
                            { 6, 0, 0, 0, 0 },
                            { 4, 0, 0, 0, 0 },
                            { 0, 8, 0, 3, 0 }
                    };
            V = 5;
            var Q = new Queue<int>();
            var order = new List<int>();
            var indegree = new int[V];

            CalculateInDegree(indegree);

            for (int i = 0; i < indegree.Length; i++)
            {
                if (indegree[i] == 0)
                {
                    Q.Enqueue(i);
                }
            }

            if (Q.Count == 0)
            {
                Console.WriteLine("Graph contains cycle,no topological sort");
            }

            while (Q.Count != 0)
            {
                int u = Q.Dequeue();
                order.Add(u);

                for (int v = 0; v < indegree.Length; v++)
                {
                    if (graph[u, v] != 0)
                    {
                        indegree[v]--;

                        if (indegree[v] == 0)
                        {
                            Q.Enqueue(v);
                        }
                    }
                }
            }

            LongestPath(order, 4);
        }

        private static void CalculateInDegree(int[] indegree)
        {
            for (int i = 0; i < indegree.Length; i++)
            {
                indegree[i] = 0;
            }

            for (int i = 0; i < indegree.Length; i++)
            {
                for (int j = 0; j < indegree.Length; j++)
                {
                    if (graph[i, j] != 0)
                    {
                        indegree[j]++; 
                    }
                }
            }
        }

        private static void LongestPath(List<int> order, int source)
        {
            var dist = new int[V];
            for (int i = 0; i < V; i++)
            {
                dist[i] = Inf;
            }

            dist[source] = 0;

            for (int i = 0; i < order.Count; i++)
            {
                int u = i;

                for (int j = 0; j < V; j++)
                {
                    if (graph[u, j] != 0)
                    {
                        if (dist[j] < dist[u] + graph[u, j])
                        {
                            dist[j] = dist[u] + graph[u, j];
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" , ", dist));
        }
    }
}
