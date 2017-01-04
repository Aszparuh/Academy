using System;
using System.Collections.Generic;
using System.Linq;

namespace Labyrinth3D
{
    public class Startup
    {
        private static char[,,] matrix;
        private static bool[,,] visited;

        public static void Main()
        {
            var startingPosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var x = startingPosition[0];
            var y = startingPosition[1];
            var z = startingPosition[2];

            var matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var levels = matrixDimensions[0];
            var rows = matrixDimensions[1];
            var columns = matrixDimensions[2];

            matrix = new char[levels, rows, columns];
            visited = new bool[levels, rows, columns];

            for (int level = 0; level < levels; level++)
            {
                for (int row = 0; row < rows; row++)
                {
                    var line = Console.ReadLine();
                    for (int column = 0; column < line.Length; column++)
                    {
                        if (line[column] == '#')
                        {
                            visited[level, row, column] = true;
                        }

                        matrix[level, row, column] = line[column];
                    }
                }
            }

            BFS(new Position(x, y, z, 0));
        }

        public static void BFS(Position position)
        {
            var queue = new Queue<Position>();
            queue.Enqueue(position);
            visited[position.Level, position.Row, position.Column] = true;

            while (queue.Count > 0)
            {
                var pos = queue.Dequeue();

                //Left
                if (pos.Column > 0)
                {
                    if (visited[pos.Level, pos.Row, pos.Column - 1] == false)
                    {
                        var newPos = new Position(pos.Level, pos.Row, pos.Column - 1, pos.BfsLevel + 1);
                        queue.Enqueue(newPos);
                        visited[pos.Level, pos.Row, pos.Column - 1] = true;
                    }
                }

                //Right
                if (pos.Column < matrix.GetLength(2) - 1)
                {
                    if (visited[pos.Level, pos.Row, pos.Column + 1] == false)
                    {
                        var newPos = new Position(pos.Level, pos.Row, pos.Column + 1, pos.BfsLevel + 1);
                        queue.Enqueue(newPos);
                        visited[pos.Level, pos.Row, pos.Column + 1] = true;
                    }
                }

                //Front
                if (pos.Row > 0)
                {
                    if (visited[pos.Level, pos.Row - 1, pos.Column] == false)
                    {
                        var newPos = new Position(pos.Level, pos.Row - 1, pos.Column, pos.BfsLevel + 1);
                        queue.Enqueue(newPos);
                        visited[pos.Level, pos.Row - 1, pos.Column] = true;
                    }
                }

                //Back
                if (pos.Row < matrix.GetLength(1) - 1)
                {
                    if (visited[pos.Level, pos.Row + 1, pos.Column] == false)
                    {
                        var newPos = new Position(pos.Level, pos.Row + 1, pos.Column, pos.BfsLevel + 1);
                        queue.Enqueue(newPos);
                        visited[pos.Level, pos.Row + 1, pos.Column] = true;
                    }
                }

                //Up
                if (matrix[pos.Level, pos.Row, pos.Column] == 'U')
                {
                    if (pos.Level == matrix.GetLength(0) - 1)
                    {
                        Console.WriteLine(pos.BfsLevel + 1);
                        return;
                    }
                    else
                    {
                        if (visited[pos.Level + 1, pos.Row, pos.Column] == false)
                        {
                            var newPos = new Position(pos.Level + 1, pos.Row, pos.Column, pos.BfsLevel + 1);
                            queue.Enqueue(newPos);
                            visited[pos.Level + 1, pos.Row, pos.Column] = true;
                        }
                    }
                }

                //Down
                if (matrix[pos.Level, pos.Row, pos.Column] == 'D')
                {
                    if (pos.Level == 0)
                    {
                        Console.WriteLine(pos.BfsLevel + 1);
                        return;
                    }
                    else
                    {
                        if (visited[pos.Level - 1, pos.Row, pos.Column] == false)
                        {
                            var newPos = new Position(pos.Level - 1, pos.Row, pos.Column, pos.BfsLevel + 1);
                            queue.Enqueue(newPos);
                            visited[pos.Level - 1, pos.Row, pos.Column] = true;
                        }
                    }
                }
            }
        }
    }

    public class Position
    {
        public Position(int level, int row, int column, int bfsLevel)
        {
            this.Level = level;
            this.Row = row;
            this.Column = column;
            this.BfsLevel = bfsLevel;
        }

        public int Level { get; private set; }

        public int Row { get; private set; }

        public int Column { get; private set; }

        public int BfsLevel { get; private set; }
    }
}
