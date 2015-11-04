namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;

    using Tree;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine("Enter the input: ");
            var numberOfNodes = int.Parse(Console.ReadLine());
            var treeCollection = new Dictionary<int, Node<int>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    break;
                }
                else
                {
                    string[] childParentValues = inputLine.Split(' ');
                    int parent = int.Parse(childParentValues[0]);
                    int child = int.Parse(childParentValues[1]);

                    if (treeCollection.ContainsKey(parent))
                    {
                        var childNode = new Node<int>(child);
                        childNode.Parent = treeCollection[parent];
                        treeCollection[child] = childNode;
                    }
                    else
                    {
                        var childNode = new Node<int>(child);
                        var parentNode = new Node<int>(parent);
                        parentNode.Children.Add(childNode);
                        childNode.Parent = parentNode;
                        treeCollection[parent] = parentNode;
                        treeCollection[child] = childNode;
                    }
                }
            }

            ///Console.WriteLine(treeCollection.Count);
        }
    }
}