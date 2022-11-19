using AutoMapper;
using MedicalAssistantMVCProject.Core.Abstractions;
using MedicalAssistantMVCProject.Core.DataTransferObject;
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
                throw new ArgumentException(nameof(page));
            }

        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserModel model)
        {
            try
            {
                if (model != null)
                {
                    model.Id = Guid.NewGuid();

                    var dto = _mapper.Map<UserDto>(model);

                    await _userService.CreateUserAsync(dto);

                    return RedirectToAction("Index", "User");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
