using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using AutoMapper;
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
    public class TokenController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        private readonly IJwtUtil _jwtUtil;

        public TokenController(IUserService userService, IRoleService roleService, IMapper mapper)
        {
            _userService = userService;
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateJwtToken([FromBody]LoginRequestModel loginModel)
        {
            try
            {
                var userDto = await _userService.GetUserByEmailAsync(loginModel.Email);

                if (userDto == null)
                {
                    return BadRequest();
                }

                var isPasswordCorrect = await _userService
                    .ChekUserPasswordByEmailAsync(loginModel.Email, loginModel.Password);

                if(!isPasswordCorrect)
                {
                    return BadRequest(new ErrorModel()
                    {
                        Message = "Entered password is incorrect."
                    });
                }

                var responce = _jwtUtil.GenerateToken(userDto);
                return Ok(responce);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500);
            }

        }
    }
}
