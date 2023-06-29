using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.CQS.Queries
{
    public class GetUserByRefreshTokenQuery: IRequest<UserDto?>
    {
        public Guid RefreshToken { get; set; }
    }
}
