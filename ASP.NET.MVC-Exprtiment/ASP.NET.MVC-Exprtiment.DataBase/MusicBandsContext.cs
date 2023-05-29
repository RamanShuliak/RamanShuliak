using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.DataBase
{
    public class MusicBandsContext: DbContext
    {
        public DbSet<Band> Bands { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public MusicBandsContext(DbContextOptions<MusicBandsContext> options) 
            : base(options)
        {
        }
    }
}
