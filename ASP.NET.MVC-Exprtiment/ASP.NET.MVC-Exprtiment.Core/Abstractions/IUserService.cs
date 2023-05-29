using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Core.Abstractions
{
    public interface IUserService
    {
        Task<bool> ChekUserPasswordByIdAsync(Guid userId, string password);
        Task<bool> ChekUserPasswordByEmailAsync(string email, string password);
        Task<Guid?> GetUserIdByEmailAsync(string email);
        Task<bool> IsUserExistAsync(Guid userId);
        Task<int> RegisterUserAsync(UserDto userDto);
        Task<UserDto> GetUserByEmailAsync(string email);
        string CreateMD5(string password);
    }
}
