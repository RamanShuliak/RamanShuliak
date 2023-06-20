using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using WebApiExperiment.Models.Requests;
using WebApiExperiment.Models.Responses;
using WebApiExperiment.Utils;

namespace WebApiExperiment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        private readonly IJwtUtil _jwtUtil;

        public AccountController(IUserService userService, IRoleService roleService, IMapper mapper, IJwtUtil jwtUtil)
        {
            _userService = userService;
            _roleService = roleService;
            _mapper = mapper;
            _jwtUtil = jwtUtil;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.GetAllUsersAsync();

            return Ok(users);
        }

        /// <summary>
        /// Register users
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterRequestModel registerModel)
        {
            try
            {
                var userRoleId = await _roleService.GetRoleIdByNameAsync("User");

                var userDto = _mapper.Map<UserDto>(registerModel);

                var isUserEmailExist = await _userService.IsUserByEmailExistAsync(registerModel.Email);

                if (userDto != null
                    && userRoleId != null
                    && !isUserEmailExist
                    && registerModel.Password.Equals(registerModel.PasswordConfirmation))
                {
                    userDto.RoleId = userRoleId.Value;
                    var result = await _userService.RegisterUserAsync(userDto);

                    if (result > 0)
                    {
                        var userInDbDto = await _userService.GetUserByEmailAsync(userDto.Email);

                        var responce = _jwtUtil.GenerateToken(userInDbDto);

                        return Ok(responce);
                    }

                }
                return BadRequest(new ErrorModel()
                {
                    Message = "User with such email is already exist, or you password confirmation is incorrect. Check entered data."
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500);
            }
            
        }
    }
}
