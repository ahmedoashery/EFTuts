using EFTuts.Data.Repository.Domain;
using System.Collections.Generic;

namespace EFTuts.Data.Repository.Core
{
    public interface IUserRepository
    {
        User User(int id = 0);
        IEnumerable<User> Users();
    }
}