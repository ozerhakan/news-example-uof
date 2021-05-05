using System;
using System.Threading.Tasks;
using NEWS.Interface.Repositories;

namespace NEWS.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        INewsRepository NewsRepository { get; }
        Task<bool> Commit();
    }
}