using NS.EMS.Model;
using NS.EMS.Repository;
using NS.EMS.WEB.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepo _IEmployeeRepo;
        public EmployeeBusiness(IEmployeeRepo IEmployeeRepo)
        {
            _IEmployeeRepo = IEmployeeRepo;
        }
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            return _IEmployeeRepo.AddEmployee(employeeModel);
        }
        public List<Employee> GetAllEmployees()
        {
            return _IEmployeeRepo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _IEmployeeRepo.GetEmployeeById(id);
        }

        public bool EditEmployee(EmployeeModel employeeModel,int id)
        {
            return _IEmployeeRepo.EditEmployee(employeeModel,id);
        }


    }

   
}
