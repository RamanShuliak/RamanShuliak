using AutoMapper;
using KafkaTest.DataBase;
using KafkaTest.DataBase.Entities;
using KafkaTest.MediatR.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MediatR.Handlers.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly KafkaTestDbContext context;
        private readonly IMapper mapper;

        public CreateUserCommandHandler(KafkaTestDbContext dBContext, IMapper mapper)
        {
            context = dBContext;
            this.mapper = mapper;
        }

        public async Task Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var newUser = mapper.Map<User>(command.UserModel);

            await context.Users.AddAsync(newUser);

            await context.SaveChangesAsync();
        }
    }
}
