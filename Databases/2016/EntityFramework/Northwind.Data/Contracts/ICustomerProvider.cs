using System.Data.Entity;

namespace Northwind.Data.Contracts
{
    public interface ICustomerProvider
    {
        DbSet<Customer> Customers { get; }
    }
}
