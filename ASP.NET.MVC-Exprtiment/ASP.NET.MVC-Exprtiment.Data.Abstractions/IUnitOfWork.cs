using ASP.NET.MVC_Exprtiment.Data.Abstractions.Repositories;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Data.Abstractions
{
    public interface IUnitOfWork
    {
        public IRepository<Band> Bands { get; }
        public IRepository<Label> Labels { get; }

        Task<int> Commit();
    }
}
