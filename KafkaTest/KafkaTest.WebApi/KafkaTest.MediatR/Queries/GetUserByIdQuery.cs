using KafkaTest.DataBase.Entities;
using KafkaTest.MediatR.Abstractions;
using KafkaTest.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MediatR.Queries
{
    public class GetUserByIdQuery : IQuery
    {
        public Guid UserId { get; set; }
    }
}
