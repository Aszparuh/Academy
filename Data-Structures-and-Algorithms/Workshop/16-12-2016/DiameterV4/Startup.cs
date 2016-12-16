using System;
using System.Collections.Generic;

namespace DiameterV4
{
    public class Startup
    {
        public static void Main()
        {
            var graph = new Graph(5);
            graph.AddEdge(3, 4, 3);
            graph.AddEdge(0, 3, 4);
            graph.AddEdge(0, 2, 6);
            graph.AddEdge(1, 4, 9);

            int s = 4;
            graph.LongestPath(s);
        }
    }

    public class AdjListNode
    {
        private int v;
        private int weight;

        public AdjListNode(int v, int weight)
        {
            this.v = v;
            this.weight = weight;
        }

        public int V
        {
            get
            {
                return this.v;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
        }
    }

    public class Graph
    {
        private int v;
        private AdjListNode[] adj;

        public Graph(int v)
        {
            this.v = v;
            this.adj = new AdjListNode[v];
        }

        public void AddEdge(int u, int v, int weight)
        {
            var left = this.adj[u];
            var right = this.adj[v];

            if (left == null)
            {
                left = new AdjListNode(u, 0);
                this.adj[u] = left;
            }

            if (right == null)
            {
                right = new AdjListNode(v, weight);
                this.adj[v] = right;
            }

        }

        public void LongestPath(int s)
        {
            var stack = new Stack<int>();
            var dist = new int[this.v];
            var visited = new bool[this.v];

            for (int i = 0; i < this.v; i++)
            {
                if (visited[i] == false)
                {
                    TopologicalSort(i, visited, stack);
                }
            }

            for (int i = 0; i < this.v; i++)
            {
                dist[i] = int.MinValue;
            }

            dist[s] = 0;

            while (stack.Count > 0)
            {
                int u = stack.Pop();

                if (dist[u] != int.MinValue)
                {
                    for (int i = 0; i < this.adj.Length; i++)
                    {
                        if (dist[this.adj[i].V] < dist[u] + this.adj[i].Weight)
                        {
                            dist[this.adj[i].V] = dist[u] + this.adj[i].Weight;
                        }
                    }
                }
            }

            for (int i = 0; i < this.v; i++)
            {
                if (dist[i] == int.MinValue)
                {
                    Console.WriteLine("Inf");
                }
                else
                {
                    Console.WriteLine(dist[i]);
                }
            }
        }

        private void TopologicalSort(int v, bool[] visited, Stack<int> stack)
        {
            visited[v] = true;

            for (int i = 0; i < this.adj.Length; i++)
            {
                var node = this.adj[i];

                if (!visited[node.V])
                {
                    TopologicalSort(node.V, visited, stack);
                }
            }

            stack.Push(v);
        }
    }
}
