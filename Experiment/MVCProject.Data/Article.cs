namespace MVCProject.DataBase
{
    public class Article
    {

    }
    public class Comments
    {

    }
    public class User
    {

    }
    public class Source
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

    }
    public enum SourceType
    {
        Rss,
        Api
    }
}