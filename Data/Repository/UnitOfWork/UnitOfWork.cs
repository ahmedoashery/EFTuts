using EFTuts.Data.Repository.Core;
using EFTuts.Data.Repository.Repositories;

namespace EFTuts.Data.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext context)
        {
            _dataContext = context;

            Customers = new CustomerRepository(_dataContext);
            Users = new UserRepository(_dataContext);
        }

        public ICustomerRepository Courses { get; private set; }

        public IUserRepository Users { get; private set; }

        public ICustomerRepository Customers { get; set; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}