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
