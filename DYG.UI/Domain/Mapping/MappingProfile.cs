using AutoMapper;
using DYG.Core;
using DYG.UI.DTO;

namespace DYG.UI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<News, NewsDTO>().ReverseMap();
        }
    }
}