using MVCProject.DataBase.Entities;

namespace MVCProject.Core.DataTransferObject
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string ShortSummary { get; set; }
        public string Text { get; set; }
        public DateTime PublicationDate { get; set; }
/*        public ArticleDto(Article article)
        {
            Id = article.Id;
            Title = article.Title;
            Category = "Default";
            Text = article.Text;
            PublicationDate = article.PublicationDate;
            ShortSummary = article.ShortDescription;
        }*/

    }
}
