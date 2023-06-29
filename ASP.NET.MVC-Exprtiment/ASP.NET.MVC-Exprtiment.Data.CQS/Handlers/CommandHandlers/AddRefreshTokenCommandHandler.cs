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
    public class AddRefreshTokenCommandHandler: IRequestHandler<AddRefreshTokenCommand>
    {
        private readonly MusicBandsContext _musicBandsContext;
        private readonly IMapper _mapper;

        public AddRefreshTokenCommandHandler(MusicBandsContext musicBandsContext, IMapper mapper)
        {
            _musicBandsContext = musicBandsContext;
            _mapper = mapper;
        }

        public async Task Handle(AddRefreshTokenCommand command, CancellationToken token)
        {
            var refreshToken = new RefreshToken()
            {
                Id = Guid.NewGuid(),
                Value = command.TokenValue,
                UserId = command.UserId
            };

            await _musicBandsContext.RefreshTokens.AddAsync(refreshToken, token);
            await _musicBandsContext.SaveChangesAsync(token);
        }
    }
}
