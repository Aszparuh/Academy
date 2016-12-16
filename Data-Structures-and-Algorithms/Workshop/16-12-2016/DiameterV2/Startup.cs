using System;
using System.Collections.Generic;
using System.Linq;

namespace DiameterV2
{

    public class Startup
    {
        private static int inf = int.MaxValue;

        public static void Main()
        {
            //int[,] graph = {
            //                { 0, INF, 6, 4, INF},
            //                { INF, 0, INF, INF, 9 },
            //                { 6, INF, 0, INF, INF },
            //                { 4, INF, INF, 0, 3 },
            //                { INF, 9, INF, 3, 0 }
            //            };

            int numberOfNodes = int.Parse(Console.ReadLine());
            var graph = new int[numberOfNodes, numberOfNodes];
            var visited = new bool[numberOfNodes];

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var row = input[0];
                var column = input[1];
                var value = input[2];

                graph[row, column] = value;
                graph[column, row] = value;
            }

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] == 0 && i != j)
                    {
                        graph[i, j] = int.MaxValue;
                    }
                }
            }

            FloydWarshall(graph);
            Console.WriteLine(GetPath(graph));
        }

        /**
  * Floyd-Warshall algorithm. Finds all shortest paths among all pairs of nodes
  * @param d matrix of distances (Integer.MAX_VALUE represents positive infinity)
  * @return matrix of predecessors
  */
        public static int[,] FloydWarshall(int[,] d)
        {
            int[,] p = constructInitialMatixOfPredecessors(d);
            for (int k = 0; k < d.GetLength(0); k++)
            {
                for (int i = 0; i < d.GetLength(0); i++)
                {
                    for (int j = 0; j < d.GetLength(0); j++)
                    {
                        if (d[i, k] == int.MaxValue || d[k, j] == int.MaxValue)
                        {
                            continue;
                        }

                        if (d[i, j] > d[i, k] + d[k, j])
                        {
                            d[i, j] = d[i, k] + d[k, j];
                            p[i, j] = p[k, j];
                        }

                    }
                }
            }

            return p;
        }

        /**
         * Constructs matrix P0
         * @param d matrix of lengths
         * @return P0
         */
        private static int[,] constructInitialMatixOfPredecessors(int[,] d)
        {
            int[,] p = new int[d.GetLength(0), d.GetLength(0)];
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(0); j++)
                {
                    if (d[i, j] != 0 && d[i, j] != int.MaxValue)
                    {
                        p[i, j] = i;
                    }
                    else
                    {
                        p[i, j] = -1;
                    }
                }
            }

            return p;
        }

        private static int GetPath(int[,] P)
        {
            int max = 0;
            for (int i = 0; i < P.GetLength(0); i++)
            {
                for (int j = 0; j < P.GetLength(0); j++)
                {
                    if (P[i, j] > max)
                    {
                        max = P[i, j];
                    }
                }
            }

            return max;
        }

        private void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }
        }
    }
}
