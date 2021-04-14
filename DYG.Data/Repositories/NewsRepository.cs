using System.Threading.Tasks;
using DYG.Core;
using DYG.Interface.Repositories;

namespace DYG.Data.Repositories
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(IDygMongoContext context) : base(context)
        {
            
        }
    }
}