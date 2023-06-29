using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using WebApiExperiment.Models.Responses;

namespace WebApiExperiment.Utils
{
    public interface IJwtUtil
    {
        Task<TokenResponce> GenerateTokenAsync(UserDto userDto);
        Task RemoveRefreshTokenAsync(Guid requestRefreshToken);
    }
}
