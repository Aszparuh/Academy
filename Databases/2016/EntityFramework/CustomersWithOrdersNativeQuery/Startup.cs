using Northwind.Data;
using System;
using System.Data.Entity;

namespace CustomersWithOrdersNativeQuery
{
    public class Startup
    {
        static void Main()
        {
            var context = new NorthwindEntities();
            using (context)
            {
                string nativeSqlQuery =
                "SELECT * FROM dbo.Orders o " +
                "JOIN dbo.Customers c " +
                "ON o.CustomerID = c.CustomerID " +
                "WHERE (OrderDate BETWEEN '1997.01.01' AND '1997.12.31') AND ShipCountry = 'Canada' " +
                "ORDER BY c.CompanyName";

                var customers = context.Database.SqlQuery<Customer>(nativeSqlQuery);

                foreach (var item in customers)
                {
                    Console.WriteLine(string.Format("Company: {0}, CompanyContact: {1}", item.CompanyName, item.ContactName));
                }
            }
        }
    }
}
