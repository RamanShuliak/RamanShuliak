using MedicalAssistantMVCProject.Core.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAssistantMVCProject.Core.Abstractions
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUserByPageSizeAndPageNumberAsync(int pageNumber, int pageSize);
    }
}
