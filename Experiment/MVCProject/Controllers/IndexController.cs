using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Home()
        {
            return BadRequest();
        }
    }
}
