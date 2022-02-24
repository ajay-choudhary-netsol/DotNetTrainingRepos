using NS.EMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
   public interface IEmployeeBusiness
    {
     public bool AddEmployee(Employee employee);

     public   List<Employee> GetAllEmployees();

     public  Employee GetEmployeeById(int eid);

    }
}
