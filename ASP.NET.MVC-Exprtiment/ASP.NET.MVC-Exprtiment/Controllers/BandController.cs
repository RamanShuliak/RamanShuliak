using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASP.NET.MVC_Exprtiment.Controllers
{
    [Authorize(Roles = "User")]
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
                var bandList = await _bandService.GetBandsByPageNumberAndPageSizeAsync(pageNumber, _pageSize);

                if (bandList.Any())
                {
                    return View(bandList);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{ex.Message}; {Environment.NewLine} {ex.StackTrace}");
                throw;
            }
        }

        public async Task<IActionResult> Details(Guid id)
        {

            try
            {
                var band = await _bandService.GetBandByIdAsync(id);

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
            if (ModelState.IsValid)
            {
                var isBandExist = await _bandService.IsBandAlreadyExistAsync(bandModel.Name);

                if (isBandExist == true)
                {
                    ModelState.AddModelError(nameof (bandModel.Name), "Band with this name is already exist.");
                    return View(bandModel);
                }
                else
                {
                    bandModel.Id = Guid.NewGuid();

                    var label = await _bandService.GetLabelByNameAsync(bandModel.Label);

                    var addedDandDto = _mapper.Map<BandDto>(bandModel);

                    addedDandDto.LabelId = label.Id;

                    var resultOfAdding = await _bandService.AddBandAsync(addedDandDto);

                    return RedirectToAction("Index", "Band");
                }
            }
            else
            {
                return View(bandModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CheckName(BandModel bandModel)
        {
            var isBandExist = await _bandService.IsBandAlreadyExistAsync(bandModel.Name);

            if (isBandExist == true)
            {
                return Ok(false);
            }
            else
            {
                return Ok(true);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id != null)
            {
                var bandDto = await _bandService.GetBandByIdAsync(id);

                var bandModel = _mapper.Map<BandModel>(bandDto);

                return View(bandModel);
            }
            else 
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BandModel bandModel)
        {
            var label = await _bandService.GetLabelByNameAsync(bandModel.Label);

            var editedDandDto = _mapper.Map<BandDto>(bandModel);

            if(label != null)
            {
                editedDandDto.LabelId = label.Id;

            }
            else
            {
                editedDandDto.LabelId = Guid.Empty;
            }

            var resultOfEdition = await _bandService.EditBandAsync(editedDandDto);

            return RedirectToAction("Index", "Band");
        }
    }
}
