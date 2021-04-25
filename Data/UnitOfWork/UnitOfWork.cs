using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkApp.Entities;

namespace UnitOfWorkApp.Data.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private UoWContext context;

        public IRepository<Employee> EmployeeRepository { get; private set; }

        public IRepository<Department> DepartmentRepository { get; private set; }

        public UnitOfWork(UoWContext _context)
        {
            this.context = _context;
            EmployeeRepository=new Repository<Employee>(context);
            DepartmentRepository=new Repository<Department>(context);
        }
        public int Commit()
        {
            return context.SaveChanges();
        }
    }
}
