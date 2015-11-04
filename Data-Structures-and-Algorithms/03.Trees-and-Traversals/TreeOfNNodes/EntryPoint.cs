namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;

    using Tree;

    public class EntryPoint
    {
        private static int longestPath;

        private static Node<int> GetRoot(Dictionary<int, Node<int>> tree)
        {
            foreach (var element in tree)
            {
                if (element.Value.Parent == null)
                {
                    return element.Value;
                }
            }

            throw new ArgumentException("Root is missing");
        }

        private static void GetAllLeaves(Node<int> node, List<int> listOfLeaves)
        {
            if (node.Children.Count == 0)
            {
                listOfLeaves.Add(node.Value);
            }

            foreach (var child in node.Children)
            {
                GetAllLeaves(child, listOfLeaves);
            }
        }

        private static void GetAllMiddleLeaves(Node<int> node, List<int> listOfLeaves)
        {
            if (node.Children.Count != 0 && node.Parent != null)
            {
                listOfLeaves.Add(node.Value);
            }

            foreach (var child in node.Children)
            {
                GetAllMiddleLeaves(child, listOfLeaves);
            }
        }

        private static void CalculateLongestPath(Node<int> node, int path)
        {
            path++;
            foreach (var child in node.Children)
            {
                CalculateLongestPath(child, path);
            }

            if (path > longestPath)
            {
                longestPath = path;
            }

        }
        
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
                        Node<int> childNode;
                        if (treeCollection.ContainsKey(child))
                        {
                            childNode = treeCollection[child];
                        }
                        else
                        {
                            childNode = new Node<int>(child);
                        }
                        
                        childNode.Parent = treeCollection[parent];
                        treeCollection[parent].Children.Add(childNode);
                        treeCollection[child] = childNode;
                    }
                    
                    else
                    {
                        Node<int> childNode;
                        if (treeCollection.ContainsKey(child))
                        {
                            childNode = treeCollection[child];
                        }
                        else
                        {
                            childNode = new Node<int>(child);
                        }
                      
                        var parentNode = new Node<int>(parent);
                        treeCollection[parent] = parentNode;
                        treeCollection[parent].Children.Add(childNode);
                        treeCollection[child] = childNode;
                        treeCollection[child].Parent = treeCollection[parent];
                    }
                }
            }

            var root = GetRoot(treeCollection);
           // Console.WriteLine("The root is {0}", root.Value);

            //var allLeaves = new List<int>();
            //var allMiddleLeaves = new List<int>();
            //GetAllLeaves(root, allLeaves);
            //Console.Write("All Leaves: ");
            //Console.WriteLine(string.Join(" ,", allLeaves));
            //Console.Write("All middle leaves: ");
            //GetAllMiddleLeaves(root, allMiddleLeaves);
            //Console.WriteLine(string.Join(" ,", allMiddleLeaves));
            CalculateLongestPath(root, 0);
            Console.WriteLine("The longest path is {0}", longestPath);
        }
    }
}