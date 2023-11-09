using KafkaTest.MediatR.Abstractions;
using KafkaTest.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MediatR.Commands
{
    public class CreateUserCommand: ICommand
    {
        public CreateUserModel UserModel;
    }
}
