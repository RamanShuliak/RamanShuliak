using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;

namespace WebApiExperiment.MappingProfiles
{
    public class BandProfile : Profile
    {
        public BandProfile()
        {
            CreateMap<Band, BandDto>().ReverseMap()
                .ForMember(ent => ent.Id, dto => dto.MapFrom(band => band.Id))
                .ForMember(ent => ent.Name, dto => dto.MapFrom(band => band.Name))
                .ForMember(ent => ent.Country, dto => dto.MapFrom(band => band.Country))
                .ForMember(ent => ent.DateOfCreation, dto => dto.MapFrom(band => band.DateOfCreation))
                .ForMember(ent => ent.Description, dto => dto.MapFrom(band => band.Description))
                .ForMember(ent => ent.MainText, dto => dto.MapFrom(band => band.MainText))
                .ForMember(ent => ent.LabelId, dto => dto.MapFrom(band => band.LabelId));
        }
    }
}
