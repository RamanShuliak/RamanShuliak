﻿using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;

namespace WebApiExperiment.MappingProfiles
{
    public class LabelProfile : Profile
    {
        public LabelProfile()
        {
            CreateMap<Label, LabelDto>().ReverseMap()
                .ForMember(ent => ent.Id, dto => dto.MapFrom(label => label.Id))
                .ForMember(ent => ent.Name, dto => dto.MapFrom(label => label.Name))
                .ForMember(ent => ent.Url, dto => dto.MapFrom(label => label.Url))
                .ForMember(ent => ent.Description, dto => dto.MapFrom(label => label.Description));

            //CreateMap<Label, IRepository<Label>>().ReverseMap()
            //    .ForMember(ent => ent.Id, dto => dto.MapFrom(label => label.Id))
            //    .ForMember(ent => ent.Name, dto => dto.MapFrom(label => label.Name))
            //    .ForMember(ent => ent.Url, dto => dto.MapFrom(label => label.Url))
            //    .ForMember(ent => ent.Description, dto => dto.MapFrom(label => label.Description));
        }
    }
}