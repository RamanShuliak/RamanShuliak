using AutoMapper;
using MedicalAssistantMVCProject.Core.Abstractions;
using MedicalAssistantMVCProject.Core.DataTransferObject;
using MedicalAssistantMVCProject.DataBase;
using MedicalAssistantMVCProject.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalAssistantMVCProject.Business.ServicesImplementation
{
    public class UserService : IUserService
    {
        private readonly MedicalAssistantDbContext _medicalAssistantDbContext;
        private readonly IMapper _mapper;

        public UserService(MedicalAssistantDbContext medicalAssistantDbContext, IMapper mapper)
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

        public async Task<int> CreateUserAsync(UserDto dto)
        {
            var entity = _mapper.Map<User>(dto);
            if (entity != null)
            {
                await _medicalAssistantDbContext.Users.AddAsync(entity);
                var addingResult = await _medicalAssistantDbContext.SaveChangesAsync();
                return addingResult;
            }
            else
            {
                throw new ArgumentException(nameof(dto));
            }
        }
    }
}
