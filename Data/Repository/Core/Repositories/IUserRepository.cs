using EFTuts.Data.Repository.Domain;
using System.Collections.Generic;

namespace EFTuts.Data.Repository.Core.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int UserID = 0);
        IEnumerable<User> GetUsers();
    }
}