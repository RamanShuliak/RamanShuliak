using KafkaTest.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace KafkaTest.DataBase
{
    public class KafkaTestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public KafkaTestDbContext(DbContextOptions<KafkaTestDbContext> options) : base(options)
        {

        }
    }
}