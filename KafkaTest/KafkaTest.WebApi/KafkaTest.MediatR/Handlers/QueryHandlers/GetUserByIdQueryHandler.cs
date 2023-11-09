using AutoMapper;
using KafkaTest.DataBase;
using KafkaTest.DataBase.Entities;
using KafkaTest.MediatR.Queries;
using KafkaTest.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MediatR.Handlers.QueryHandlers
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, IBaseModel>
    {
        private readonly KafkaTestDbContext context;
        private readonly IMapper mapper;

        public GetUserByIdQueryHandler(KafkaTestDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IBaseModel> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
        {
            var user = await context.Users
                .Where(user => user.Id.Equals(query.UserId))
                .FirstOrDefaultAsync();

            var userModel = mapper.Map<CreateUserModel>(user);

            return userModel;
        }
    }
}
