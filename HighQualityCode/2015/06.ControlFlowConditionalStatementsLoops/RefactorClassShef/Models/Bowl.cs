namespace RefactorClassShef.Models
{
    using System.Collections.Generic;

    public class Bowl
    {
        private List<Vegetable> allProducts;

        public Bowl()
        {
            this.allProducts = new List<Vegetable>();
        }

        public List<Vegetable> GetProducts()
        {
            return this.allProducts;
        }

        public void Add(Vegetable vegetable)
        {
            this.allProducts.Add(vegetable);
        }

        public override string ToString()
        {
            string productsAsString = string.Join(",", this.allProducts);
            return productsAsString;
        }
    }
}