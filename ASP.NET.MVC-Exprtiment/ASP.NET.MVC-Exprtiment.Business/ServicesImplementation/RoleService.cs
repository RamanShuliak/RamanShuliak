using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Business.ServicesImplementation
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> GetRoleNameByIdAsync(Guid roleId)
        {
            var role = await _unitOfWork.Roles.GetByIdAsync(roleId);

            return role != null
                ? role.Name
                : string.Empty;
        }

        public async Task<Guid?> GetRoleIdByNameAsync(string roleName)
        {
            var role = await _unitOfWork.Roles
                .FindBy(role => role.Name.Equals(roleName))
                .FirstOrDefaultAsync();

            return role != null
                ? role.Id
                : null;
        }
    }
}
