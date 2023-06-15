using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;
using WebApiExperiment.Models.Requests;

namespace WebApiExperiment.MappingProfiles
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dto => dto.RoleName,
                opt => opt.MapFrom(ent => ent.Role.Name));

            CreateMap<UserDto, User>()
                .ForMember(ent => ent.DateOfRegistration,
                opt => opt.MapFrom(dto => DateTime.Now))
                .ForMember(ent => ent.Id,
                opt => opt.MapFrom(dto => Guid.NewGuid()));

            CreateMap<RegisterRequestModel, UserDto>();
        }
    }
}
