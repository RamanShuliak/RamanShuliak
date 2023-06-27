using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.CQS.Queries
{
    public class GetBandByIdQuery: IRequest<Band>
    {
        public Guid BnadId { get; set; }
    }
}
