namespace CompanyArticles
{
    using System;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var orderedDictionary = new OrderedMultiDictionary<decimal, Article>(true);
            var randomGenerator = new Random();

            for (int i = 0; i < 1000000; i++)
            {
                var price = (decimal)randomGenerator.Next() % 10;
                var article  = new Article
                {
                    Title = string.Format("Some Title: {0}", i),
                    Vendor = string.Format("Some Vendor: {0}", i),
                    Price = price,
                    Barcode = "Some barcode"
                };
                orderedDictionary.Add(price, article);
            }

            orderedDictionary.Range(5m, true, 9m, true)
                             .ForEach(x => 
                             {
                                 Console.WriteLine(x.Key);
                                 foreach (var item in x.Value)
                                 {
                                     Console.WriteLine(string.Format("Article Title: {0}, Article price: {1}", item.Title, item.Price));
                                 }
                             });
        }
    }
}