using ASP.NET.MVC_Exprtiment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ASP.NET.MVC_Exprtiment.Controllers
{
    public class TestController : Controller
    {

        [HttpGet]
        public IActionResult CreateBand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBand(TestModel testModel)
        {
            return RedirectToAction("Index", "Home");
        }


    }
}
