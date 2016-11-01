using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Northwind.Data;
using Northwind.Data.Contracts;

namespace DataAccessObjectCustomers
{
    public class CustomersDAO
    {
        private readonly ICustomerProvider context;

        public CustomersDAO(ICustomerProvider context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            var cutomers = this.context.Customers.ToArray();
            return cutomers;
        }

        public void InsertCustomer(Customer customer)
        {
            this.context.Customers.Add(customer);
            this.context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            DbEntityEntry entry = this.context.Entry(customer);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.context.Customers.Attach(customer);
                this.context.Customers.Remove(customer);
            }

            this.context.SaveChanges();
        }

        public void ModifyCustomer(Customer customer)
        {
            var entry = this.context.Entry(customer);
            if (entry.State == EntityState.Detached)
            {
                this.context.Customers.Attach(customer);
            }

            entry.State = EntityState.Modified;
            this.context.SaveChanges();
        }
    }
}
