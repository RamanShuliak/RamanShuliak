using AutoMapper;
using MedicalAssistantMVCProject.Core.Abstractions;
using MedicalAssistantMVCProject.Core.DataTransferObject;
using MedicalAssistantMVCProject.DataBase;
using Microsoft.EntityFrameworkCore;

namespace MedicalAssistantMVCProject.Business.ServicesImplementation
{
    public class UserService : IUserService
    {
        private readonly MedicalAssistantDbContext _medicalAssistantDbContext;
        private readonly Mapper _mapper;

        public UserService(MedicalAssistantDbContext medicalAssistantDbContext, Mapper mapper)
        {
            _medicalAssistantDbContext = medicalAssistantDbContext;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetUserByPageSizeAndPageNumberAsync(int pageNumber, int pageSize)
        {

            var list = await _medicalAssistantDbContext.Users
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(user => _mapper.Map<UserDto>(user))
                .ToListAsync();

            return list;
        }
    }
}
