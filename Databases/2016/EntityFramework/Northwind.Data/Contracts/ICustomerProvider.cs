using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Northwind.Data.Contracts
{
    public interface ICustomerProvider
    {
        DbSet<Customer> Customers { get; }

        int SaveChanges();

        DbEntityEntry Entry(object entity);
    }
}
