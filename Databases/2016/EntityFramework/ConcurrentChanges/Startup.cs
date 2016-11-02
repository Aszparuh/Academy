using System;
using System.Linq;
using Northwind.Data;
using System.Data.Entity;

namespace ConcurrentChanges
{
    public class Startup
    {
        public static void Main()
        {
            var context = new NorthwindEntities();
            var secondContext = new NorthwindEntities();

            using (context)
            {
                using (secondContext)
                {
                    var order = context.Orders.FirstOrDefault();
                    Console.WriteLine(order.ShipCity);
                    order.ShipCity = "Some city";
                    context.Entry(order).State = EntityState.Modified;

                    var sameOrder = secondContext.Orders.FirstOrDefault();
                    Console.WriteLine(sameOrder.ShipCity);
                    sameOrder.ShipCity = "Some other city";
                    secondContext.Entry(order).State = EntityState.Modified;

                    //concurrency exception
                    secondContext.SaveChanges();
                    context.SaveChanges();
                }
            }
        }
    }
}
