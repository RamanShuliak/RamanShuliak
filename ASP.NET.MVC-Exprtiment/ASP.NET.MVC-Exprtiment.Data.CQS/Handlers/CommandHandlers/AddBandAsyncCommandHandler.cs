using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Data.CQS.Commands;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;
using Azure.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.CQS.Handlers.CommandHandlers
{
    public class AddBandAsyncCommandHandler: IRequestHandler<AddBandAsyncCommand>
    {
        private readonly MusicBandsContext _musicBandsContext;
        private readonly IMapper _mapper;

        public AddBandAsyncCommandHandler(MusicBandsContext musicBandsContext, IMapper mapper)
        {
            _musicBandsContext = musicBandsContext;
            _mapper = mapper;
        }

        public async Task Handle(AddBandAsyncCommand command, CancellationToken token)
        {
            var bandsNamesInDb = await _musicBandsContext.Bands
                .Select(band => band.Name)
                .ToListAsync(token);

            var newBand = _mapper.Map<Band>(command.Band);

            if (!bandsNamesInDb.Contains(newBand.Name))
            {
                await _musicBandsContext.Bands.AddAsync(newBand);
                await _musicBandsContext.SaveChangesAsync(token);
            }

        }
    }
}
