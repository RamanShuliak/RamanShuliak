using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Data.CQS.Queries;
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

namespace ASP.NET.MVC_Exprtiment.Data.CQS.Handlers.QueryHandlers
{
    public class GetUserByRefreshTokenQueryHandler: IRequestHandler<GetUserByRefreshTokenQuery, UserDto?>
    {
        private readonly MusicBandsContext _musicBandsContext;
        private readonly IMapper _mapper;

        public GetUserByRefreshTokenQueryHandler(MusicBandsContext musicBandsContext, IMapper mapper)
        {
            _musicBandsContext = musicBandsContext;
            _mapper = mapper;
        }

        public async Task<UserDto?> Handle(GetUserByRefreshTokenQuery request, 
            CancellationToken cancellationToken)
        {
            var user = (await _musicBandsContext.RefreshTokens
                .Include(token => token.User)
                .ThenInclude(user => user.Role)
                .AsNoTracking()
                .FirstOrDefaultAsync(token => 
                token.Value.Equals(request.RefreshToken), cancellationToken))?.User;

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }
    }
}
