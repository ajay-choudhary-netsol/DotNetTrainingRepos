using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NS.SMS.WEB.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewStudent(Student studentcs)
        {
            if (ModelState.IsValid)
            {
                if (studentcs.CoverPhoto != null)
                {
           
                }
               
            }
            return View();
        }

    }
}
