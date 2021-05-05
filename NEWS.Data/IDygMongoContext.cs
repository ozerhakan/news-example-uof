using System;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace NEWS.Data.Repositories
{
    public interface INEWSMongoContext : IDisposable
    {
        void AddCommand(Func<Task> func);
        Task<int> SaveChanges();
        IMongoCollection<T> GetCollection<T>(string name);
    }
}