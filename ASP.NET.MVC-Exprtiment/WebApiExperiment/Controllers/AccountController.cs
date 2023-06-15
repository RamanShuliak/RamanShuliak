using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExperiment.Models.Requests;

namespace WebApiExperiment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public AccountController(IUserService userService, IRoleService roleService, IMapper mapper)
        {
            _userService = userService;
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequestModel registerModel)
        {
            var userRoleId = await _roleService.GetRoleIdByNameAsync("User");

            var userDto = _mapper.Map<UserDto>(registerModel);

            if (userDto != null && userRoleId != null)
            {
                userDto.RoleId = userRoleId.Value;
                var result = await _userService.RegisterUserAsync(userDto);
            }

            return Ok();
        }
    }
}
