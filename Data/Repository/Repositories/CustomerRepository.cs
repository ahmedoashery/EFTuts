using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EFTuts.Data.Repository.Core;
using EFTuts.Data.Repository.Domain;
using EFTuts.Data.Repository.UnitOfWork;

namespace EFTuts.Data.Repository.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public DataContext DataContext {  get { return Context as DataContext; } }

        public CustomerRepository(DataContext context) : base(context)
        {
            
        }

        public Customer CustomerById(int id = 0)
        {
            return DataContext.Customers.Find(id);
        }

        public IEnumerable<Customer> CustomersList()
        {
            return DataContext.Customers.ToList();
        }

        public ObservableCollection<Customer> CustomersObser()
        {
            return DataContext.Customers.Local;
        }
    }
}