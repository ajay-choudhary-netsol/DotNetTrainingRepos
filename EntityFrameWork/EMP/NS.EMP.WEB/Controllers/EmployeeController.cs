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
            _IEmployeeBusiness.AddEmployee(employeeModel);
            return View();
        }
    }
}
