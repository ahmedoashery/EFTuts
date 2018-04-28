using System.Collections.Generic;
using System.Linq;
using EFTuts.Data.Repository.Core;
using EFTuts.Data.Repository.Domain;
using EFTuts.Data.Repository.UnitOfWork;

namespace EFTuts.Data.Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        
        public UserRepository(DataContext context) : base(context)
        {

        }

        public DataContext DataContext
        {
            get
            {
                return Context as DataContext;
            }
        }

        public User User(int id = 0)
        {
            return DataContext.Users.Find(id);
        }

        public IEnumerable<User> Users()
        {
            return DataContext.Users.ToList();
        }
    }
}