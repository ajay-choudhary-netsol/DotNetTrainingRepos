using System;
using System.Collections.Generic;
using System.Text;
using NS.EMS.Model;
using NS.EMS.WEB.Entities;

namespace NS.EMS.Repository
{
    public interface IEmployeeRepo
    {
        bool AddEmployee(EmployeeModel employeeModel);

        List<Employee> GetAllEmployees();

         Employee GetEmployeeById(int id);
      
        bool EditEmployee(EmployeeModel employeeModel,int id);

        bool DeleteEmployee(EmployeeModel employeeModel, int id);

    }
}
