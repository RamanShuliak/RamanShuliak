using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVC_Exprtiment.Controllers
{
    public class BandController : Controller
    {
        private readonly IBandService _bandService;

        private int _pageSize = 5;
        public BandController(IBandService bandService)
        {
            _bandService = bandService;
        }
        public async Task<IActionResult> Index(int pageNumber)
        {
            try
            {
                var bandList = await _bandService.GetBandsByPageNumberAndPageSize(pageNumber, _pageSize);

                if (bandList.Any())
                {
                    return View(bandList);
                }
                else
                {
                    return View("No bands.");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
