using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkApp.Entities
{
    public class Department:BaseEntity
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
