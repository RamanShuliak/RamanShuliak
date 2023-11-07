using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.Models
{
    public interface IBaseMessage
    {
        public Guid Id { get; set; }
    }
}
