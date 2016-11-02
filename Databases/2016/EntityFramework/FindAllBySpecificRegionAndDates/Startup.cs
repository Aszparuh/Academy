using Northwind.Data;
using System;
using System.Linq;

namespace FindAllBySpecificRegionAndDates
{
    public class Startup
    {
        public static void Main()
        {
            FindAll("OR", new DateTime(1997, 1, 1), new DateTime(2000, 1, 1));
        }

        public static void FindAll(string region, DateTime startDate, DateTime endDate)
        {
            var context = new NorthwindEntities();
            using (context)
            {
                var sales = context
                .Order_Details
                .Where(o => o.Order.ShipRegion == region)
                .Where(o => o.Order.OrderDate >= startDate)
                .Where(o => o.Order.OrderDate <= endDate)
                .Select(c => new
                {
                    Customer = c.Order.Customer.CompanyName,
                    Date = c.Order.OrderDate,
                    Product = c.Product.ProductName
                })
                .ToList();

                foreach (var item in sales)
                {
                    Console.WriteLine($"Customer:{item.Customer} , OrderDate:{item.Date}, Product:{item.Product}");
                }
            }
        }
    }
}
