using Microsoft.AspNetCore.Mvc;
using MVCProject.Business.ServicesImplementation;
using MVCProject.Core;
using MVCProject.Core.Abstractions;
using MVCProject.Core.DataTransferObject;

namespace MVCProject.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService; 
        private int _pageSize = 5;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
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
                    return View();
                }
            }
            catch
            {
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
    }
}
