using ASP.NET.MVC_Exprtiment.Business.ServicesImplementation;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASP.NET.MVC_Exprtiment.Controllers
{
    public class LabelController : Controller
    {
        private readonly ILabelService _labelService;
        private readonly IMapper _mapper;

        private int _pageSize = 5;

        public LabelController(ILabelService labelService, IMapper mapper)
        {
            _labelService = labelService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(int pageNumber)
        {
            try
            {
                var labelList = await _labelService.GetLabelByPageNumberAndPageSizeAsync(pageNumber, _pageSize);

                if (labelList.Any())
                {
                    return View(labelList);
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
    }
}
