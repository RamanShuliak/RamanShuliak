using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly GoodNewsAggregatorContext _databaseContext;
        public ArticleService(GoodNewsAggregatorContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

/*        public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
        {
            var dto = _articleStorage.ArticlesList
                .FirstOrDefault(articleDto=>articleDto.Id.Equals(id));
            
                return dto;

        }*/

        public async Task<List<ArticleDto>> GetArticleByPageSizeAndPageNumberAsync(int pageNumber, int pageSize)
        {
/*            var myApiKey = _configuration.GetSection("UserSecrets")["MyApiKey"];
            var passwordSalt = _configuration["UserSecrets:PasswordSalt"];*/

            var list = await _databaseContext.Articles
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(article => _mapper.Map<ArticleDto>(article))
                .ToListAsync();

            return list;
        }

        public async Task<List<ArticleDto>> GetNewArticleFromExternalSourcesAsync()
        {
            List<ArticleDto> list = new List<ArticleDto>();
            return list;
        }
        public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
        {
            var entity = await _databaseContext.Articles.FirstOrDefaultAsync(article => article.Id.Equals(id));
            var dto = _mapper.Map<ArticleDto>(entity);
            return dto;
        }

        public async Task<int> CreateArticleAsync(ArticleDto dto)
        {
            var entity = _mapper.Map<Article>(dto);
            if(entity != null)
            {
                await _databaseContext.Articles.AddAsync(entity);
                var addingResult = await _databaseContext.SaveChangesAsync();
                return addingResult;
            }
            else
            {
                throw new ArgumentException(nameof(dto));
            }
        }
    }
}
