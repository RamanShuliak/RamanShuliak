using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Exprtiments.EF
{
    public class SongsDBContext: DbContext
    // Создаём класс с именами таблиц
    {
        public DbSet<Song> Songs { get; set; }
        // Создаём таблицы
        public DbSet<Band> Bands { get; set; }

        private const string ConnectionString =
            "Server=HPPROBOOK;" +
            "Database=ASP.NET.Exprtiments.EF;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True";
        // Создаём строку соединения

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // Берём билдер из коробки
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
