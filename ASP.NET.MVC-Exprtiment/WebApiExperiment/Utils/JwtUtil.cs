using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Data.CQS.Commands;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiExperiment.Models.Responses;

namespace WebApiExperiment.Utils
{
    public class JwtUtil: IJwtUtil
    {
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;

        public JwtUtil(IConfiguration configuration, IMediator mediator)
        {
            _configuration = configuration;
            _mediator = mediator;
        }

        public async Task<TokenResponce> GenerateTokenAsync(UserDto userDto)
        {
            var secretKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Token:JwtSecret"]));
            var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var nowUtc = DateTime.UtcNow;
            var expires = nowUtc.AddMinutes(double.Parse(_configuration["Token:ExpiryMinutes"]))
                .ToUniversalTime();
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, userDto.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("D")),
                new Claim(ClaimTypes.NameIdentifier, userDto.Id.ToString("D")),
                new Claim(ClaimTypes.Role, userDto.RoleName)
            };

            var jwtToken = new JwtSecurityToken(_configuration["Token:Issuer"], 
                _configuration["Token:Issuer"], 
                claims, 
                expires: expires,
                signingCredentials: credentials);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            var refreshToken = Guid.NewGuid();

            await _mediator.Send(new AddRefreshTokenCommand()
            {
                UserId = userDto.Id,
                TokenValue = refreshToken
            });

            return new TokenResponce()
            {
                AccessToken = accessToken,
                Role = userDto.RoleName,
                TokenExpiration = jwtToken.ValidTo,
                UserId = userDto.Id,
                RefreshToken = refreshToken
            };
        }

        public async Task RemoveRefreshTokenAsync(Guid requestRefreshToken)
        {
            await _mediator.Send(new RemoveRefreshTokenCommand()
            {
                TokenValue = requestRefreshToken
            });
        }
    }
}
