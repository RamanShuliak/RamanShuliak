﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.DataBase.Entities
{
    public class Role : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
