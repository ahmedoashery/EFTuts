using EFTuts.Data.Repository.Domain;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EFTuts.Data.Repository.Core
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer CustomerById(int id = 0);
        IEnumerable<Customer> CustomersList();

        ObservableCollection<Customer> CustomersObser();
    }
}