using System.Collections.Generic;
using System.Threading.Tasks;
using DYG.Core;
using DYG.Domain.DTO;

namespace DYG.Interface.Services
{
    public interface INewsServices
    {
        Task<NewsDTO> CreateNews(NewsDTO news);
        Task<IEnumerable<NewsDTO>> GetAllNews();
        List<NewsDTO> GetReadNews();
    }
}