using NS.EMS.Model;
using NS.EMS.WEB.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Repository
{
  public class EmployeeRepo:IEmployeeRepo
    {
      public  bool AddEmployee(EmployeeModel employeeeModel)
        {
            using(var context=new EmployeeDBContext())
            {
                Employee emp = new Employee();
                emp.EmployeeName = employeeeModel.EmployeeName;
                emp.Email = employeeeModel.Email;
                emp.Department = employeeeModel.Department;
                emp.Mobile = employeeeModel.Mobile;

                // context.Employees.Add(emp);
                context.Employee.Add(emp);
                context.SaveChanges();

            }
            return true;
        }
    }
}
