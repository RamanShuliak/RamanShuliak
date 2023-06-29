using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.DataBase.Entities
{
    public class RefreshToken: IBaseEntity
    {
        public Guid Id { get; set; }
        public Guid Value { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
