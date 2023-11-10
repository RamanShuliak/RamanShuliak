using AutoMapper;
using KafkaTest.DataBase.Entities;
using KafkaTest.MediatR.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MediatR.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserTargetModel, User>();
        }
    }
}


