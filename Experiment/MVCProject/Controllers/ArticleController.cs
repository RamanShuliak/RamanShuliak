using Microsoft.AspNetCore.Mvc;
using MVCProject.Business.ServicesImplementation;
using MVCProject.Core;
using MVCProject.Core.Abstractions;

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
    }
}
