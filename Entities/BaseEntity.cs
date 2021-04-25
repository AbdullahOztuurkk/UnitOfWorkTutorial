using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkApp.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt => DateTime.Now;
    }
}
