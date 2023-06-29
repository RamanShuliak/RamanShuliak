using ASP.NET.MVC_Exprtiment.Data.CQS.Commands;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.CQS.Handlers.CommandHandlers
{
    public class RemoveRefreshTokenCommandHandler: IRequestHandler<RemoveRefreshTokenCommand>
    {
        private readonly MusicBandsContext _musicBandsContext;
        private readonly IMapper _mapper;

        public RemoveRefreshTokenCommandHandler(MusicBandsContext musicBandsContext, IMapper mapper)
        {
            _musicBandsContext = musicBandsContext;
            _mapper = mapper;
        }

        public async Task Handle(RemoveRefreshTokenCommand command, CancellationToken token)
        {
            var refreshToken = await _musicBandsContext.RefreshTokens
                .FirstOrDefaultAsync(token => command.TokenValue.Equals(command.TokenValue), token);

            _musicBandsContext.RefreshTokens.Remove(refreshToken);
            await _musicBandsContext.SaveChangesAsync(token);
        }
    }
}
