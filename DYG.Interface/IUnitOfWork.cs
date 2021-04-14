using System;
using System.Threading.Tasks;
using DYG.Interface.Repositories;

namespace DYG.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        INewsRepository NewsRepository { get; }
        Task<bool> Commit();
    }
}