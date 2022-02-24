using NS.EMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Repository
{
  public interface IEmployeeRepo
    {
        bool AddEmployee(Employee employee);

        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);

    }
}
