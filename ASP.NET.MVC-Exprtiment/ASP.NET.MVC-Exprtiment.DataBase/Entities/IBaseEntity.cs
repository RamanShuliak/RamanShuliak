using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.DataBase.Entities
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
