using NS.EMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS.EMS.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            using (var context = new EmployeeDBContext())
            {
                employeeList = context.Employee.ToList();
            }

            return employeeList;
        }

        public bool AddEmployee(Employee employee)
        {
            using (var context = new EmployeeDBContext())
            {
                context.Employee.Add(employee);
                context.SaveChanges();
            }
            return true;
        }


        public Employee GetEmployeeById(int eid)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            var employeeid = context.Employee.Where(x => x.Eid == eid).FirstOrDefault();
            return employeeid;

            
        }


    }
}
