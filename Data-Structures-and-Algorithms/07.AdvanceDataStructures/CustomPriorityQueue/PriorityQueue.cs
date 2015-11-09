namespace CustomPriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<TPriority, TValue>
    {
        private List<KeyValuePair<TPriority, TValue>> heapBase;
        private IComparer<TPriority> comparer;

        public PriorityQueue(IComparer<TPriority> comparer)
        {
            this.Comparer = comparer;
        }

        public IComparer<TPriority> Comparer 
        { 
            get; 
            private set
            {
                if (comparer == null)
                {
                    throw new ArgumentException("Comparer cannot be null");
                }
            }
        }
    }
}