using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Business.ServicesImplementation;
using MVCProject.Core;
using MVCProject.Core.Abstractions;
using MVCProject.Core.DataTransferObject;
using MVCProject.Models;
using Serilog;

namespace MVCProject.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;



        private int _pageSize = 5;
        public ArticleController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index (int page)
        {
            try
            {
/*                var result = await _articleService.InitDatabase();*/
                var article = await _articleService
                    .GetArticleByPageSizeAndPageNumberAsync(page, _pageSize);
                if (article.Any())
                {
                    return View(article);
                }
                else
                {
                    throw new ArgumentException(nameof(page));
                }
            }
            catch (Exception e)
            {
                Log.Error($"{e.Message}.{Environment.NewLine}{e.StackTrace}");
                throw;
            }
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var dto = await _articleService.GetArticleByIdAsync(id);
            if (dto != null)
            {
                //ViewData["model"] = dto;
                //ViewBag.Model = dto;
                return View(dto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleModel model)
        {
            try
            {
                if(model != null)
                {
                    model.Id = Guid.NewGuid();
                    model.PublicationDate = DateTime.Now;

                    var dto = _mapper.Map<ArticleDto>(model);

                    await _articleService.CreateArticleAsync(dto);

                    return RedirectToAction("Index", "Article");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch(Exception ex)
            {
                Log.Error(ex, ex.Message);
                return StatusCode(500);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id != Guid.Empty)
            {
                var articleDto = await _articleService.GetArticleByIdAsync(id);
                if (articleDto == null)
                {
                    return BadRequest();
                }
                var editModel = _mapper.Map<ArticleModel>(articleDto);
                return View(editModel);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ArticleModel model)
        {

            try
            {
                if (model != null)
                {
                    var dto = _mapper.Map<ArticleDto>(model);

/*                    await _articleService.CreateArticleAsync(dto);*/

                    return RedirectToAction("Index", "Article");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return StatusCode(500);
            }
        }

    }
}
