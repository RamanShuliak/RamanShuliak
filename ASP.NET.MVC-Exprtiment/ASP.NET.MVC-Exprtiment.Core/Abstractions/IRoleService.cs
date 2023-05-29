using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Core.Abstractions
{
    public interface IRoleService
    {
        Task<string> GetRoleNameByIdAsync(Guid roleId);
        Task<Guid?> GetRoleIdByNameAsync(string roleName);
    }
}
