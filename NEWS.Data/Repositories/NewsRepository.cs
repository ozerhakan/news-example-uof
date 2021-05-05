using System.Threading.Tasks;
using NEWS.Core;
using NEWS.Interface.Repositories;

namespace NEWS.Data.Repositories
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(INEWSMongoContext context) : base(context)
        {
            
        }
    }
}