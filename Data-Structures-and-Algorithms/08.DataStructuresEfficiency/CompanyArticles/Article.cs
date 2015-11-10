namespace CompanyArticles
{
    using System;

    public class Article : IComparable
    {
        public string Title { get; set; }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Article otherArticle = obj as Article;
            if (otherArticle != null)
                return this.Price.CompareTo(otherArticle.Price);
            else
                throw new ArgumentException("Object is not a Article");
        }
    }
}