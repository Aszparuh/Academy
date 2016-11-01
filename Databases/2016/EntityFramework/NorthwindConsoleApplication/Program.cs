using DataAccessObjectCustomers;
using Northwind.Data;

namespace NorthwindConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            var context = new CustomersDAO(new NorthwindEntities());
            var customers = context.GetAll();
            foreach (var customer in customers)
            {
                System.Console.WriteLine(customer.ContactName);
            }
        }
    }
}
