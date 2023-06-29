using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.CQS.Commands
{
    public class RemoveRefreshTokenCommand: IRequest
    {
        public Guid TokenValue;
    }
}
