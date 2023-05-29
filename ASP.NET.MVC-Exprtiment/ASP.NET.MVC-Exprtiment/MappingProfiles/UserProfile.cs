using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using ASP.NET.MVC_Exprtiment.Models;
using AutoMapper;

namespace ASP.NET.MVC_Exprtiment.MappingProfiles
{
    public class UserProfile: Profile
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

            CreateMap<RegistrationModel, UserDto>()
                .ForMember(dto => dto.Name,
                opt => opt.MapFrom(model => string.Empty));

            CreateMap<LoginModel, UserDto>()
                .ForMember(dto => dto.RoleId,
                opt => opt.MapFrom(model => new Guid("D4C8F363-D6A0-4EAC-BCEF-83B856E422F5")));
        }
    }
}
