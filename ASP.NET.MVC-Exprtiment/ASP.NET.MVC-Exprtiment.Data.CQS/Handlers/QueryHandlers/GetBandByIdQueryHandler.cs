using ASP.NET.MVC_Exprtiment.Data.CQS.Queries;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.CQS.Handlers.QueryHandlers
{
    public class GetBandByIdQueryHandler : IRequestHandler<GetBandByIdQuery, Band>
    {
        private readonly MusicBandsContext _context;

        public GetBandByIdQueryHandler(MusicBandsContext context)
        {
            _context = context;
        }

        public async Task<Band> Handle(GetBandByIdQuery request, CancellationToken cancellationToken)
        {
            var band = await _context.Bands
                .FirstOrDefaultAsync(band => band.Id.Equals(request.BnadId));

            return band;
        }
    }
}
