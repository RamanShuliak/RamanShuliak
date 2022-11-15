using MVCProject.Core.DataTransferObject;

namespace MVCProject.Models
{
    public class ArticleWithCommentsViewModel
    {

        public ArticleDto Article { get; set; }
        public List<string> Comments { get; set; }
    }
}
 