namespace CompareSortAlgorithms
{
    using System.Collections.Generic;

    internal class SortDoubleComparer : IComparer<double>
    {
        public int Compare(double x, double y)
        {
            if (x == y)
            {
                return 0;
            }

            return x < y ? 1 : -1;
        }
    }
}
