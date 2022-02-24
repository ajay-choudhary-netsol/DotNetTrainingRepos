using NS.EMS.Data.Entities;
using NS.EMS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
   public class EmployeeBusiness: IEmployeeBusiness
    {
        private readonly IEmployeeRepo _IEmployeeRepo;

        public EmployeeBusiness(IEmployeeRepo IEmployeeRepo)
        {
            _IEmployeeRepo = IEmployeeRepo;
        }

        public bool AddEmployee(Employee employee)
        {
            return _IEmployeeRepo.AddEmployee(employee);
        }
        public List<Employee> GetAllEmployees()
        {
            return _IEmployeeRepo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int eid)
        {
            return _IEmployeeRepo.GetEmployeeById(eid);
        }

    }
}
