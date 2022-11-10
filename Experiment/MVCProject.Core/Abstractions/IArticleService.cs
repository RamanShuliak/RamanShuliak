using MVCProject.Core.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Core.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetArticleByPageSizeAndPageNumberAsync(int pageNumber, int pageSize);

        Task<List<ArticleDto>> GetNewArticleFromExternalSourcesAsync();

        Task<ArticleDto> GetArticleByIdAsync(Guid id);

    }
}
