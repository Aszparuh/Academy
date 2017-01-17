using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guards
{
    class Program
    {
        public static int[,] matrix;
        public static int[,] pathMatrix;

        static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = rowsCols[0];
            var cols = rowsCols[1];
            matrix = new int[rows, cols];
            pathMatrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 1;
                }
            }

            var numberOfGuards = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfGuards; i++)
            {
                var line = Console.ReadLine().Split(' ').ToArray();
                var enRow = int.Parse(line[0]);
                var enCol = int.Parse(line[1]);
                var direction = line[2];

                matrix[enRow, enCol] = -1;
                switch (direction)
                {
                    case "U":
                        matrix[enRow + 1, enCol] = 3;
                        break;
                    case "R":
                        matrix[enRow, enCol + 1] = 3;
                        break;
                    case "D":
                        matrix[enRow - 1, enCol] = 3;
                        break;
                    case "L":
                        matrix[enRow, enCol - 1] = 3;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }

            BuildPathWeights();

            Print(matrix);
            Console.WriteLine();
            Print(pathMatrix);
            Console.WriteLine();
        }

        private static void BuildPathWeights()
        {
            var first = matrix[0, 0];


        }

        private static void Print(int[,] matrixP)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrixP[i, j]);
                    Console.Write("  ");
                }

                Console.WriteLine();
            }
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

                while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
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
                        if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                        {
                            minChild = leftChildIndex;
                        }
                        else
                        {
                            minChild = rightChildIndex;
                        }
                    }

                    if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
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
}
