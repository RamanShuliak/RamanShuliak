using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.Repositories
{
    public class BandRepository : Repository<Band>
    {
        public BandRepository(MusicBandsContext dataBase) : base(dataBase) 
        { 
        }

    }
}
