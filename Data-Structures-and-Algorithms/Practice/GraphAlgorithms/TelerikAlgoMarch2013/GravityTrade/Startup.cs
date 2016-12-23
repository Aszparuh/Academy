using System;
using System.Linq;

namespace GravityTrade
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfVerices = int.Parse(Console.ReadLine());
            var numberOfEdges = int.Parse(Console.ReadLine());
            var edges = new Edge[numberOfEdges];

            for (int i = 0; i < numberOfEdges; i++)
            {
                var input = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
                edges[i] = new Edge(input[0], input[1], input[2]);
            }

            //Bellman-Ford algoritm
            var distances = new int[numberOfVerices];
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = int.MaxValue;
            }

            distances[0] = 0;
            bool changed = true;

            for (int v = 0; (v < numberOfVerices - 1) && changed; v++)
            {
                for (int e = 0; e < edges.Length; e++)
                {
                    if (distances[edges[e].StartVertex] != int.MaxValue)
                    {
                        if (distances[edges[e].EndVertex] > distances[edges[e].StartVertex] + edges[e].Weight)
                        {
                            distances[edges[e].EndVertex] = distances[edges[e].StartVertex] + edges[e].Weight;
                            changed = true;
                        }
                    }
                }
            }

            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] == int.MaxValue)
                {
                    Console.WriteLine("Unreachable!");
                }
                else
                {
                    Console.WriteLine(distances[i]);
                }
            }
        }
    }

    public class Edge
    {
        public Edge(int startVertex, int endVertex, int weight)
        {
            this.StartVertex = startVertex;
            this.EndVertex = endVertex;
            this.Weight = weight;
        }

        public int StartVertex { get; set; }

        public int EndVertex { get; set; }

        public int Weight { get; set; }
    }
}
