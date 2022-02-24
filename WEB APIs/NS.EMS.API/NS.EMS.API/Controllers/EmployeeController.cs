using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NS.EMS.Business;
using NS.EMS.Data.Entities;

namespace NS.EMS.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBusiness _IEmployeeBusiness;

        public EmployeeController(IEmployeeBusiness iEmployeeBusiness)
        {
            _IEmployeeBusiness = iEmployeeBusiness;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(_IEmployeeBusiness.GetAllEmployees());
        }

        [HttpGet]
        public IActionResult GetEmployeeById(int eid)
        {
            if (_IEmployeeBusiness.GetEmployeeById(eid) == null)
            {
                return NotFound("Employee not Found");
            }
            else
            {
                return Ok(_IEmployeeBusiness.GetEmployeeById(eid));
            }
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            return Ok("Employee Added Successfully");
        }








    }
}
