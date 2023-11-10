﻿using KafkaTest.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.MediatR.Abstractions
{
    public interface IQuery : IRequest<IBaseModel>
    {
    }
}