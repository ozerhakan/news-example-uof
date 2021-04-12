using System.Threading.Tasks;

namespace DYG.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> Get(string id);
    }
}