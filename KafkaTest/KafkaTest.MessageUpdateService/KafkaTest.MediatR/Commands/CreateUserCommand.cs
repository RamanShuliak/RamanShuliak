using KafkaTest.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KafkaTest.MediatR.Commands
{
    public class CreateUserCommand : IRequest
    {
        public UserModel UserModel;
    }
}
