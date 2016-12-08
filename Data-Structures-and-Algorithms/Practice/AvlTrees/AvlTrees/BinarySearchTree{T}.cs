using System;
using System.Collections;
using System.Collections.Generic;

namespace AvlTrees
{
    public class BinarySearchTree<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private int size;
        private Node<T> root;

        public BinarySearchTree()
        {
            this.size = 0;
            this.root = null;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public bool Contains(T value)
        {
            var node = this.root;

            while (node != null)
            {
                // 0 - equal, -1 - left is smaller, 1 - right is smaller
                int comparisonResult = value.CompareTo(node.Value);

                if (comparisonResult == 0)
                {
                    return true;
                }
                else if (comparisonResult < 0)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }

            return false;
        }

        public void Remove(T value)
        {
            this.root = this.Remove(this.root, value);
        }

        public void Add(T value)
        {
            this.root = this.Add(this.root, value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (this.root != null)
            {
                foreach (var item in this.root)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private Node<T> Add(Node<T> node, T value)
        {
            if (node == null)
            {
                ++this.size;
                node = new Node<T>(value);
                return node;
            }

            // 0 - equal, -1 - left is smaller, 1 - right is smaller
            int comparisonResult = value.CompareTo(node.Value);

            if (comparisonResult == 0)
            {
                // equal elements ignored
                return node;
            }
            else if (comparisonResult < 0)
            {
                node.Left = this.Add(node.Left, value);
            }
            else
            {
                node.Right = this.Add(node.Right, value);
            }

            return node;
        }

        private Node<T> Remove(Node<T> node, T value)
        {
            if (node == null)
            {
                // The value isn't there
                return null;
            }

            // 0 - equal, -1 - left is smaller, 1 - right is smaller
            int comparisonResult = value.CompareTo(node.Value);

            if (comparisonResult == 0)
            {
                --this.size;
                if (node.Right == null)
                {
                    return node.Left;
                }

                if (node.Left == null)
                {
                    return node.Right;
                }

                var parent = node.Right;

                if (parent.Left == null)
                {
                    parent.Left = node.Left;
                    return parent;
                }

                while (parent.Left.Left != null)
                {
                    parent = parent.Left;
                }

                var minimal = parent.Left;
                parent.Left = minimal.Right;

                minimal.Left = node.Left;
                minimal.Right = node.Right;
            }
            else if (comparisonResult < 0)
            {
                node.Left = this.Remove(node.Left, value);
            }
            else
            {
                node.Right = this.Remove(node.Right, value);
            }

            return node;
        }
    }
}
