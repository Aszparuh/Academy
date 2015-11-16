namespace Products
{
    using System;

    public class Product : IComparable<Product>
    {
        public int Price { get; set; }

        public string Name { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}