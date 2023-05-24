using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;

namespace ASP.NET.MVC_Exprtiment.Data.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly MusicBandsContext _dataBase;

        public UnitOfWork(MusicBandsContext dataBase, 
            IRepository<Band> bands, IRepository<Label> labels)
        {
            _dataBase = dataBase;
            Bands = bands;
            Labels = labels;
        }

        public IRepository<Band> Bands { get; }
        public IRepository<Label> Labels { get; }

        public async Task<int> Commit()
        {
            return await _dataBase.SaveChangesAsync();
        }
    }
}
