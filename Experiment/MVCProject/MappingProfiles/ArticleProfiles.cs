using MVCProject.DataBase.Entities;
using AutoMapper;
using MVCProject.Core.DataTransferObject;
using MVCProject.Models;

namespace MVCProject.MappingProfiles
{
    public class ArticleProfiles : Profile
    {
        public ArticleProfiles()
        {
            CreateMap<Article, ArticleDto>()
                .ForMember(dto => dto.Category,
                    opt => 
                        opt.MapFrom(article => "Default"))
                .ForMember(dto => dto.ShortSummary,
                    opt =>
                        opt.MapFrom(article => article.ShortDescription))
                .ForMember(dto => dto.Id,
                    opt => 
                        opt.MapFrom(article => article.Id));
            CreateMap<ArticleDto, Article>()
                .ForMember(article => article.ShortDescription,
                opt =>
                    opt.MapFrom(article => article.ShortSummary))
                .ForMember(article => article.SourceId,
                opt =>
                    opt.MapFrom(article => new Guid("5750B757-7A87-4E08-B840-CDD135BD4450")));
            CreateMap<ArticleDto, ArticleModel>().ReverseMap();
        }
    }
}
