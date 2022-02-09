using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMVCAppLINQ.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVCAppLINQ.Controllers
{
    public class EmployeeController : Controller
    {

        public List<EmployeeModel> EmployeeList = new List<EmployeeModel>()
        {
            new EmployeeModel(){EmployeeId=1,EmployeeName="Ajay",Emailid="choudharyajay@gmail.com",Department="Dotnet",Salary="20000"},
            new EmployeeModel(){EmployeeId=2,EmployeeName="Abhishek",Emailid="abhsihek32@gmail.com",Department="Python",Salary="20000"},
            new EmployeeModel(){EmployeeId=3,EmployeeName="Aditya",Emailid="aditya6728@gmail.com",Department="Php",Salary="15000"},
            new EmployeeModel(){EmployeeId=4,EmployeeName="Munish",Emailid="munish32@gmail.com",Department="Dotnet",Salary="19000"},
            new EmployeeModel(){EmployeeId=5,EmployeeName="Sahil",Emailid="sahil42@gmail.com",Department="Android",Salary="22000"},
            new EmployeeModel(){EmployeeId=6,EmployeeName="Pardeep",Emailid="pardeep22@gmail.com",Department="Python",Salary="140000"}
        };


        public IActionResult GetAllEmployees()
        {
            var employee = from emp in EmployeeList
                           select emp;

            return View(employee);
        }


        public IActionResult EmployeeDetails(int id)
        {

            var employee = EmployeeList.Where(x => x.EmployeeId==id).FirstOrDefault();

            return View(employee);
        }




        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
