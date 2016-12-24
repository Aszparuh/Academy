using System;
using System.Collections.Generic;

namespace CarryingCapacity
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfVerices = int.Parse(Console.ReadLine());
            var numberOfEdges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEdges; i++)
            {

            }

        }
    }

    public class Node
    {
        public Node(int id)
        {
            this.Edges = new List<Edge>();
            this.DijkstraDistance = int.MaxValue;
            this.Id = id;
        }

        public int Id { get; private set; }

        public int DijkstraDistance { get; set; }

        public List<Edge> Edges { get; private set; }
    }

    public class Edge
    {
        public Edge(int weight, Node toNode)
        {
            this.Weigth = weight;
            this.ToNode = toNode;
        }

        public int Weigth { get; set; }

        public Node ToNode { get; set; }
    }
}
