using System.Collections.Generic;
using System.Threading.Tasks;

namespace DYG.Interface.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> Get(string id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}