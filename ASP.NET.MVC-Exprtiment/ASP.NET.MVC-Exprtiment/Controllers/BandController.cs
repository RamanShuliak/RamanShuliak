using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASP.NET.MVC_Exprtiment.Controllers
{
    public class BandController : Controller
    {
        private readonly IBandService _bandService;
        private readonly IMapper _mapper;

        private int _pageSize = 5;
        public BandController(IBandService bandService, IMapper mapper)
        {
            _bandService = bandService;
            _mapper = mapper;
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

            try
            {
                var band = await _bandService.GetBandById(id);

                if(band != null)
                {
                    return View(band);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{ex.Message}; {Environment.NewLine} {ex.StackTrace}");
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(BandModel bandModel)
        {
            bandModel.Id = Guid.NewGuid();

            var label = await _bandService.GetLabelByName(bandModel.Label);

            var addedDandDto = _mapper.Map<BandDto>(bandModel);

            addedDandDto.LabelId = label.Id;

            var resultOfAdding = await _bandService.AddBandAsync(addedDandDto);

            return View();
        }
    }
}
