using System.Threading.Tasks;
using DYG.Core;
using DYG.Data.Repositories;
using DYG.Interface;
using DYG.Interface.Repositories;

namespace DYG.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDygMongoContext _context;
        private NewsRepository _newsRepository;
        public UnitOfWork(IDygMongoContext context)
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