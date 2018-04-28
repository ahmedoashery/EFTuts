using EFTuts.Data.Repository.Core;
using System;

namespace EFTuts.Data.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IUserRepository Users { get; }
        int Complete();
    }
}