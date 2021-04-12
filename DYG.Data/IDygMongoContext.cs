using System;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DYG.Data.Repositories
{
    public interface IDygMongoContext : IDisposable
    {
        void AddCommand(Func<Task> func);
        Task<int> SaveChanges();
        IMongoCollection<T> GetCollection<T>(string name);
    }
}