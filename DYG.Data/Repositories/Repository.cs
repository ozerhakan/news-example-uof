using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DYG.Interface.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DYG.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IDygMongoContext _mongoContext;
        private IMongoCollection<TEntity> _dbCollection;

        protected Repository(IDygMongoContext context)
        {
            _mongoContext = context;
            _dbCollection = _mongoContext.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public async Task AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{typeof(TEntity).Name} object is null");
            }
            await _dbCollection.InsertOneAsync(entity);
        }

        public async Task<TEntity> Get(string id)
        {
            var objectId = new ObjectId(id);
            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter.Eq("_id", objectId);
            return await _dbCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var all = _dbCollection.FindAsync(Builders<TEntity>.Filter.Empty).Result;
            return await all.ToListAsync();
        }
    }
}