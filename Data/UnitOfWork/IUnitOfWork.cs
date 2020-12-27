using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkApp.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public int Commit();
    }
}
