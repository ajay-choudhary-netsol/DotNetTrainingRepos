using NS.EMS.Model;
using NS.EMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
   public interface IEmployeeBusiness
    {
        public bool AddEmployee(EmployeeModel employeeModel);

        List<Employee> GetAllEmployees();

        public Employee GetEmployeeById(int id);
        public bool EditEmployee(EmployeeModel employeeModel,int id);
        public bool DeleteEmployee(EmployeeModel employeeModel, int id);

        public List<EmployeeDeptModel> ShowEmployees();
    }
}
