using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Exprtiments.EF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var db = new SongsDbContext())
            {
                var label = db.Labels.First();
            }
        }
    }
}