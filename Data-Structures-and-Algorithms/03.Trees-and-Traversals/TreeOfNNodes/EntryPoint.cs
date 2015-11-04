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
            var treeList = new Dictionary<int, Node<int>>();
            
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    break;
                }
                else
                {
                    var parentAndChild = inputLine.Split(' ');
                    if (parentAndChild.Length == 1)
                    {
                        var nodeValue = int.Parse(parentAndChild[0]);
                        treeList.Add(nodeValue, new Node<int>(nodeValue));
                    }
                    else
                    {
                        var parentNodeValue = int.Parse(parentAndChild[0]);
                        var childNodeValue = int.Parse(parentAndChild[1]);

                        if (treeList.ContainsKey(parentNodeValue))
                        {
                            var childNode = new Node<int>(childNodeValue);
                            childNode.Parent = treeList[parentNodeValue];
                            treeList[childNode.Value] = childNode; 
                            treeList[parentNodeValue].Children.Add(childNode);
                        }
                        else
                        {
                            var parentNode = new Node<int>(parentNodeValue);
                            var childNode = new Node<int>(childNodeValue);

                            parentNode.Children.Add(childNode);
                            childNode.Parent = parentNode;

                            treeList[parentNode.Value] = parentNode;
                            treeList[childNode.Value] = childNode;
                        }
                    }
                }
            }

            ///Find the root of the tree;
            foreach (var element in treeList)
            {
                if (element.Value.Parent == null)
                {
                    Console.WriteLine("The root is: {0}", element.Value.Value);
                }
            }
        }
    }
}