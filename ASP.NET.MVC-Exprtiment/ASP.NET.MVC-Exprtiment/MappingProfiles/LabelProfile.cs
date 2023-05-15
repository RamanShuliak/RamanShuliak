using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using ASP.NET.MVC_Exprtiment.Models;
using AutoMapper;

namespace ASP.NET.MVC_Exprtiment.MappingProfiles
{
    public class LabelProfile: Profile
    {
        public LabelProfile()
        {
            CreateMap<Label, LabelDto>().ReverseMap()
                .ForMember(ent => ent.Id, dto => dto.MapFrom(label => label.Id))
                .ForMember(ent => ent.Name, dto => dto.MapFrom(label => label.Name))
                .ForMember(ent => ent.Url, dto => dto.MapFrom(label => label.Url));    
        }
    }
}
