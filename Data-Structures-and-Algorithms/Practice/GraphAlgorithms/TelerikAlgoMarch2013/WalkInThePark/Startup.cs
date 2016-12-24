using System;
using System.Collections.Generic;
using System.Linq;

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

            var tempPath = new Stack<int>();
            var finalPath = new Stack<int>();

            tempPath.Push(0);

            int next;
            while (numberOfEdges > 0)
            {
                if (graph[tempPath.Peek()].Count > 0)
                {
                    //There is unvisited edge from current vertex leading to the next vertex
                    next = graph[tempPath.Peek()].First();

                    //Removing both edges because the graph is not-oriented
                    graph[tempPath.Peek()].Remove(next);
                    graph[next].Remove(tempPath.Peek());
                    numberOfEdges -= 2;

                    //Moving to the next vertex
                    tempPath.Push(next);
                }
                else
                {
                    //Small cycle finished
                    finalPath.Push(tempPath.Pop());
                }

                //No way to go from passed vertices but there are still edges left, so the graph is not connected
                if (tempPath.Count == 0)
                {
                    Console.WriteLine("There is no Euler cycle because the graph is not connected!");
                    return;
                }

                //Adding final left vertices to finalPath
                while (tempPath.Count > 0)
                {
                    finalPath.Push(tempPath.Pop());
                }               
            }
        }
    }
}

