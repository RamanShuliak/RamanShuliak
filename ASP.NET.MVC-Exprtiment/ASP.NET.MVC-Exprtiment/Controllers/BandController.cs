using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
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
                var result = await _bandService.PopulateDataBase();

                var bandList = await _bandService.GetBandsByPageNumberAndPageSize(pageNumber, _pageSize);

                if (bandList.Any())
                {
                    return View(bandList);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var band = await _bandService.GetBandById(id);

            return View(band);
        }
    }
}
