using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
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

        public JwtUtil(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TokenResponce GenerateToken(UserDto userDto)
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

            return new TokenResponce()
            {
                AccessToken = accessToken,
                Role = userDto.RoleName,
                TokenExpiration = jwtToken.ValidTo,
                UserId = userDto.Id
            };
        }
    }
}
