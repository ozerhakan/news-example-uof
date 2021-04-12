using System.Threading.Tasks;
using DYG.Core;
using DYG.Core.Repositories;
using DYG.Core.Services;

namespace DYG.Services
{
    public class NewsServices : INewsServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INewsRepository _newsRepository;

        public NewsServices(INewsRepository newsRepository, IUnitOfWork unitOfWork)
        {
            _newsRepository = newsRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<News> CreateNews(News news)
        {
            await _newsRepository.AddAsync(news);
            await _unitOfWork.Commit();
            return news;
        }
    }
}