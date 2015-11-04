namespace Tree
{
    using System.Collections.Generic;

    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Parent { get; set; }

        public List<Node<T>> Children { get; set; }

        public Node(T value)
        {
            this.Children = new List<Node<T>>();
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}