using System;
using System.Collections.Generic;
using System.Linq;

namespace CarryingCapacity
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfVerices = int.Parse(Console.ReadLine());
            var numberOfEdges = int.Parse(Console.ReadLine());
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            for (int i = 0; i < numberOfEdges; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var fromNode = input[0];
                var toNode = input[1];
                var weight = input[2];
                Node first;
                Node second;

                if (!nodes.ContainsKey(fromNode))
                {
                    first = new Node();
                    nodes.Add(fromNode, first);
                }
                else
                {
                    first = nodes[fromNode];
                }

                if (!nodes.ContainsKey(toNode))
                {
                    second = new Node();
                    nodes.Add(toNode, second);
                }
                else
                {
                    second = nodes[toNode];
                }

                first.Edges.Add(new Edge(weight, second));
                second.Edges.Add(new Edge(weight, first));
            }
        }

        private static void DijkstraAlgorithm(Dictionary<int, Node> graph, Node source)
        {
            var queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                node.Value.DijkstraDistance = int.MaxValue;
            }

            source.DijkstraDistance = 0;
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();

                if (currentNode.DijkstraDistance == int.MaxValue)
                {
                    break;
                }

                foreach (var neighbour in currentNode.Edges)
                {
                    var potDistance = currentNode.DijkstraDistance + neighbour.Weigth;
                    if (potDistance < neighbour.ToNode.DijkstraDistance)
                    {
                        neighbour.ToNode.DijkstraDistance = potDistance;
                        queue.Enqueue(neighbour.ToNode);
                    }
                }
            }
        }
    }

    public class Node : IComparable
    {
        public Node()
        {
            this.Edges = new List<Edge>();
            this.DijkstraDistance = int.MaxValue;
        }

        public int DijkstraDistance { get; set; }

        public List<Edge> Edges { get; private set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Node))
            {
                return -1;
            }

            return this.DijkstraDistance.CompareTo((obj as Node).DijkstraDistance);
        }
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

    public class PriorityQueue<T> where T : IComparable
    {
        private T[] heap;
        private int index;

        public PriorityQueue()
        {
            this.heap = new T[16];
            this.index = 1;
        }

        public int Count
        {
            get
            {
                return this.index - 1;
            }
        }

        public void Enqueue(T element)
        {
            if (this.index >= this.heap.Length)
            {
                this.IncreaseArray();
            }

            this.heap[this.index] = element;

            int childIndex = this.index;
            int parentIndex = childIndex / 2;
            this.index++;

            while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0) //change to > maxQueue
            {
                T swapValue = this.heap[parentIndex];
                this.heap[parentIndex] = this.heap[childIndex];
                this.heap[childIndex] = swapValue;

                childIndex = parentIndex;
                parentIndex = childIndex / 2;
            }
        }

        public T Dequeue()
        {
            T result = this.heap[1];

            this.heap[1] = this.heap[this.Count];
            this.index--;

            int rootIndex = 1;

            while (true)
            {
                int leftChildIndex = rootIndex * 2;
                int rightChildIndex = (rootIndex * 2) + 1;

                if (leftChildIndex > this.index)
                {
                    break;
                }

                int minChild;
                if (rightChildIndex > this.index)
                {
                    minChild = leftChildIndex;
                }
                else
                {
                    if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0) //change to > maxQueue
                    {
                        minChild = leftChildIndex;
                    }
                    else
                    {
                        minChild = rightChildIndex;
                    }
                }

                if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0) //change to > maxQueue
                {
                    T swapValue = this.heap[rootIndex];
                    this.heap[rootIndex] = this.heap[minChild];
                    this.heap[minChild] = swapValue;

                    rootIndex = minChild;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public T Peek()
        {
            return this.heap[1];
        }

        private void IncreaseArray()
        {
            var copiedHeap = new T[this.heap.Length * 2];

            for (int i = 0; i < this.heap.Length; i++)
            {
                copiedHeap[i] = this.heap[i];
            }

            this.heap = copiedHeap;
        }
    }
}