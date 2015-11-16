// This code is distributed under MIT license. Copyright (c) 2013 George Mamaladze
// See license.txt or http://opensource.org/licenses/mit-license.php
namespace FindSetOfWords.Models
{
    using System.Collections.Generic;
    
    using FindSetOfWords.Contracts;

    public class ConcurrentTrie<TValue> : ConcurrentTrieNode<TValue>, ITrie<TValue>
    {
        public IEnumerable<TValue> Retrieve(string query)
        {
            return base.Retrieve(query, 0);
        }

        public void Add(string key, TValue value)
        {
            base.Add(key, 0, value);
        }
    }
}