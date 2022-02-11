using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NS.EMS.Business;
using NS.EMS.Model;

namespace NS.EMS.WEB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBusiness _IEmployeeBusiness;

        public EmployeeController(IEmployeeBusiness iEmployeeBusiness)
        {
            _IEmployeeBusiness = iEmployeeBusiness;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                _IEmployeeBusiness.AddEmployee(employeeModel);
                return RedirectToAction("Create", "Employee");
            }
            return View();
        }

        public IActionResult GetAllEmployees()
        {
            return View(_IEmployeeBusiness.GetAllEmployees());
        }



        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            return View(_IEmployeeBusiness.GetEmployeeById(id));
        }



        [HttpPost]
        public IActionResult EditEmployee(EmployeeModel employeeeModel,int id)
        {
            if (ModelState.IsValid)
            {
                _IEmployeeBusiness.EditEmployee(employeeeModel, id);
                return RedirectToAction("GetAllEmployees","Employee");
            }
            else
            {
                return View();
            }
        }
    }
}
