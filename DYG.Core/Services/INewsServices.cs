using System.Threading.Tasks;

namespace DYG.Core.Services
{
    public interface INewsServices
    {
        Task<News> CreateNews(News news);
    }
}