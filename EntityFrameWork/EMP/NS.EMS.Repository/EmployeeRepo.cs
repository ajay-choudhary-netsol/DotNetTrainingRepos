using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NS.EMS.Data;
using NS.EMS.Data.Entities;
using NS.EMS.Model;
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
                emp.Mobile = employeeModel.Mobile;
                emp.Gender = employeeModel.Gender;
                //emp.Deptid= context.EmpDept.SingleOrDefault(i => i.DeptName == employeeModel.Dept.ToString());
                emp.Deptid =(int)employeeModel.Deptid;
                context.Employee.Add(emp);
                context.SaveChanges();

                //-----------------Adding Using SQLRaw----------------------
                //try
                //{
                //    context.Database.ExecuteSqlRaw($"Insert into Employee(EmployeeName,Email,Mobile) Values('{employeeModel.EmployeeName}','{employeeModel.Email}','{employeeModel.Mobile}')");

                //}
                //catch(Exception e)
                //{
                //    Console.WriteLine(e);
                //}


                //-----------Adding using Stored Procedure----------
                //try
                //{
                //    var parameterList = new List<SqlParameter>();
                //   parameterList.Add(new SqlParameter("@EmployeeName", employeeModel.EmployeeName));
                //    parameterList.Add(new SqlParameter("@Email", employeeModel.Email));
                //    parameterList.Add(new SqlParameter("@Mobile", employeeModel.Mobile));
                //    parameterList.Add(new SqlParameter("@Gender", employeeModel.Gender));

                //    context.Database.ExecuteSqlRaw("usp_AddEmployee @EmployeeName, @Email, @Mobile, @Gender ", parameterList);
                //}
                //catch(Exception e)
                //{
                //    Console.WriteLine(e);
                //}


            }
            return true;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> returnList = new List<Employee>();
            using (var context = new EmployeeDBContext())
            {
                returnList = context.Employee.ToList();
            }

            return returnList;


            //------------- Selecting Using SQLRAW command------------

            //using (var context = new EmployeeDBContext())
            //{
            //    returnList= context.Employee.FromSqlRaw("Select * from Employee").ToList();
            //}
            //return returnList;

            //-------Using Stored Procedure-----------


        }
        /// <summary>
        ///    Showing all employees using the Join Stored Procedure
        /// </summary>
        /// <returns>List of employeees and respective department</returns>

        public List<EmployeeDeptModel> ShowEmployees()
        {
            List<EmployeeDeptModel> returnList = new List<EmployeeDeptModel>();
            using (var context = new EmployeeDBContext())
            {
                returnList = context.EmpDept.FromSqlRaw("usp_GetEmployees").ToList();
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
              //  emp.Department = employeeModel.Department;
                emp.Mobile = employeeModel.Mobile;
                emp.Gender = employeeModel.Gender;
                emp.Deptid =(int )employeeModel.Deptid;
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
                emp.Mobile = employeeModel.Mobile;
                emp.Gender = employeeModel.Gender;
                emp.Deptid = (int)employeeModel.Deptid;
                context.Remove(emp);
                context.SaveChanges();
            }
            return true;
        }
    }
}
