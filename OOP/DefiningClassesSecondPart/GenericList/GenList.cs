namespace GenericList
{
    using System;
    using System.Collections.Generic;

    public class GenList<T>
    {
        private int index;
        private T[] data;

        public GenList() : this(8)
        {

        }

        public GenList(int initialCapacity)
        {
            if (initialCapacity < 1)
            {
                throw new ArgumentException("Capacity should be possitive number.");
            }

            this.data = new T[initialCapacity];
            index = 0;
        }

        public void Add(T element)
        {
            if (index == this.data.Length)
            {
                Extend();
            }

            this.data[index] = element;
            index++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.index)
            {
                throw new IndexOutOfRangeException("Index is not valid for the current array.");
            }


        }

        public T this[int index]
        {
            get 
            {
                if (index < 0 || index > this.index)
                {
                    throw new IndexOutOfRangeException("Index is not valid for the current array");
                }
                
                return this.data[index];
            }
        }

        private void Extend()
        {
            var newArr = new T[this.data.Length * 2];
            Array.Copy(this.data, newArr, this.data.Length);
            this.data = newArr;
        }
    }
}