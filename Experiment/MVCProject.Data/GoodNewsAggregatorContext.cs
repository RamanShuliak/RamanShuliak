using Microsoft.EntityFrameworkCore;
using MVCProject.DataBase.Entities;

namespace MVCProject.DataBase
{
    public class GoodNewsAggregatorContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Source> Sources { get; set; }
        public GoodNewsAggregatorContext(DbContextOptions<GoodNewsAggregatorContext> options)
            : base(options)
        {
        }
    }
}
