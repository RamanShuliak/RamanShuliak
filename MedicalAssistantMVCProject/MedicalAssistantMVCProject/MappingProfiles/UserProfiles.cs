using AutoMapper;
using MedicalAssistantMVCProject.DataBase.Entities;
using MedicalAssistantMVCProject.Core.DataTransferObject;
using MedicalAssistantMVCProject.Models;
namespace MedicalAssistantMVCProject.MappingProfiles
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            CreateMap<User, UserDto>()
                .ForMember(dto => dto.Id,
                    opt =>
                        opt.MapFrom(user => user.Id))
                .ForMember(dto => dto.UserName,
                    opt =>
                        opt.MapFrom(user => user.UserName))
                .ForMember(dto => dto.Email,
                    opt =>
                        opt.MapFrom(user => user.Email))
                .ForMember(dto => dto.PasswordHash,
                    opt =>
                        opt.MapFrom(user => user.PasswordHash));

            CreateMap<UserDto, User>()
                .ForMember(user => user.Id,
                    opt =>
                        opt.MapFrom(user => user.Id))
                .ForMember(user => user.UserName,
                    opt =>
                        opt.MapFrom(user => user.UserName))
                .ForMember(user => user.Email,
                    opt =>
                        opt.MapFrom(user => user.Email))
                .ForMember(user => user.PasswordHash,
                    opt =>
                        opt.MapFrom(user => user.PasswordHash));
        }
    }
}
