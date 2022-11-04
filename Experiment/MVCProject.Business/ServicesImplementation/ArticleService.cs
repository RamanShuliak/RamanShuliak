using MVCProject.Core;
using MVCProject.Core.Abstractions;
using MVCProject.Core.DataTransferObject;
using System.Threading.Tasks;

namespace MVCProject.Business.ServicesImplementation
{
    public class ArticleService: IArticleService
    {
        private readonly ArticleStorage _articleStorage;
        public ArticleService(ArticleStorage articleStorage)
        {
            _articleStorage = articleStorage;
        }

        public async Task<List<ArticleDto>> GetArticleByPageSizeAndPageNumberAsync(int pageNumber, int pageSize)
        {
            List<ArticleDto> list;
            list = _articleStorage.ArticlesList
                .Skip(pageNumber*pageSize)
                .Take(pageSize).ToList();
            return list;
        }

        public async Task<List<ArticleDto>> GetNewArticleFromExternalSources()
        {
            List<ArticleDto> list = new List<ArticleDto>();
            return list;
        }
    }
}
