using AutoMapper;
using MedicalAssistantMVCProject.Core.Abstractions;
using MedicalAssistantMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAssistantMVCProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        private int _pageSize = 5;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(int page)
        {
            try
            {
                var user = await _userService
                    .GetUserByPageSizeAndPageNumberAsync(page, _pageSize);
                if (user.Any())
                {
                    return View(user);
                }
                else
                {
                    throw new ArgumentException(nameof(page));
                }
            }
            catch
            {

            }

            return Ok();
        }
    }
}
