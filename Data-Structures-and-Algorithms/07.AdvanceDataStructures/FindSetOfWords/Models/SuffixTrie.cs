// This code is distributed under MIT license. Copyright (c) 2013 George Mamaladze
// See license.txt or http://opensource.org/licenses/mit-license.php
namespace FindSetOfWords.Models
{
    using System.Collections.Generic;
    using System.Linq;
    
    using FindSetOfWords.Contracts;

    public class SuffixTrie<T> : ITrie<T>
    {
        private readonly Trie<T> mInnerTrie;
        private readonly int mMinSuffixLength;

        public SuffixTrie(int minSuffixLength)
            : this(new Trie<T>(), minSuffixLength)
        {
        }

        private SuffixTrie(Trie<T> innerTrie, int minSuffixLength)
        {
            this.mInnerTrie = innerTrie;
            this.mMinSuffixLength = minSuffixLength;
        }

        public IEnumerable<T> Retrieve(string query)
        {
            return
                this.mInnerTrie
                    .Retrieve(query)
                    .Distinct();
        }

        public void Add(string key, T value)
        {
            foreach (string suffix in GetAllSuffixes(this.mMinSuffixLength, key))
            {
                this.mInnerTrie.Add(suffix, value);
            }
        }

        private static IEnumerable<string> GetAllSuffixes(int minSuffixLength, string word)
        {
            for (int i = word.Length - minSuffixLength; i >= 0; i--)
            {
                var partition = new StringPartition(word, i);
                yield return partition.ToString();
            }
        }
    }
}