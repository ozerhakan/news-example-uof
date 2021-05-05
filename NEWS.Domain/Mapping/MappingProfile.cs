using AutoMapper;
using NEWS.Core;
using NEWS.Domain.DTO;

namespace NEWS.Domain.Mapping
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