using MVCProject.Core;
using MVCProject.Core.Abstractions;
using MVCProject.Core.DataTransferObject;
using MVCProject.DataBase;
using MVCProject.DataBase.Entities;
using System.Threading.Tasks;

namespace MVCProject.Business.ServicesImplementation
{
    public class ArticleService: IArticleService
    {
        /*        private readonly ArticleStorage _articleStorage;*/

        private readonly GoodNewsAggregatorContext _databaseContext;
        public ArticleService(GoodNewsAggregatorContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

/*        public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
        {
            var dto = _articleStorage.ArticlesList
                .FirstOrDefault(articleDto=>articleDto.Id.Equals(id));
            
                return dto;

        }*/

        public async Task<List<ArticleDto>> GetArticleByPageSizeAndPageNumberAsync(int pageNumber, int pageSize)
        {
            List<ArticleDto> list = new List<ArticleDto>();
            var entities = 
                _databaseContext.Articles
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(article => new ArticleDto()
                {
                    Id = article.Id,
                    Title = article.Title,
                    Category = "Default",
                    Text = article.Text,
                    PublicationDate = article.PublicationDate,
                    ShortSummary = article.ShortDescription
                })
                .ToList();

            /*            list = _articleStorage.ArticlesList
                            .Skip(pageNumber*pageSize)
                            .Take(pageSize)
                            .ToList();*/
            return list;
        }

        public async Task<List<ArticleDto>> GetNewArticleFromExternalSourcesAsync()
        {
            List<ArticleDto> list = new List<ArticleDto>();
            return list;
        }
        public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
        {
            var dto = new ArticleDto();
            return dto;
        }
    }
}
