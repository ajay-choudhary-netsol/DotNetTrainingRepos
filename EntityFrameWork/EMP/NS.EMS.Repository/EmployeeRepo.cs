using Microsoft.EntityFrameworkCore;
using NS.EMS.Model;
using NS.EMS.WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS.EMS.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            using (var context = new EmployeeDBContext())
            {
                Employee emp = new Employee();
                emp.EmployeeName = employeeModel.EmployeeName;
                emp.Email = employeeModel.Email;
                emp.Department = employeeModel.Department;
                emp.Mobile = employeeModel.Mobile;


                // context.Employees.Add(emp);
                context.Employee.Add(emp);
                context.SaveChanges();

            }
            return true;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> returnList = new List<Employee>();
            using (var context = new EmployeeDBContext())
            {
                var details = context.Employee.ToList();
                returnList = details;
            }

            return returnList;
        }

        public Employee GetEmployeeById(int id)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            var empid = context.Employee.Where(x => x.Eid == id).FirstOrDefault();
            return empid;
        }
        public bool EditEmployee(EmployeeModel employeeModel, int id)
        {
            using (var context = new EmployeeDBContext())
            {
                Employee emp = new Employee();
                emp.Eid = id;
                emp.EmployeeName = employeeModel.EmployeeName;
                emp.Email = employeeModel.Email;
                emp.Department = employeeModel.Department;
                emp.Mobile = employeeModel.Mobile;
                context.Entry(emp).State = EntityState.Modified;
                context.SaveChanges();
            }
            return true;
        }
        public bool DeleteEmployee(EmployeeModel employeeModel, int id)
        {
            using (var context = new EmployeeDBContext())
            {
                Employee emp = new Employee();
                emp.Eid = id;
                emp.EmployeeName = employeeModel.EmployeeName;
                emp.Email = employeeModel.Email;
                emp.Department = employeeModel.Department;
                emp.Mobile = employeeModel.Mobile;
                context.Remove(emp);
                context.SaveChanges();
            }
            return true;
        }
    }
}
