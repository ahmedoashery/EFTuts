using EFTuts.Data.Repository.Core;
using EFTuts.Data.Repository.Core.Repositories;
using EFTuts.Data.Repository.Domain;
using EFTuts.Data.Repository.UnitOfWork;

namespace EFTuts.Data.Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
    }
}