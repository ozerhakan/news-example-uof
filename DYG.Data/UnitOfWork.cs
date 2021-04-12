using System.Threading.Tasks;
using DYG.Core;
using DYG.Core.Repositories;
using DYG.Data.Repositories;

namespace DYG.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDygMongoContext _context;
        public UnitOfWork(IDygMongoContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();;
        }
        public async Task<bool> Commit()
        {
            var changeAmount = await _context.SaveChanges();
            return changeAmount > 0;
        }
    }
}