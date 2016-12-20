using System;
using System.Collections.Generic;

namespace WalkInThePark
{
    public class Startup
    {
        private static List<List<int>> graph;

        public static void Main()
        {
            var numberOfEdges = int.Parse(Console.ReadLine());
            graph = new List<List<int>>();

            for (int i = 0; i < numberOfEdges; i++)
            {
                graph.Add(new List<int>());
            }

            for (int i = 0; i < numberOfEdges; i++)
            {
                var input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '1')
                    {
                        graph[i].Add(j);
                        graph[j].Add(i);
                    }
                }

                if (graph[i].Count % 2 != 0)
                {
                    Console.WriteLine("Number of routes: 0");
                    break;
                }
            }
        }
    }
}

