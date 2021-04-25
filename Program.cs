using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkApp.Data;
using UnitOfWorkApp.Data.UnitOfWork;
using UnitOfWorkApp.Entities;

namespace UnitOfWorkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork=new UnitOfWork(new UoWContext());

            unitOfWork.DepartmentRepository.Add(new Department
            {
                Location = "İstanbul",
                Name = "Bilgi İşlem"
            });//Ram'de tutuluyor

            unitOfWork.EmployeeRepository.Add(new Employee()
            {
                DepartmentId = 1,
                FirstName = "Abdullah",
                LastName = "Öztürk",
                EmailAddress = "oabdullahozturk@yandex.com.tr",
                Location = "İstanbul",
            });//Ram'de tutuluyor

            unitOfWork.Commit();//Veritabanına kaydedildi.

            Console.ReadKey();
        }
    }
}
