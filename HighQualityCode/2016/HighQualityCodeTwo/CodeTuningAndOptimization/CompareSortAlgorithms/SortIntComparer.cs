namespace CompareSortAlgorithms
{
    using System.Collections.Generic;

    internal class SortIntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }

            return x < y ? 1 : -1;
        }
    }
}
