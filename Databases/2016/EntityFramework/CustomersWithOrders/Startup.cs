using System;
using System.Linq;
using Northwind.Data;

namespace CustomersWithOrders
{
    public class Startup
    {
        public static void Main()
        {
            var context = new NorthwindEntities();

            using (context)
            {
                var customers = context.Orders
                    .Where(order => order.OrderDate.Value.Year == 1997 && order.ShipCountry == "Canada")
                    .Select(c => new
                    {
                        ContactName = c.Customer.ContactName,
                        ContactCompany = c.Customer.ContactName
                    })
                    .Distinct()
                    .ToArray();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.ContactName} - {customer.ContactCompany}");
                }
            }          
        }
    }
}
