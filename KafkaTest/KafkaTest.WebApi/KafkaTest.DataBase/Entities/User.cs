using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.DataBase.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
