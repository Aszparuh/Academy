using System;
using System.Collections.Generic;

namespace HungryTom
{
    public class Startup
    {
        private static readonly List<int> Visited = new List<int>();
        private static List<List<int>> Result = new List<List<int>>();
        private static Dictionary<int, List<int>> Graph;
        private static int startNode = 1;
        private static int numberOfRooms;
    
        public static void Main()
        {
            numberOfRooms = int.Parse(Console.ReadLine());
            int numberOfDoors = int.Parse(Console.ReadLine());
            Graph = new Dictionary<int, List<int>>(numberOfRooms + 1);

            for (int i = 0; i < numberOfRooms + 1; i++)
            {
                Graph.Add(i, new List<int>());
            }

            for (int i = 0; i < numberOfDoors; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var firstRoom = int.Parse(input[0]);
                var secondRoom = int.Parse(input[1]);

                Graph[firstRoom].Add(secondRoom);
                Graph[secondRoom].Add(firstRoom);
            }

            var path = new List<int>();
            path.Add(startNode);
            Visited.Add(startNode);

            HamiltonCycle(startNode, 1, path);

            if (Result.Count == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(Result.Count);
                Result.Sort((x, y) =>
                {
                    int result = 0;
                    for (int i = 0; i < x.Count; i++)
                    {
                        result = x[i].CompareTo(y[i]);
                        if (result != 0)
                        {
                            return result;
                        }
                    }
                    return result;
                }); 

                foreach (var item in Result)
                {
                    string result = string.Join(" ", item);
                    Console.WriteLine(result);
                }
            }
        }

        private static void HamiltonCycle(int node, int level, List<int> pathSoFar)
        {
            if (level == numberOfRooms)
            {
                foreach (var neighbour in Graph[node])
                {
                    if (neighbour == startNode)
                    {
                        List<int> p = new List<int>();
                        p.AddRange(pathSoFar);
                        p.Add(neighbour);
                        Result.Add(p);

                        break;
                    }
                }

                return;
            }

            for (int i = 0; i < Graph[node].Count; i++)
            {
                if (!Visited.Contains(Graph[node][i]))
                {
                    Visited.Add(Graph[node][i]);
                    pathSoFar.Add(Graph[node][i]);
                    HamiltonCycle(Graph[node][i], level + 1, pathSoFar);
                    pathSoFar.Remove(Graph[node][i]);
                    Visited.Remove(Graph[node][i]);
                }
            }
        }
    }
}
