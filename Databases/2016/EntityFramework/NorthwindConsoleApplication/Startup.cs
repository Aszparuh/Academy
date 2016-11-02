using System;
using System.Data.Entity.Validation;
using System.Linq;
using DataAccessObjectCustomers;
using Northwind.Data;

namespace NorthwindConsoleApplication
{
    public class Startup
    {
        public static void Main()
        {
            var context = new NorthwindEntities();
            var customersDb = new CustomersDAO(context);
            var customers = customersDb.GetAll();
            

            var newCustomer = new Customer()
            {
                CustomerID = "22222",
                CompanyName = "Компания",
                ContactName = "Иван Петров",
                ContactTitle = "Г-н",
                Address = "Някакъв адрес",
                City = "Пловдив",
                Region = "Регион",
                PostalCode = "4024",
                Country = "България",
                Phone = "2222222222",
                Fax = "222222222"
            };

            try
            {
                customersDb.InsertCustomer(newCustomer);
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

            var customer = customersDb.GetAll().Where(c => c.CustomerID == "22222").Single();
            customer.ContactTitle = "Чистач";
            customersDb.ModifyCustomer(customer);
        }
    }
}
