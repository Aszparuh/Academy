﻿namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenList<T> where T : IComparable
    {
        const int initialCapacity = 8;
        private int index;
        private T[] data;

        public GenList() : this(initialCapacity)
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

        public int Length()
        {
            return this.index;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.index)
            {
                throw new IndexOutOfRangeException("Index is not valid for the current array.");
            }

            var res = this.data;
            for (int i = index; i < this.data.Length - 1; i++)
            {
                res[i] = this.data[i + 1];
            }

            this.index--;
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index > this.index)
            {
                throw new IndexOutOfRangeException("Index is not valid for the current array");
            }

            if (index == this.index)
            {
                this.Add(element);
                return;
            }

            for (int i = this.index; i > index; i--)
            {
                this.data[i] = this.data[i - 1];
            }

            this.data[index] = element;
            this.index++;
        }

        public void Clear()
        {
            this.data = new T[initialCapacity];
            this.index = 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        private void Extend()
        {
            var newArr = new T[this.data.Length * 2];
            Array.Copy(this.data, newArr, this.data.Length);
            this.data = newArr;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.index; i++)
            {
                sb.Append(this.data[i]);
                if (i < this.index - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        public T Min()
        {
            T min = this.data[0];
            for (int i = 0; i < this.index; i++)
            {
                if (this.data[i].CompareTo(min) < 0)
                {
                    min = this.data[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.data[0];
            for (int i = 0; i < this.index; i++)
            {
                if (this.data[i].CompareTo(max) > 0)
                {
                    max = this.data[i];
                }
            }

            return max;
        }
    }
}