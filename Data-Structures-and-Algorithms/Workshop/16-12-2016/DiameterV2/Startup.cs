using System;
using System.Linq;

namespace DiameterV2
{
    public class Startup
    {
        public static int[,] graph;
        public static int max;
        public static int maxNode;
        public static int count;
        public static bool[] visited;

        public static void Main()
        {
            int numberOfNodes = int.Parse(Console.ReadLine());
            graph = new int[numberOfNodes, numberOfNodes];
            visited = new bool[numberOfNodes];

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var row = input[0];
                var column = input[1];
                var value = input[2];

                graph[row, column] = value;
                graph[column, row] = value;
            }

            Dfs(0);
            visited = new bool[numberOfNodes];
            Dfs(maxNode);
            Console.WriteLine(max);
        }

        private static void Dfs(int node)
        {
            visited[node] = true;

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (visited[i] != true && graph[node, i] != 0)
                {
                    count += graph[node, i];
                    Dfs(i);
                    count -= graph[node, i];
                }
            }

            if (count > max)
            {
                max = count;
                maxNode = node;
            }
        }
    }
}
