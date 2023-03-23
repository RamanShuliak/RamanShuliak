using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Exprtiments.EF
{
    public class Classroom
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        // Сначала прописываются поля и свойства сущности

        public Guid StudentId { get; set; }
        public User Student { get; set; }
        // Внешние ключи и связанные с ними навигационные свойства
        // прописываются в самом конце.
        // Id-шник идёт первым, свойство вторым.
        // Нейминг их совпадает.

        public Guid TeacherId { get; set; }
        public User Teacher { get; set; }
    }
}
