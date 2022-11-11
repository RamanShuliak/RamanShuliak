using MVCProject.DataBase.Entities;
using AutoMapper;
using MVCProject.Core.DataTransferObject;

namespace MVCProject.MappingProfiles
{
    public class ArticleProfiles : Profile
    {
        public ArticleProfiles()
        {
            CreateMap<Article, ArticleDto>()
                .ForMember(dto => dto.Category, opt => opt.MapFrom(article => "Default"))
                .ForMember(dto => dto.Id, opt => opt.MapFrom(article => article.Id));
        }
    }
}
