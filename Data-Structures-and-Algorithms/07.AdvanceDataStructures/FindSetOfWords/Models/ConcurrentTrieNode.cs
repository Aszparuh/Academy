// This code is distributed under MIT license. Copyright (c) 2013 George Mamaladze
// See license.txt or http://opensource.org/licenses/mit-license.php
namespace FindSetOfWords.Models
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public class ConcurrentTrieNode<TValue> : TrieNodeBase<TValue>
    {
        private readonly ConcurrentDictionary<char, ConcurrentTrieNode<TValue>> mChildren;
        private readonly ConcurrentQueue<TValue> mValues;

        public ConcurrentTrieNode()
        {
            this.mChildren = new ConcurrentDictionary<char, ConcurrentTrieNode<TValue>>();
            this.mValues = new ConcurrentQueue<TValue>();
        }

        protected override int KeyLength
        {
            get { return 1; }
        }

        protected override IEnumerable<TValue> Values()
        {
            return mValues;
        }

        protected override IEnumerable<TrieNodeBase<TValue>> Children()
        {
            return mChildren.Values;
        }

        protected override void AddValue(TValue value)
        {
            mValues.Enqueue(value);
        }

        protected override TrieNodeBase<TValue> GetOrCreateChild(char key)
        {
            return mChildren.GetOrAdd(key, new ConcurrentTrieNode<TValue>());
        }

        protected override TrieNodeBase<TValue> GetChildOrNull(string query, int position)
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }

            ConcurrentTrieNode<TValue> childNode;
            return
                mChildren.TryGetValue(query[position], out childNode)
                    ? childNode
                    : null;
        }
    }
}