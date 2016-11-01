using System.Collections.Generic;
using System.Data.Entity;
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
            var cutomers = this.context.Customers;
            return cutomers;
        }
    }
}
