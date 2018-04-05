using EFTuts.Data.Repository.Domain;
using System.Collections.Generic;

namespace EFTuts.Data.Repository.Core.Repositories
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        Customer GetCustomer(int CustomerID = 0);
        IEnumerable<Customer> GetCustomers();
    }
}