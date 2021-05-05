using System.Collections.Generic;
using System.Threading.Tasks;
using NEWS.Core;
using NEWS.Domain.DTO;

namespace NEWS.Interface.Services
{
    public interface INewsServices
    {
        Task<NewsDTO> CreateNews(NewsDTO news);
        Task<IEnumerable<NewsDTO>> GetAllNews();
        List<NewsDTO> GetReadNews();
    }
}