using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.CQS.Queries;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Business.ServicesImplementation
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
            _mediator = mediator;
        }

        public async Task<bool> ChekUserPasswordByIdAsync(Guid userId, string password)
        {
            var passwordHash = (await _unitOfWork.Users.GetByIdAsync(userId))?.PasswordHash;

            if (passwordHash != null)
            {
                if (CreateMD5(password).Equals(passwordHash))
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<bool> ChekUserPasswordByEmailAsync(string email, string password)
        {
            var passwordHash = (await _unitOfWork.Users
                .Get()
                .FirstOrDefaultAsync(user => user.Email.Equals(email)))?.PasswordHash;

            if (passwordHash != null)
            {
                if (CreateMD5(password).Equals(passwordHash))
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<Guid?> GetUserIdByEmailAsync(string email)
        {
            var user = await _unitOfWork.Users
                .Get()
                .FirstOrDefaultAsync(user => user.Email.Equals(email));

            if(user == null)
            {
                return user.Id;
            }
            return null;
        }

        public async Task<bool> IsUserExistAsync(Guid userId)
        {
            return await _unitOfWork.Users
                .Get()
                .AnyAsync(user => user.Id.Equals(userId));
        }

        public async Task<bool> IsUserByEmailExistAsync(string email)
        {
            return await _unitOfWork.Users
                .Get()
                .AnyAsync(user => user.Email.Equals(email));
        }

        public async Task<int> RegisterUserAsync(UserDto userDto)
        {
            var newUser = _mapper.Map<User>(userDto);

            newUser.PasswordHash = CreateMD5(userDto.Password);

            await _unitOfWork.Users.AddAsync(newUser);

            var result =  await _unitOfWork.CommitAsync();

            return result;
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            var user = await _unitOfWork.Users
                .FindBy(user => user.Email.Equals(email),
                user => user.Role)
                .FirstOrDefaultAsync();

            var userDto = _mapper.Map<UserDto>(user);


            return userDto;
        }
        public async Task<UserDto?> GetUserByRefreshTokenAsync(Guid token)
        {
            var userDto = await _mediator.Send(new GetUserByRefreshTokenQuery()
            {
                RefreshToken = token
            });

            return userDto != null ? userDto : null;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            return (await _unitOfWork.Users.GetAllAsync()).Select(user => _mapper.Map<UserDto>(user));
        }

        public string CreateMD5(string password)
        {
            var passwordSalt = _configuration["UserSecret:PasswordSalt"];
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var inputBytes = System.Text.Encoding.UTF8.GetBytes(password + passwordSalt);
                var hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}
