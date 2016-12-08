using System;
using System.Collections;
using System.Collections.Generic;

namespace AvlTrees
{
    public class Node<K> : IEnumerable<K>
    {
        public Node(K value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }

        public K Value { get; set; }

        public Node<K> Left { get; set; }

        public Node<K> Right { get; set; }

        public IEnumerator<K> GetEnumerator()
        {
            if (this.Left != null)
            {
                foreach (var item in this.Left)
                {
                    yield return item;
                }
            }

            yield return this.Value;

            if (this.Right != null)
            {
                foreach (var item in this.Right)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
