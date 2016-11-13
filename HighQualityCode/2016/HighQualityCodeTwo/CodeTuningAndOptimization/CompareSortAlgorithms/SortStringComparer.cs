using System.Collections.Generic;

namespace CompareSortAlgorithms
{
    internal class SortStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(y, x);
        }
    }
}
