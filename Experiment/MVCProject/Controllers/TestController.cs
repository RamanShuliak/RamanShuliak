using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Text;

namespace MVCProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var band = new
            {
                Name = "Dream Theatre",
                Lable = "Napalm Records"
            };
            return Ok(band);
        }

        [HttpGet]
        public string Sum(int x, string str)
        {
            return $"{str} - {x} * {x} = {x*x} ";
        }

        [HttpGet]
        public string Model (TestModel model)
        {

            return $"Name - {model.Name}, Id - {model.Id}";
        }

        [HttpGet]
        public IActionResult ViewPres()
        {
            return View();
        }
    }
}
