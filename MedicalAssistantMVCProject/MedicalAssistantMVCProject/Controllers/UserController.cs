using MedicalAssistantMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAssistantMVCProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
