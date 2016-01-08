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
            this.heapBase = new List<KeyValuePair<TPriority, TValue>>();
        }

        public PriorityQueue()
            : this(Comparer<TPriority>.Default)
        {
        }    

        private IComparer<TPriority> Comparer 
        { 
            get
            {
                return this.comparer;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Comparer cannot be null");
                }

                this.comparer = value;
            }
        }

        public void Enqueue(TPriority priority, TValue value)
        {
            var newElement = new KeyValuePair<TPriority, TValue>(priority, value);
            this.heapBase.Add(newElement);
            this.HeapifyFromEndToBeginning(this.heapBase.Count - 1);
        }

        public KeyValuePair<TPriority, TValue> Dequeue()
        {
            if (this.heapBase.Count == 0)
            {
                throw new ArgumentException("The queue is empty");
            }
            else
            {
                var result = this.heapBase[0];
                this.DeleteRoot();
                return result;
            }
        }

        private void ExchangeElements(int firstPosition, int secondPosition)
        {
            var temp = this.heapBase[firstPosition];
            this.heapBase[firstPosition] = this.heapBase[secondPosition];
            this.heapBase[secondPosition] = temp;
        }

        private void HeapifyFromBeginningToEnd(int position)
        {
            if (position >= this.heapBase.Count)
            {
                return;
            }
            else
            {
                while (true)
                {
                    int smallestPosition = position;
                    int leftChildPosition = (2 * position) + 1;
                    int rightChildPosition = (2 * position) + 2;
                    bool isLeftInRange = leftChildPosition < this.heapBase.Count;
                    bool isRightInRange = rightChildPosition < this.heapBase.Count; 

                    if (isLeftInRange && this.comparer.Compare(this.heapBase[smallestPosition].Key, this.heapBase[leftChildPosition].Key) > 0)
                    {
                        smallestPosition = leftChildPosition;
                    }

                    if (isRightInRange && this.comparer.Compare(this.heapBase[smallestPosition].Key, this.heapBase[rightChildPosition].Key) > 0)
                    {
                        smallestPosition = rightChildPosition;
                    }

                    if (smallestPosition != position)
                    {
                        this.ExchangeElements(smallestPosition, position);
                        position = smallestPosition;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void HeapifyFromEndToBeginning(int position)
        {
            if (position >= this.heapBase.Count)
            {
                return;
            }
            else
            {
                while (position > 0)
                {
                    int parentPosition = (position - 1) / 2;
                    bool isParentGreater = this.comparer.Compare(this.heapBase[parentPosition].Key, this.heapBase[position].Key) > 0;
                    if (isParentGreater)
                    {
                        this.ExchangeElements(parentPosition, position);
                        position = parentPosition;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void DeleteRoot()
        {
            if (this.heapBase.Count <= 1)
            {
                this.heapBase.Clear();
                return;
            }

            this.heapBase[0] = this.heapBase[this.heapBase.Count - 1];
            this.heapBase.RemoveAt(this.heapBase.Count - 1);

            this.HeapifyFromBeginningToEnd(0);
        }
    }
}