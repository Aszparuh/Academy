namespace IEnumerableExtensions.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.CSharp.RuntimeBinder;

    public static class Extensions
    {
        public static dynamic Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = default(T);
            try
            {
                foreach (var item in collection)
                {
                    sum += item;
                }
            }
            catch (FormatException)
            {
                throw new ArgumentException("Non-numerical elements found in collection.");
            }
            catch (RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return sum;
        } 
 
        public static dynamic Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = default(T);
            try
            {
                foreach (var item in collection)
                {
                    product *= item;
                }
            }
            catch (FormatException)
            {
                throw new ArgumentException("Non-numerical elements found in collection.");
            }
            catch (RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return product;
        }

        public static dynamic Average<T>(this IEnumerable<T> collection)
        {
            dynamic sum = default(T);
            double count = 0;

            try
            {
                foreach (var item in collection)
                {
                    sum += item;
                    count++;
                }

                return sum / count;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Non-numerical elements found in collection.");
            }
            catch (RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return "error";
        }  

        public static decimal Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            decimal min = decimal.MaxValue;

            try
            {
                foreach (var item in collection)
                {
                    if (min > Convert.ToDecimal(item))
                    {
                        min = Convert.ToDecimal(item);
                    }
                }

                return min;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Non-numerical elements found in collection.");
            }
        }

        public static decimal Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            decimal max = decimal.MinValue;

            try
            {
                foreach (var item in collection)
                {
                    if (max < Convert.ToDecimal(item))
                    {
                        max = Convert.ToDecimal(item);
                    }
                }

                return max;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Non-numerical elements found in collection.");
            }
        }
    }
}