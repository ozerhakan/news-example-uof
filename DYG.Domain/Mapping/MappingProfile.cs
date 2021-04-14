using AutoMapper;
using DYG.Core;
using DYG.Domain.DTO;

namespace DYG.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<News, NewsDTO>().ReverseMap();
            CreateMap<Account, AccountDTO>().ReverseMap();
            CreateMap<SourcesData, SourcesDataDTO>().ReverseMap();
            CreateMap<Story, StoryDTO>().ReverseMap();
            CreateMap<MainCategory, MainCategoryDTO>().ReverseMap();
            CreateMap<Content, ContentDTO>().ReverseMap();
        }
    }
}