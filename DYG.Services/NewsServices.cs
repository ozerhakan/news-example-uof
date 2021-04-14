using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using DYG.Core;
using DYG.Interface;
using DYG.Interface.Services;
using DYG.Domain.DTO;

namespace DYG.Services
{
    public class NewsServices : INewsServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NewsServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<NewsDTO> CreateNews(NewsDTO news)
        {
          var newsData = _mapper.Map<NewsDTO, News>(news);
            await _unitOfWork.NewsRepository.AddAsync(newsData);
            await _unitOfWork.Commit();
            return news;
        }

        public async Task<IEnumerable<NewsDTO>> GetAllNews()
        {
            var result =  await _unitOfWork.NewsRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<News>, IEnumerable<NewsDTO>>(result);
        }

        public List<NewsDTO> GetReadNews()
        {
            var fileToReadListText = System.IO.File.ReadAllText("/Users/hakanozer/Development/Net/Net5/DYG/DYG.UI/case_study.data.json");
            List<NewsDTO> newsList = JsonSerializer.Deserialize<List<NewsDTO>>(fileToReadListText);

            return newsList;
        }
        
    }
}