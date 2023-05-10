using ASP.NET.MVC_Exprtiment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ASP.NET.MVC_Exprtiment.Controllers
{
    public class CreateTestController : Controller
    {

        [HttpGet]
        [Route ("Quick")]
        public IActionResult CreateBand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBand(CreateTestModel testModel)
        {
            return RedirectToAction("Index", "Home");
        }


    }
}
