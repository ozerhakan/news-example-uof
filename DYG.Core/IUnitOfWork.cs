using System;
using System.Threading.Tasks;
using DYG.Core.Repositories;

namespace DYG.Core
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}