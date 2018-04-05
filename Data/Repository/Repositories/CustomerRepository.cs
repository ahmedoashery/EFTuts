using System.Collections.Generic;
using EFTuts.Data.Repository.Core;
using EFTuts.Data.Repository.Core.Repositories;
using EFTuts.Data.Repository.Domain;
using EFTuts.Data.Repository.UnitOfWork;

namespace EFTuts.Data.Repository.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public DataContext DataContext
        {
            get
            {
                return Context as DataContext;
            }
        }
        public CustomerRepository(DataContext context)
            :base(context)
        {
            
        }

        Customer ICustomerRepository.GetCustomer(int CustomerID)
        {
            return DataContext.Customers.Find(CustomerID);
        }

        IEnumerable<Customer> ICustomerRepository.GetCustomers()
        {
            return null;
        }
    }
}