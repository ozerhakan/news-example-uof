using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using DYG.Core;
using DYG.Core.Repositories;
using DYG.Core.Services;

namespace DYG.Services
{
    public class NewsServices : INewsServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<News> CreateNews(News news)
        {
            await _unitOfWork.NewsRepository.AddAsync(news);
            await _unitOfWork.Commit();
            return news;
        }
    }
}