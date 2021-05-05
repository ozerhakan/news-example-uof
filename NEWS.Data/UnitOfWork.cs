using System.Threading.Tasks;
using NEWS.Core;
using NEWS.Data.Repositories;
using NEWS.Interface;
using NEWS.Interface.Repositories;

namespace NEWS.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly INEWSMongoContext _context;
        private NewsRepository _newsRepository;
        public UnitOfWork(INEWSMongoContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();;
        }
        public INewsRepository NewsRepository => _newsRepository = _newsRepository ?? new NewsRepository(_context);

        public async Task<bool> Commit()
        {
            var changeAmount = await _context.SaveChanges();
            return changeAmount > 0;
        }
    }
}